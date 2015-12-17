namespace EnrollmentSystem
{
    partial class BackUpForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackUpForm));
            this.buttonsPanel = new System.Windows.Forms.Panel();
            this.backUpButton = new DevExpress.XtraEditors.SimpleButton();
            this.restoreButton = new DevExpress.XtraEditors.SimpleButton();
            this.exitButton = new DevExpress.XtraEditors.SimpleButton();
            this.candidatesBrowseButton = new System.Windows.Forms.Button();
            this.candidatesFilePathTextBox = new System.Windows.Forms.TextBox();
            this.optionsFilePathTextBox = new System.Windows.Forms.TextBox();
            this.candidatesFileLabel = new System.Windows.Forms.Label();
            this.optionsFileLabel = new System.Windows.Forms.Label();
            this.optionsBrowseButton = new System.Windows.Forms.Button();
            this.buttonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.Controls.Add(this.backUpButton);
            this.buttonsPanel.Controls.Add(this.restoreButton);
            this.buttonsPanel.Controls.Add(this.exitButton);
            this.buttonsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonsPanel.Location = new System.Drawing.Point(0, 192);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Padding = new System.Windows.Forms.Padding(4);
            this.buttonsPanel.Size = new System.Drawing.Size(480, 44);
            this.buttonsPanel.TabIndex = 21;
            // 
            // backUpButton
            // 
            this.backUpButton.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.backUpButton.Appearance.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            this.backUpButton.Appearance.BorderColor = System.Drawing.Color.White;
            this.backUpButton.Appearance.ForeColor = System.Drawing.Color.White;
            this.backUpButton.Appearance.Options.UseBackColor = true;
            this.backUpButton.Appearance.Options.UseBorderColor = true;
            this.backUpButton.Appearance.Options.UseForeColor = true;
            this.backUpButton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.backUpButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.backUpButton.Image = ((System.Drawing.Image)(resources.GetObject("backUpButton.Image")));
            this.backUpButton.Location = new System.Drawing.Point(206, 4);
            this.backUpButton.Name = "backUpButton";
            this.backUpButton.Size = new System.Drawing.Size(90, 36);
            this.backUpButton.TabIndex = 22;
            this.backUpButton.Text = "Sao lưu";
            this.backUpButton.Click += new System.EventHandler(this.backUpButton_Click);
            // 
            // restoreButton
            // 
            this.restoreButton.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.restoreButton.Appearance.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            this.restoreButton.Appearance.BorderColor = System.Drawing.Color.White;
            this.restoreButton.Appearance.ForeColor = System.Drawing.Color.White;
            this.restoreButton.Appearance.Options.UseBackColor = true;
            this.restoreButton.Appearance.Options.UseBorderColor = true;
            this.restoreButton.Appearance.Options.UseForeColor = true;
            this.restoreButton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.restoreButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.restoreButton.Image = ((System.Drawing.Image)(resources.GetObject("restoreButton.Image")));
            this.restoreButton.Location = new System.Drawing.Point(296, 4);
            this.restoreButton.Name = "restoreButton";
            this.restoreButton.Size = new System.Drawing.Size(90, 36);
            this.restoreButton.TabIndex = 23;
            this.restoreButton.Text = "Khôi phục";
            this.restoreButton.Click += new System.EventHandler(this.restoreButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.exitButton.Appearance.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            this.exitButton.Appearance.BorderColor = System.Drawing.Color.White;
            this.exitButton.Appearance.ForeColor = System.Drawing.Color.White;
            this.exitButton.Appearance.Options.UseBackColor = true;
            this.exitButton.Appearance.Options.UseBorderColor = true;
            this.exitButton.Appearance.Options.UseForeColor = true;
            this.exitButton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.exitButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.exitButton.Image = ((System.Drawing.Image)(resources.GetObject("exitButton.Image")));
            this.exitButton.Location = new System.Drawing.Point(386, 4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(90, 36);
            this.exitButton.TabIndex = 21;
            this.exitButton.Text = "Thoát";
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // candidatesBrowseButton
            // 
            this.candidatesBrowseButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.candidatesBrowseButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.candidatesBrowseButton.Location = new System.Drawing.Point(369, 54);
            this.candidatesBrowseButton.Name = "candidatesBrowseButton";
            this.candidatesBrowseButton.Size = new System.Drawing.Size(91, 33);
            this.candidatesBrowseButton.TabIndex = 22;
            this.candidatesBrowseButton.Text = "Chọn...";
            this.candidatesBrowseButton.UseVisualStyleBackColor = false;
            this.candidatesBrowseButton.Click += new System.EventHandler(this.candidatesBrowseButton_Click);
            // 
            // candidatesFilePathTextBox
            // 
            this.candidatesFilePathTextBox.Location = new System.Drawing.Point(189, 61);
            this.candidatesFilePathTextBox.Name = "candidatesFilePathTextBox";
            this.candidatesFilePathTextBox.Size = new System.Drawing.Size(163, 20);
            this.candidatesFilePathTextBox.TabIndex = 23;
            // 
            // optionsFilePathTextBox
            // 
            this.optionsFilePathTextBox.Location = new System.Drawing.Point(189, 108);
            this.optionsFilePathTextBox.Name = "optionsFilePathTextBox";
            this.optionsFilePathTextBox.Size = new System.Drawing.Size(163, 20);
            this.optionsFilePathTextBox.TabIndex = 24;
            // 
            // candidatesFileLabel
            // 
            this.candidatesFileLabel.AutoSize = true;
            this.candidatesFileLabel.Location = new System.Drawing.Point(24, 64);
            this.candidatesFileLabel.Name = "candidatesFileLabel";
            this.candidatesFileLabel.Size = new System.Drawing.Size(133, 13);
            this.candidatesFileLabel.TabIndex = 27;
            this.candidatesFileLabel.Text = "Tên file danh sách thí sinh";
            // 
            // optionsFileLabel
            // 
            this.optionsFileLabel.AutoSize = true;
            this.optionsFileLabel.Location = new System.Drawing.Point(24, 111);
            this.optionsFileLabel.Name = "optionsFileLabel";
            this.optionsFileLabel.Size = new System.Drawing.Size(107, 13);
            this.optionsFileLabel.TabIndex = 28;
            this.optionsFileLabel.Text = "Tên file nguyện vọng";
            // 
            // optionsBrowseButton
            // 
            this.optionsBrowseButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.optionsBrowseButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.optionsBrowseButton.Location = new System.Drawing.Point(369, 101);
            this.optionsBrowseButton.Name = "optionsBrowseButton";
            this.optionsBrowseButton.Size = new System.Drawing.Size(91, 33);
            this.optionsBrowseButton.TabIndex = 29;
            this.optionsBrowseButton.Text = "Chọn...";
            this.optionsBrowseButton.UseVisualStyleBackColor = false;
            this.optionsBrowseButton.Click += new System.EventHandler(this.optionsBrowseButton_Click);
            // 
            // BackUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(480, 236);
            this.Controls.Add(this.optionsBrowseButton);
            this.Controls.Add(this.optionsFileLabel);
            this.Controls.Add(this.candidatesFileLabel);
            this.Controls.Add(this.optionsFilePathTextBox);
            this.Controls.Add(this.candidatesFilePathTextBox);
            this.Controls.Add(this.candidatesBrowseButton);
            this.Controls.Add(this.buttonsPanel);
            this.Name = "BackUpForm";
            this.Text = "Sao lưu và khôi phục";
            this.buttonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Panel buttonsPanel;
        private System.Windows.Forms.Button candidatesBrowseButton;
        private System.Windows.Forms.TextBox candidatesFilePathTextBox;
        private DevExpress.XtraEditors.SimpleButton backUpButton;
        private DevExpress.XtraEditors.SimpleButton exitButton;
        private System.Windows.Forms.TextBox optionsFilePathTextBox;
        private DevExpress.XtraEditors.SimpleButton restoreButton;
        private System.Windows.Forms.Label candidatesFileLabel;
        private System.Windows.Forms.Label optionsFileLabel;
        private System.Windows.Forms.Button optionsBrowseButton;
    }
}