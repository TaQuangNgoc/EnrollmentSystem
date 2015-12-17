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
            this.browseButton = new System.Windows.Forms.Button();
            this.candidatesFileNameTextBox = new System.Windows.Forms.TextBox();
            this.optionsFileNameTextBox = new System.Windows.Forms.TextBox();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.pathLabel = new System.Windows.Forms.Label();
            this.candidatesFileLabel = new System.Windows.Forms.Label();
            this.optionsFileLabel = new System.Windows.Forms.Label();
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
            // browseButton
            // 
            this.browseButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.browseButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.browseButton.Location = new System.Drawing.Point(366, 32);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(91, 33);
            this.browseButton.TabIndex = 22;
            this.browseButton.Text = "Chọn thư mục";
            this.browseButton.UseVisualStyleBackColor = false;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // candidatesFileNameTextBox
            // 
            this.candidatesFileNameTextBox.Location = new System.Drawing.Point(186, 89);
            this.candidatesFileNameTextBox.Name = "candidatesFileNameTextBox";
            this.candidatesFileNameTextBox.Size = new System.Drawing.Size(163, 20);
            this.candidatesFileNameTextBox.TabIndex = 23;
            // 
            // optionsFileNameTextBox
            // 
            this.optionsFileNameTextBox.Location = new System.Drawing.Point(186, 136);
            this.optionsFileNameTextBox.Name = "optionsFileNameTextBox";
            this.optionsFileNameTextBox.Size = new System.Drawing.Size(163, 20);
            this.optionsFileNameTextBox.TabIndex = 24;
            // 
            // pathTextBox
            // 
            this.pathTextBox.Location = new System.Drawing.Point(76, 39);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(273, 20);
            this.pathTextBox.TabIndex = 25;
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Location = new System.Drawing.Point(21, 42);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(49, 13);
            this.pathLabel.TabIndex = 26;
            this.pathLabel.Text = "Thư mục";
            // 
            // candidatesFileLabel
            // 
            this.candidatesFileLabel.AutoSize = true;
            this.candidatesFileLabel.Location = new System.Drawing.Point(21, 92);
            this.candidatesFileLabel.Name = "candidatesFileLabel";
            this.candidatesFileLabel.Size = new System.Drawing.Size(133, 13);
            this.candidatesFileLabel.TabIndex = 27;
            this.candidatesFileLabel.Text = "Tên file danh sách thí sinh";
            // 
            // optionsFileLabel
            // 
            this.optionsFileLabel.AutoSize = true;
            this.optionsFileLabel.Location = new System.Drawing.Point(21, 139);
            this.optionsFileLabel.Name = "optionsFileLabel";
            this.optionsFileLabel.Size = new System.Drawing.Size(107, 13);
            this.optionsFileLabel.TabIndex = 28;
            this.optionsFileLabel.Text = "Tên file nguyện vọng";
            // 
            // BackUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(480, 236);
            this.Controls.Add(this.optionsFileLabel);
            this.Controls.Add(this.candidatesFileLabel);
            this.Controls.Add(this.pathLabel);
            this.Controls.Add(this.pathTextBox);
            this.Controls.Add(this.optionsFileNameTextBox);
            this.Controls.Add(this.candidatesFileNameTextBox);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.buttonsPanel);
            this.Name = "BackUpForm";
            this.Text = "Sao lưu và khôi phục";
            this.buttonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Panel buttonsPanel;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.TextBox candidatesFileNameTextBox;
        private DevExpress.XtraEditors.SimpleButton backUpButton;
        private DevExpress.XtraEditors.SimpleButton exitButton;
        private System.Windows.Forms.TextBox optionsFileNameTextBox;
        private DevExpress.XtraEditors.SimpleButton restoreButton;
        private System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.Label candidatesFileLabel;
        private System.Windows.Forms.Label optionsFileLabel;
    }
}