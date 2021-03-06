namespace ENIGBITMOVE
{
    partial class menuForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Logo = new System.Windows.Forms.Label();
            this.FilesListPanel = new System.Windows.Forms.Panel();
            this.FilesLocation = new System.Windows.Forms.TextBox();
            this.FilesLocationLabel = new System.Windows.Forms.Label();
            this.OptionLabel = new System.Windows.Forms.Label();
            this.EncryptButton = new System.Windows.Forms.RadioButton();
            this.DecryptButton = new System.Windows.Forms.RadioButton();
            this.FindButton = new System.Windows.Forms.Button();
            this.MaskLabel = new System.Windows.Forms.Label();
            this.KeyLabel = new System.Windows.Forms.Label();
            this.KeyInput = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.RunButton = new System.Windows.Forms.Button();
            this.Mask = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FileLeftArrow = new System.Windows.Forms.Button();
            this.FileRightArrow = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Logo
            // 
            this.Logo.AutoSize = true;
            this.Logo.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Logo.Location = new System.Drawing.Point(24, 9);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(167, 24);
            this.Logo.TabIndex = 0;
            this.Logo.Text = "ENIGBITMOVE";
            // 
            // FilesListPanel
            // 
            this.FilesListPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.FilesListPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FilesListPanel.Location = new System.Drawing.Point(306, 40);
            this.FilesListPanel.Name = "FilesListPanel";
            this.FilesListPanel.Size = new System.Drawing.Size(213, 308);
            this.FilesListPanel.TabIndex = 1;
            // 
            // FilesLocation
            // 
            this.FilesLocation.BackColor = System.Drawing.SystemColors.Info;
            this.FilesLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FilesLocation.Location = new System.Drawing.Point(24, 62);
            this.FilesLocation.Name = "FilesLocation";
            this.FilesLocation.Size = new System.Drawing.Size(187, 23);
            this.FilesLocation.TabIndex = 2;
            // 
            // FilesLocationLabel
            // 
            this.FilesLocationLabel.AutoSize = true;
            this.FilesLocationLabel.Location = new System.Drawing.Point(24, 44);
            this.FilesLocationLabel.Name = "FilesLocationLabel";
            this.FilesLocationLabel.Size = new System.Drawing.Size(57, 15);
            this.FilesLocationLabel.TabIndex = 3;
            this.FilesLocationLabel.Text = "Files path";
            // 
            // OptionLabel
            // 
            this.OptionLabel.AutoSize = true;
            this.OptionLabel.Location = new System.Drawing.Point(24, 102);
            this.OptionLabel.Name = "OptionLabel";
            this.OptionLabel.Size = new System.Drawing.Size(44, 15);
            this.OptionLabel.TabIndex = 5;
            this.OptionLabel.Text = "Option";
            // 
            // EncryptButton
            // 
            this.EncryptButton.AutoSize = true;
            this.EncryptButton.Enabled = false;
            this.EncryptButton.Location = new System.Drawing.Point(37, 132);
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.Size = new System.Drawing.Size(65, 19);
            this.EncryptButton.TabIndex = 6;
            this.EncryptButton.TabStop = true;
            this.EncryptButton.Text = "Encrypt";
            this.EncryptButton.UseVisualStyleBackColor = true;
            // 
            // DecryptButton
            // 
            this.DecryptButton.AutoSize = true;
            this.DecryptButton.Enabled = false;
            this.DecryptButton.Location = new System.Drawing.Point(169, 132);
            this.DecryptButton.Name = "DecryptButton";
            this.DecryptButton.Size = new System.Drawing.Size(66, 19);
            this.DecryptButton.TabIndex = 7;
            this.DecryptButton.TabStop = true;
            this.DecryptButton.Text = "Decrypt";
            this.DecryptButton.UseVisualStyleBackColor = true;
            // 
            // FindButton
            // 
            this.FindButton.Location = new System.Drawing.Point(225, 62);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(75, 23);
            this.FindButton.TabIndex = 8;
            this.FindButton.Text = "Find";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_LoadUserFiles);
            // 
            // MaskLabel
            // 
            this.MaskLabel.AutoSize = true;
            this.MaskLabel.Location = new System.Drawing.Point(24, 169);
            this.MaskLabel.Name = "MaskLabel";
            this.MaskLabel.Size = new System.Drawing.Size(35, 15);
            this.MaskLabel.TabIndex = 10;
            this.MaskLabel.Text = "Mask";
            // 
            // KeyLabel
            // 
            this.KeyLabel.AutoSize = true;
            this.KeyLabel.Location = new System.Drawing.Point(24, 229);
            this.KeyLabel.Name = "KeyLabel";
            this.KeyLabel.Size = new System.Drawing.Size(102, 15);
            this.KeyLabel.TabIndex = 11;
            this.KeyLabel.Text = "Key ( 12 numbers)";
            // 
            // KeyInput
            // 
            this.KeyInput.BackColor = System.Drawing.SystemColors.HighlightText;
            this.KeyInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.KeyInput.Enabled = false;
            this.KeyInput.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KeyInput.Location = new System.Drawing.Point(24, 257);
            this.KeyInput.MaxLength = 12;
            this.KeyInput.Multiline = true;
            this.KeyInput.Name = "KeyInput";
            this.KeyInput.Size = new System.Drawing.Size(276, 64);
            this.KeyInput.TabIndex = 12;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 388);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(531, 22);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // RunButton
            // 
            this.RunButton.Enabled = false;
            this.RunButton.Location = new System.Drawing.Point(306, 354);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(213, 23);
            this.RunButton.TabIndex = 14;
            this.RunButton.Text = "Run";
            this.RunButton.UseVisualStyleBackColor = true;
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // Mask
            // 
            this.Mask.Enabled = false;
            this.Mask.Location = new System.Drawing.Point(24, 187);
            this.Mask.MaxLength = 2;
            this.Mask.Name = "Mask";
            this.Mask.Size = new System.Drawing.Size(276, 23);
            this.Mask.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(122, 354);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Waiting..";
            // 
            // FileLeftArrow
            // 
            this.FileLeftArrow.Location = new System.Drawing.Point(467, 12);
            this.FileLeftArrow.Name = "FileLeftArrow";
            this.FileLeftArrow.Size = new System.Drawing.Size(23, 23);
            this.FileLeftArrow.TabIndex = 17;
            this.FileLeftArrow.Text = "<";
            this.FileLeftArrow.UseVisualStyleBackColor = true;
            this.FileLeftArrow.Click += new System.EventHandler(this.FileLeftArrow_Click);
            // 
            // FileRightArrow
            // 
            this.FileRightArrow.Location = new System.Drawing.Point(496, 12);
            this.FileRightArrow.Name = "FileRightArrow";
            this.FileRightArrow.Size = new System.Drawing.Size(23, 23);
            this.FileRightArrow.TabIndex = 18;
            this.FileRightArrow.Text = ">";
            this.FileRightArrow.UseVisualStyleBackColor = true;
            this.FileRightArrow.Click += new System.EventHandler(this.FileRightArrow_Click);
            // 
            // menuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 410);
            this.Controls.Add(this.FileRightArrow);
            this.Controls.Add(this.FileLeftArrow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Mask);
            this.Controls.Add(this.RunButton);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.KeyInput);
            this.Controls.Add(this.KeyLabel);
            this.Controls.Add(this.MaskLabel);
            this.Controls.Add(this.FindButton);
            this.Controls.Add(this.DecryptButton);
            this.Controls.Add(this.EncryptButton);
            this.Controls.Add(this.OptionLabel);
            this.Controls.Add(this.FilesLocationLabel);
            this.Controls.Add(this.FilesLocation);
            this.Controls.Add(this.FilesListPanel);
            this.Controls.Add(this.Logo);
            this.Name = "menuForm";
            this.Text = "ENIGBITMOVE";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Logo;
        private Panel FilesListPanel;
        private TextBox FilesLocation;
        private Label FilesLocationLabel;
        private Label OptionLabel;
        private RadioButton EncryptButton;
        private RadioButton DecryptButton;
        private Button FindButton;
        private Label MaskLabel;
        private Label KeyLabel;
        private TextBox KeyInput;
        private StatusStrip statusStrip1;
        private ToolStripProgressBar toolStripProgressBar1;
        private Button RunButton;
        private TextBox Mask;
        private Label label1;
        private Button FileLeftArrow;
        private Button FileRightArrow;
    }
}