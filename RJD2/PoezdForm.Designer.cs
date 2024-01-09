namespace RJD
{
    partial class PoezdForm
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
            this.PoezdPanel = new System.Windows.Forms.Panel();
            this.AddDescButton = new System.Windows.Forms.Button();
            this.PoezdPB = new System.Windows.Forms.PictureBox();
            this.PoezdTextBox = new System.Windows.Forms.TextBox();
            this.PoezdLabel = new System.Windows.Forms.Label();
            this.InfoPanel = new System.Windows.Forms.Panel();
            this.PoezdPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PoezdPB)).BeginInit();
            this.SuspendLayout();
            // 
            // PoezdPanel
            // 
            this.PoezdPanel.BackColor = System.Drawing.Color.LightCoral;
            this.PoezdPanel.Controls.Add(this.AddDescButton);
            this.PoezdPanel.Controls.Add(this.PoezdPB);
            this.PoezdPanel.Controls.Add(this.PoezdTextBox);
            this.PoezdPanel.Controls.Add(this.PoezdLabel);
            this.PoezdPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.PoezdPanel.Location = new System.Drawing.Point(0, 0);
            this.PoezdPanel.Margin = new System.Windows.Forms.Padding(2);
            this.PoezdPanel.Name = "PoezdPanel";
            this.PoezdPanel.Size = new System.Drawing.Size(902, 196);
            this.PoezdPanel.TabIndex = 0;
            // 
            // AddDescButton
            // 
            this.AddDescButton.Location = new System.Drawing.Point(785, 154);
            this.AddDescButton.Name = "AddDescButton";
            this.AddDescButton.Size = new System.Drawing.Size(105, 34);
            this.AddDescButton.TabIndex = 7;
            this.AddDescButton.Text = "Сохранить";
            this.AddDescButton.UseVisualStyleBackColor = true;
            this.AddDescButton.Click += new System.EventHandler(this.AddDescButton_Click);
            // 
            // PoezdPB
            // 
            this.PoezdPB.Location = new System.Drawing.Point(7, 9);
            this.PoezdPB.Margin = new System.Windows.Forms.Padding(2);
            this.PoezdPB.Name = "PoezdPB";
            this.PoezdPB.Size = new System.Drawing.Size(301, 179);
            this.PoezdPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PoezdPB.TabIndex = 3;
            this.PoezdPB.TabStop = false;
            // 
            // PoezdTextBox
            // 
            this.PoezdTextBox.Location = new System.Drawing.Point(460, 63);
            this.PoezdTextBox.Multiline = true;
            this.PoezdTextBox.Name = "PoezdTextBox";
            this.PoezdTextBox.Size = new System.Drawing.Size(319, 125);
            this.PoezdTextBox.TabIndex = 2;
            // 
            // PoezdLabel
            // 
            this.PoezdLabel.AutoSize = true;
            this.PoezdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PoezdLabel.Location = new System.Drawing.Point(324, 25);
            this.PoezdLabel.Name = "PoezdLabel";
            this.PoezdLabel.Size = new System.Drawing.Size(52, 18);
            this.PoezdLabel.TabIndex = 1;
            this.PoezdLabel.Text = "label1";
            // 
            // InfoPanel
            // 
            this.InfoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.InfoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InfoPanel.Location = new System.Drawing.Point(0, 196);
            this.InfoPanel.Margin = new System.Windows.Forms.Padding(2);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(902, 312);
            this.InfoPanel.TabIndex = 1;
            // 
            // PoezdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 508);
            this.Controls.Add(this.InfoPanel);
            this.Controls.Add(this.PoezdPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PoezdForm";
            this.Text = "PoezdForm";
            this.PoezdPanel.ResumeLayout(false);
            this.PoezdPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PoezdPB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PoezdPanel;
        private System.Windows.Forms.Panel InfoPanel;
        private System.Windows.Forms.Label PoezdLabel;
        private System.Windows.Forms.TextBox PoezdTextBox;
        private System.Windows.Forms.PictureBox PoezdPB;
        private System.Windows.Forms.Button AddDescButton;
    }
}