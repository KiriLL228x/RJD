namespace RJD2
{
    partial class AdminPoezdaForm
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
            this.InfoPoezdaPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.AddPoezdaPanel = new System.Windows.Forms.Panel();
            this.InfoPoezdaPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // InfoPoezdaPanel
            // 
            this.InfoPoezdaPanel.Controls.Add(this.label1);
            this.InfoPoezdaPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.InfoPoezdaPanel.Location = new System.Drawing.Point(0, 0);
            this.InfoPoezdaPanel.Name = "InfoPoezdaPanel";
            this.InfoPoezdaPanel.Size = new System.Drawing.Size(823, 199);
            this.InfoPoezdaPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название";
            // 
            // AddPoezdaPanel
            // 
            this.AddPoezdaPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddPoezdaPanel.Location = new System.Drawing.Point(0, 199);
            this.AddPoezdaPanel.Name = "AddPoezdaPanel";
            this.AddPoezdaPanel.Size = new System.Drawing.Size(823, 248);
            this.AddPoezdaPanel.TabIndex = 1;
            // 
            // AdminPoezdaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 447);
            this.Controls.Add(this.AddPoezdaPanel);
            this.Controls.Add(this.InfoPoezdaPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AdminPoezdaForm";
            this.Text = "AdminPoezdaForm";
            this.InfoPoezdaPanel.ResumeLayout(false);
            this.InfoPoezdaPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel InfoPoezdaPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel AddPoezdaPanel;
    }
}