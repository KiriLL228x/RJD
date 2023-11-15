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
            this.PoezdPB = new System.Windows.Forms.PictureBox();
            this.PoezdTextBox = new System.Windows.Forms.TextBox();
            this.PoezdLabel = new System.Windows.Forms.Label();
            this.InfoPanel = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.PoezdPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PoezdPB)).BeginInit();
            this.InfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // PoezdPanel
            // 
            this.PoezdPanel.Controls.Add(this.PoezdPB);
            this.PoezdPanel.Controls.Add(this.PoezdTextBox);
            this.PoezdPanel.Controls.Add(this.PoezdLabel);
            this.PoezdPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.PoezdPanel.Location = new System.Drawing.Point(0, 0);
            this.PoezdPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PoezdPanel.Name = "PoezdPanel";
            this.PoezdPanel.Size = new System.Drawing.Size(602, 196);
            this.PoezdPanel.TabIndex = 0;
            // 
            // PoezdPB
            // 
            this.PoezdPB.Location = new System.Drawing.Point(7, 9);
            this.PoezdPB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PoezdPB.Name = "PoezdPB";
            this.PoezdPB.Size = new System.Drawing.Size(261, 179);
            this.PoezdPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PoezdPB.TabIndex = 3;
            this.PoezdPB.TabStop = false;
            // 
            // PoezdTextBox
            // 
            this.PoezdTextBox.Location = new System.Drawing.Point(328, 22);
            this.PoezdTextBox.Multiline = true;
            this.PoezdTextBox.Name = "PoezdTextBox";
            this.PoezdTextBox.Size = new System.Drawing.Size(251, 154);
            this.PoezdTextBox.TabIndex = 2;
            // 
            // PoezdLabel
            // 
            this.PoezdLabel.AutoSize = true;
            this.PoezdLabel.Location = new System.Drawing.Point(275, 23);
            this.PoezdLabel.Name = "PoezdLabel";
            this.PoezdLabel.Size = new System.Drawing.Size(35, 13);
            this.PoezdLabel.TabIndex = 1;
            this.PoezdLabel.Text = "label1";
            // 
            // InfoPanel
            // 
            this.InfoPanel.Controls.Add(this.pictureBox3);
            this.InfoPanel.Controls.Add(this.pictureBox2);
            this.InfoPanel.Controls.Add(this.pictureBox4);
            this.InfoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InfoPanel.Location = new System.Drawing.Point(0, 196);
            this.InfoPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(602, 170);
            this.InfoPanel.TabIndex = 1;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(2, 5);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(201, 155);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "Plackart";
            this.pictureBox3.Click += new System.EventHandler(this.Room_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(208, 5);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(193, 155);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "SV";
            this.pictureBox2.ClientSizeChanged += new System.EventHandler(this.Room_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(405, 5);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(193, 155);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "Kupe";
            this.pictureBox4.ClientSizeChanged += new System.EventHandler(this.Room_Click);
            // 
            // PoezdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 366);
            this.Controls.Add(this.InfoPanel);
            this.Controls.Add(this.PoezdPanel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PoezdForm";
            this.Text = "PoezdForm";
            this.PoezdPanel.ResumeLayout(false);
            this.PoezdPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PoezdPB)).EndInit();
            this.InfoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PoezdPanel;
        private System.Windows.Forms.Panel InfoPanel;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label PoezdLabel;
        private System.Windows.Forms.TextBox PoezdTextBox;
        private System.Windows.Forms.PictureBox PoezdPB;
    }
}