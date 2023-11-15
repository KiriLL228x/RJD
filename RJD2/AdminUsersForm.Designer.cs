namespace RJD2
{
    partial class AdminUsersForm
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
            this.InfoUsersPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.InfoUsersPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // InfoUsersPanel
            // 
            this.InfoUsersPanel.Controls.Add(this.label2);
            this.InfoUsersPanel.Controls.Add(this.label1);
            this.InfoUsersPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InfoUsersPanel.Location = new System.Drawing.Point(0, 0);
            this.InfoUsersPanel.Name = "InfoUsersPanel";
            this.InfoUsersPanel.Size = new System.Drawing.Size(800, 450);
            this.InfoUsersPanel.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(302, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Фамилия";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Имя";
            // 
            // AdminUsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.InfoUsersPanel);
            this.Name = "AdminUsersForm";
            this.Text = "AdminUsersForm";
            this.InfoUsersPanel.ResumeLayout(false);
            this.InfoUsersPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel InfoUsersPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}