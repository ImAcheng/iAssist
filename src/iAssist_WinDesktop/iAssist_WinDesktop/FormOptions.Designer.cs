namespace iAssist_WinDesktop {
    partial class FormOptions {
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
            btnChangeTopMost = new AntdUI.Button();
            btnModel = new AntdUI.Button();
            button2 = new AntdUI.Button();
            SuspendLayout();
            // 
            // btnChangeTopMost
            // 
            btnChangeTopMost.Dock = DockStyle.Top;
            btnChangeTopMost.IconHoverSvg = "CheckOutlined";
            btnChangeTopMost.IconPosition = AntdUI.TAlignMini.Right;
            btnChangeTopMost.IconSvg = "CheckOutlined";
            btnChangeTopMost.Location = new Point(0, 0);
            btnChangeTopMost.Name = "btnChangeTopMost";
            btnChangeTopMost.Size = new Size(200, 50);
            btnChangeTopMost.TabIndex = 0;
            btnChangeTopMost.Text = "是否至頂:";
            btnChangeTopMost.Click += btnChangeTopMost_Click;
            // 
            // btnModel
            // 
            btnModel.Dock = DockStyle.Top;
            btnModel.IconHoverSvg = "";
            btnModel.IconPosition = AntdUI.TAlignMini.Right;
            btnModel.IconSvg = "";
            btnModel.Location = new Point(0, 50);
            btnModel.Name = "btnModel";
            btnModel.Size = new Size(200, 50);
            btnModel.TabIndex = 1;
            btnModel.Text = "使用模型: Qwen";
            btnModel.Click += btnModel_Click;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Top;
            button2.Enabled = false;
            button2.IconHoverSvg = "";
            button2.IconPosition = AntdUI.TAlignMini.Right;
            button2.IconSvg = "";
            button2.Location = new Point(0, 100);
            button2.Name = "button2";
            button2.Size = new Size(200, 50);
            button2.TabIndex = 2;
            button2.Text = "語言: 正體中文";
            // 
            // FormOptions
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(200, 150);
            Controls.Add(button2);
            Controls.Add(btnModel);
            Controls.Add(btnChangeTopMost);
            Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "FormOptions";
            Text = "FormOptions";
            Load += FormOptions_Load;
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Button btnChangeTopMost;
        private AntdUI.Button btnModel;
        private AntdUI.Button button2;
    }
}