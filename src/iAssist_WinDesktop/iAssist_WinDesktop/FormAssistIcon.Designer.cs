namespace iAssist_WinDesktop {
    partial class FormAssistIcon {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            tbInput = new AntdUI.Input();
            btnTrans = new AntdUI.Button();
            btnSummary = new AntdUI.Button();
            btnSentenceFix = new AntdUI.Button();
            pageHeader1 = new AntdUI.PageHeader();
            SuspendLayout();
            // 
            // tbInput
            // 
            tbInput.Dock = DockStyle.Fill;
            tbInput.Location = new Point(0, 27);
            tbInput.Name = "tbInput";
            tbInput.PlaceholderText = "輸入一些文字吧!";
            tbInput.Size = new Size(160, 63);
            tbInput.TabIndex = 0;
            // 
            // btnTrans
            // 
            btnTrans.DefaultBack = Color.RoyalBlue;
            btnTrans.Dock = DockStyle.Right;
            btnTrans.ForeColor = Color.White;
            btnTrans.Location = new Point(160, 27);
            btnTrans.Name = "btnTrans";
            btnTrans.Size = new Size(75, 63);
            btnTrans.TabIndex = 1;
            btnTrans.Text = "翻譯";
            btnTrans.Click += btnTrans_Click;
            // 
            // btnSummary
            // 
            btnSummary.DefaultBack = Color.RoyalBlue;
            btnSummary.Dock = DockStyle.Right;
            btnSummary.ForeColor = Color.White;
            btnSummary.Location = new Point(235, 27);
            btnSummary.Name = "btnSummary";
            btnSummary.Size = new Size(75, 63);
            btnSummary.TabIndex = 2;
            btnSummary.Text = "摘要";
            btnSummary.Click += btnSummary_Click;
            // 
            // btnSentenceFix
            // 
            btnSentenceFix.DefaultBack = Color.RoyalBlue;
            btnSentenceFix.Dock = DockStyle.Right;
            btnSentenceFix.ForeColor = Color.White;
            btnSentenceFix.Location = new Point(310, 27);
            btnSentenceFix.Name = "btnSentenceFix";
            btnSentenceFix.Size = new Size(75, 63);
            btnSentenceFix.TabIndex = 3;
            btnSentenceFix.Text = "修正";
            btnSentenceFix.Click += btnSentenceFix_Click;
            // 
            // pageHeader1
            // 
            pageHeader1.Dock = DockStyle.Top;
            pageHeader1.Location = new Point(0, 0);
            pageHeader1.MaximizeBox = false;
            pageHeader1.MinimizeBox = false;
            pageHeader1.Name = "pageHeader1";
            pageHeader1.ShowButton = true;
            pageHeader1.Size = new Size(385, 27);
            pageHeader1.TabIndex = 4;
            pageHeader1.Text = "iAssist";
            // 
            // FormAssistIcon
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(385, 90);
            Controls.Add(tbInput);
            Controls.Add(btnTrans);
            Controls.Add(btnSummary);
            Controls.Add(btnSentenceFix);
            Controls.Add(pageHeader1);
            Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "FormAssistIcon";
            Resizable = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "iAssist";
            TopMost = true;
            Load += FormAssistIcon_Load;
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Input tbInput;
        private AntdUI.Button btnTrans;
        private AntdUI.Button btnSummary;
        private AntdUI.Button btnSentenceFix;
        private AntdUI.PageHeader pageHeader1;
    }
}
