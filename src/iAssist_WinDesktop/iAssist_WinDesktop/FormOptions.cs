using AntdUI;
using iAssist_WinDesktop.Extentions;

namespace iAssist_WinDesktop {
    public partial class FormOptions : Window {
        public FormOptions() {
            InitializeComponent();
        }

        private System.Windows.Forms.Timer FocusCheckerTimer = new System.Windows.Forms.Timer() {
            Interval = 100,
            Enabled = true
        };

        private bool IsTopMost = true;
        private string Lang = "zh-TW";

        private void FormOptions_Load(object sender, EventArgs e) {
            FocusCheckerTimer.Tick += FocusCheckerTimer_Tick;
            _SetModel(0);
        }

        private void FocusCheckerTimer_Tick(object? sender, EventArgs e) {
            // check if any control were focused

            if (this.ContainsFocus) return;

            this.Hide();
        }

        private void btnChangeTopMost_Click(object sender, EventArgs e) {
            IsTopMost = !IsTopMost;
            FormAssistIcon.Instance.TopMost = IsTopMost;
            this.Focus();
            btnChangeTopMost.IconSvg = IsTopMost ? "CheckOutlined" : "StopOutlined";
            btnChangeTopMost.IconHoverSvg = IsTopMost ? "CheckOutlined" : "StopOutlined";
        }

        private int _ModelPointer = 0;
        private void btnModel_Click(object sender, EventArgs e) {
            _SetModel();
        }

        private void _SetModel(int? index = null) {
            // get data from ModelNameList
            // if index is null, then use _ModelPointer, which is designed as a circular index
            // else, use index

            if (index == null)
                _ModelPointer = MathHelper.CircularClamp(_ModelPointer + 1, 0, LlmService.ModelNameList.Count - 1);

            var data = LlmService.ModelNameList[index == null ? _ModelPointer : (index ?? 0)];
            btnModel.Text = $"使用模型: {data.DisplayName}";
            LlmService.UsingModel = data.ModelName;
        }
    }

    public class iAssistOption {
        public bool IsTopMost { get; set; } = true;
    }
}
