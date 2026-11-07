namespace iAssist_WinDesktop {
    partial class FormResult {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            pageHeader1 = new AntdUI.PageHeader();
            label1 = new Label();
            rtbOriginal = new RichTextBox();
            rtbResult = new RichTextBox();
            lbResultType = new Label();
            SuspendLayout();
            // 
            // pageHeader1
            // 
            pageHeader1.Dock = DockStyle.Top;
            pageHeader1.Location = new Point(0, 0);
            pageHeader1.MaximizeBox = false;
            pageHeader1.MinimizeBox = false;
            pageHeader1.Name = "pageHeader1";
            pageHeader1.ShowButton = true;
            pageHeader1.Size = new Size(400, 32);
            pageHeader1.TabIndex = 0;
            pageHeader1.Text = " ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 35);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.TabIndex = 1;
            label1.Text = "原文";
            // 
            // rtbOriginal
            // 
            rtbOriginal.BackColor = Color.White;
            rtbOriginal.BorderStyle = BorderStyle.None;
            rtbOriginal.Location = new Point(12, 58);
            rtbOriginal.Name = "rtbOriginal";
            rtbOriginal.ReadOnly = true;
            rtbOriginal.ScrollBars = RichTextBoxScrollBars.Vertical;
            rtbOriginal.Size = new Size(376, 96);
            rtbOriginal.TabIndex = 2;
            rtbOriginal.Text = "";
            // 
            // rtbResult
            // 
            rtbResult.BackColor = Color.White;
            rtbResult.BorderStyle = BorderStyle.None;
            rtbResult.Location = new Point(12, 192);
            rtbResult.Name = "rtbResult";
            rtbResult.ReadOnly = true;
            rtbResult.ScrollBars = RichTextBoxScrollBars.Vertical;
            rtbResult.Size = new Size(376, 146);
            rtbResult.TabIndex = 4;
            rtbResult.Text = "";
            // 
            // lbResultType
            // 
            lbResultType.AutoSize = true;
            lbResultType.Location = new Point(12, 169);
            lbResultType.Name = "lbResultType";
            lbResultType.Size = new Size(84, 20);
            lbResultType.TabIndex = 3;
            lbResultType.Text = "{type}結果";
            // 
            // FormResult
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 350);
            Controls.Add(rtbResult);
            Controls.Add(lbResultType);
            Controls.Add(rtbOriginal);
            Controls.Add(label1);
            Controls.Add(pageHeader1);
            Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "FormResult";
            Resizable = false;
            Text = "iAssist Result";
            Load += FormResult_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private AntdUI.PageHeader pageHeader1;
        private Label label1;
        private RichTextBox rtbOriginal;
        private RichTextBox rtbResult;
        private Label lbResultType;
    }
}