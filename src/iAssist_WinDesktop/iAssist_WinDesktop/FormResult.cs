using AntdUI;

namespace iAssist_WinDesktop {
    public partial class FormResult : Window {
        private readonly string _RequestCode;
        private readonly string _TaskName;
        private readonly string _Original;

        public FormResult(string requestCode, string taskName, string originalText) {
            InitializeComponent();
            _RequestCode = requestCode;
            _TaskName = taskName;
            _Original = originalText;
        }

        private async void FormResult_Load(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(_Original)) {
                this.Close();
                return;
            }

            pageHeader1.Text = "Thinking";
            lbResultType.Text = $"{_TaskName}結果";
            rtbOriginal.Text = _Original;

            pageHeader1.Loading = true;
            await foreach (var text in LlmService.RequestHelp(_RequestCode, _Original)) {
                rtbResult.Text += text ?? "";
            }
            pageHeader1.Loading = false;

            pageHeader1.Text = " ";
        }
    }
}
