namespace iAssist_WinDesktop {
    public partial class FormAssistIcon : AntdUI.Window {
        public FormAssistIcon() {
            InitializeComponent();
        }

        public static FormAssistIcon Instance;

        private void FormAssistIcon_Load(object sender, EventArgs e) {
            Instance = this;

            foreach (Control ctrl in Controls) {
                ctrl.MouseDown += Ctrl_MouseDown;
            }
        }

        private FormOptions _OptionBox = new FormOptions() {
            StartPosition = FormStartPosition.Manual,
            Location = MousePosition,
            TopMost = true
        };

        private void Ctrl_MouseDown(object? sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Right) {
                _OptionBox.Location = MousePosition;
                _OptionBox.Show();
            }
        }

        private FormResult? _ResultForm = null;

        private async void btnTrans_Click(object sender, EventArgs e) {
            _ResultForm?.Dispose();
            _ResultForm = new FormResult("translate", "翻譯", tbInput.Text);
            _ResultForm.Show();
            tbInput.Clear();
        }

        private void btnSummary_Click(object sender, EventArgs e) {
            _ResultForm?.Dispose();
            _ResultForm = new FormResult("summary", "總結", tbInput.Text);
            _ResultForm.Show();
            tbInput.Clear();
        }

        private void btnSentenceFix_Click(object sender, EventArgs e) {
            _ResultForm?.Dispose();
            _ResultForm = new FormResult("fix", "修正", tbInput.Text);
            _ResultForm.Show();
            tbInput.Clear();
        }
    }
}
