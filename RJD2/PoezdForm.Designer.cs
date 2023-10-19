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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PoezdForm));
            this.PoezdPanel = new System.Windows.Forms.Panel();
            this.PoezdTextBox = new System.Windows.Forms.TextBox();
            this.PoezdLabel = new System.Windows.Forms.Label();
            this.InfoPanel = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.PoezdPB = new System.Windows.Forms.PictureBox();
            this.PoezdPanel.SuspendLayout();
            this.InfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PoezdPB)).BeginInit();
            this.SuspendLayout();
            // 
            // PoezdPanel
            // 
            this.PoezdPanel.Controls.Add(this.PoezdPB);
            this.PoezdPanel.Controls.Add(this.PoezdTextBox);
            this.PoezdPanel.Controls.Add(this.PoezdLabel);
            this.PoezdPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.PoezdPanel.Location = new System.Drawing.Point(0, 0);
            this.PoezdPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PoezdPanel.Name = "PoezdPanel";
            this.PoezdPanel.Size = new System.Drawing.Size(800, 241);
            this.PoezdPanel.TabIndex = 0;
            // 
            // PoezdTextBox
            // 
            this.PoezdTextBox.Location = new System.Drawing.Point(437, 27);
            this.PoezdTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PoezdTextBox.Multiline = true;
            this.PoezdTextBox.Name = "PoezdTextBox";
            this.PoezdTextBox.Size = new System.Drawing.Size(333, 189);
            this.PoezdTextBox.TabIndex = 2;
            // 
            // PoezdLabel
            // 
            this.PoezdLabel.AutoSize = true;
            this.PoezdLabel.Location = new System.Drawing.Point(367, 28);
            this.PoezdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PoezdLabel.Name = "PoezdLabel";
            this.PoezdLabel.Size = new System.Drawing.Size(44, 16);
            this.PoezdLabel.TabIndex = 1;
            this.PoezdLabel.Text = "label1";
            // 
            // InfoPanel
            // 
            this.InfoPanel.Controls.Add(this.pictureBox3);
            this.InfoPanel.Controls.Add(this.pictureBox2);
            this.InfoPanel.Controls.Add(this.pictureBox4);
            this.InfoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InfoPanel.Location = new System.Drawing.Point(0, 241);
            this.InfoPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(800, 209);
            this.InfoPanel.TabIndex = 1;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(3, 6);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(268, 191);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "Plackart";
            this.pictureBox3.Click += new System.EventHandler(this.Room_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(277, 6);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(257, 191);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "SV";
            this.pictureBox2.ClientSizeChanged += new System.EventHandler(this.Room_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(540, 6);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(257, 191);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "Kupe";
            this.pictureBox4.ClientSizeChanged += new System.EventHandler(this.Room_Click);
            // 
            // PoezdPB
            // 
            this.PoezdPB.Location = new System.Drawing.Point(9, 11);
            this.PoezdPB.Name = "PoezdPB";
            this.PoezdPB.Size = new System.Drawing.Size(348, 220);
            this.PoezdPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PoezdPB.TabIndex = 3;
            this.PoezdPB.TabStop = false;
            // 
            // PoezdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.InfoPanel);
            this.Controls.Add(this.PoezdPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PoezdForm";
            this.Text = "PoezdForm";
            this.PoezdPanel.ResumeLayout(false);
            this.PoezdPanel.PerformLayout();
            this.InfoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PoezdPB)).EndInit();
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