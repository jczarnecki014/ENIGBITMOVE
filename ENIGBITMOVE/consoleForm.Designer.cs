namespace ENIGBITMOVE
{
    partial class consoleForm
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
            this.ConsoleComandPanel = new System.Windows.Forms.Panel();
            this.ConsoleInfoPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ConsoleInfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConsoleComandPanel
            // 
            this.ConsoleComandPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ConsoleComandPanel.Location = new System.Drawing.Point(12, 12);
            this.ConsoleComandPanel.Name = "ConsoleComandPanel";
            this.ConsoleComandPanel.Size = new System.Drawing.Size(533, 313);
            this.ConsoleComandPanel.TabIndex = 0;
            // 
            // ConsoleInfoPanel
            // 
            this.ConsoleInfoPanel.Controls.Add(this.label2);
            this.ConsoleInfoPanel.Controls.Add(this.label1);
            this.ConsoleInfoPanel.Location = new System.Drawing.Point(551, 12);
            this.ConsoleInfoPanel.Name = "ConsoleInfoPanel";
            this.ConsoleInfoPanel.Size = new System.Drawing.Size(108, 313);
            this.ConsoleInfoPanel.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(38, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "MASK";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(38, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "MASK";
            // 
            // consoleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(671, 337);
            this.Controls.Add(this.ConsoleInfoPanel);
            this.Controls.Add(this.ConsoleComandPanel);
            this.Name = "consoleForm";
            this.Text = "ENIGBITMOVE - CONSOLE22";
            this.Shown += new System.EventHandler(this.consoleForm_Shown);
            this.ConsoleInfoPanel.ResumeLayout(false);
            this.ConsoleInfoPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel ConsoleComandPanel;
        private Panel ConsoleInfoPanel;
        private Label label1;
        private Label label2;
    }
}