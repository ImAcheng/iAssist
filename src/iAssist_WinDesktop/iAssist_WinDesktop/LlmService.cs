using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace iAssist_WinDesktop {
    public static class LlmService {
        // this can be modified by users (later)
        public static List<LlmModel> ModelNameList =
            new List<LlmModel>() {
                new LlmModel("Llama", "llama3.2:3b"),       // from Meta
                new LlmModel("Gemma", "gemma3:4b"),         // from Google
                new LlmModel("Phi4-mini", "phi4-mini:3.8b") // from Microsoft
            };

        public static string ServiceUri = "http://localhost:11434/api/chat";
        public static string UsingModel = "llama3.2:3b";

        // prompts for the three functions
        private static readonly Dictionary<string, string> _Prompts =
            new Dictionary<string, string>() {
                { "translate",
                    "你是一名專業的中文翻譯人員。"
                    + "請將使用者提供的內容準確翻譯成繁體中文(zh-TW)，僅輸出結果，無須其他內容。"
                    + "翻譯時應完整保留原文的意思與重要資訊，並依照上下文調整語句，使翻譯自然、通順且符合中文表達習慣。"
                    + "不得自行添加、刪除或改變原文的意思。" },

                { "summary",
                    "你是一名專業的文字摘要人員。"
                    + "請將使用者提供的內容整理並摘要，使讀者能在三句話以內理解原文的主要內容，使用繁體中文輸出結果，僅輸出結果，無須其他內容。"
                    + "摘要必須保留原文的重要資訊與核心觀點，內容應具備邏輯性並符合原文主旨。"
                    + "不得自行添加原文沒有提及的資訊，也不得扭曲或改變原文的意思。" },

                { "fix",
                    "你是一名專業的文字校對人員。"
                    + "請用使用者提供的語言檢查並修正使用者提供的內容，包括文法、錯字、標點符號及不自然的語句。"
                    + "輸出內容也必須是使用者原本使用的語言，若使用者原本使用英文，那就用英文進行更改與輸出;"
                    + "若使用者原本使用中文，那就用中文進行更改與輸出，不得產生與使用者提供的內容不同的語言。"
                    + "僅輸出結果，無須其他內容。"
                    + "修正後的內容應保持原文的意思與內容，不得自行添加額外資訊或改變原意。"
                    + "若原文沒有明顯錯誤，請不要任意修改內容。" }
            };

        private static HttpClient _ApiClient = new HttpClient();

        /// <summary>
        /// Directly request from LLM API (I use ollama)
        /// Use native HTTP request to make sure everyone can use their own API service.
        /// </summary>
        public static async IAsyncEnumerable<string?> RequestHelp(string code, string ctx) {
            // Get prompt first
            string? prompt = "";
            if (!_Prompts.TryGetValue(code, out prompt)) {
                yield return "您嘗試使用一個不存在的功能。";
                yield break;
            }

            // Reference: https://docs.ollama.com/api/chat 
            //            https://www.glukhov.org/llm-hosting/ollama/ollama-python-examples/
            var _RequestContent = new {
                model = UsingModel,
                messages = new[] {
                    new { role = "system", content = prompt },
                    new { role = "user", content = ctx }
                }, stream = true
            };

            using var request = new HttpRequestMessage(HttpMethod.Post, ServiceUri);
            request.Content = new StringContent(JsonSerializer.Serialize(_RequestContent), Encoding.UTF8, "application/json");

            RequestError reError = RequestError.None;

            HttpResponseMessage? resp = null;

            try {
                resp = await _ApiClient.SendAsync(request);
            }
            catch {
                reError = RequestError.InternetError;
            }

            if (resp == null || reError == RequestError.InternetError) {
                yield return "抱歉，你無法連線至LLM。";
                yield break;
            }
            
            using var stream = await resp.Content.ReadAsStreamAsync();
            using var sr = new StreamReader(stream);

            while (!sr.EndOfStream) {
                ResponseBody? content = null;

                try {
                    var json = await sr.ReadLineAsync();

                    if (string.IsNullOrWhiteSpace(json)) yield break;
                    content = JsonSerializer.Deserialize<ResponseBody>(json);

                    if (content == null) throw new JsonException();
                    if (content.Error != null) throw new ObjectDisposedException("model");
                }
                catch (ObjectDisposedException) {
                    reError = RequestError.ModelRequestError;
                    break;
                }
                catch (HttpRequestException) {
                    reError = RequestError.JsonDecodingError;
                    break;
                }
                catch (JsonException) {
                    reError = RequestError.JsonDecodingError;
                    break;
                }

                if (content == null || content.Message == null) yield break;
                yield return content.Message.Content;
                if (content?.Done ?? true) yield break;
            }

            switch (reError) {
                case RequestError.InternetError:
                    yield return "抱歉，你無法連線至LLM。";
                    break;

                case RequestError.ModelRequestError:
                    yield return "抱歉，無法使用要求的模型。";
                    break;

                case RequestError.JsonDecodingError:
                    yield return "抱歉，無法解析模型回傳的資料。";
                    break;
            }
        }
    }

    public struct LlmModel {
        public string DisplayName;
        public string ModelName;

        public LlmModel(string name, string model) {
            DisplayName = name;
            ModelName = model;
        }
    }

    public enum RequestError {
        None,
        JsonDecodingError,
        ModelRequestError,
        InternetError
    }

    public class ResponseBody {
        [JsonPropertyName("error")]
        public string? Error { get; set; } = null;
        [JsonPropertyName("done")]
        public bool Done { get; set; }
        [JsonPropertyName("message")]
        public MessageChild? Message { get; set; }
    }

    public class MessageChild {
        [JsonPropertyName("content")]
        public string Content { get; set; } = string.Empty;
        [JsonPropertyName("thinking")]
        public string Thinking { get; set; } = string.Empty;
    }
}
