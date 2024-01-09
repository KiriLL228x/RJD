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
            this.AddPoezdsPanel = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.AddPoezdButton = new System.Windows.Forms.Button();
            this.PoezdPictureBox = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.NamePoezdTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.InfoPoezdsPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.AddPoezdsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PoezdPictureBox)).BeginInit();
            this.InfoPoezdsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddPoezdsPanel
            // 
            this.AddPoezdsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.AddPoezdsPanel.Controls.Add(this.label12);
            this.AddPoezdsPanel.Controls.Add(this.label11);
            this.AddPoezdsPanel.Controls.Add(this.AddPoezdButton);
            this.AddPoezdsPanel.Controls.Add(this.PoezdPictureBox);
            this.AddPoezdsPanel.Controls.Add(this.label8);
            this.AddPoezdsPanel.Controls.Add(this.NamePoezdTextBox);
            this.AddPoezdsPanel.Controls.Add(this.label5);
            this.AddPoezdsPanel.Controls.Add(this.label4);
            this.AddPoezdsPanel.Controls.Add(this.label9);
            this.AddPoezdsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddPoezdsPanel.Location = new System.Drawing.Point(0, 257);
            this.AddPoezdsPanel.Name = "AddPoezdsPanel";
            this.AddPoezdsPanel.Size = new System.Drawing.Size(947, 272);
            this.AddPoezdsPanel.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(23, 144);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(193, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "Поля обязательные для заполнения";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(12, 137);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 20);
            this.label11.TabIndex = 12;
            this.label11.Text = "*";
            // 
            // AddPoezdButton
            // 
            this.AddPoezdButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AddPoezdButton.Location = new System.Drawing.Point(0, 231);
            this.AddPoezdButton.Name = "AddPoezdButton";
            this.AddPoezdButton.Size = new System.Drawing.Size(947, 41);
            this.AddPoezdButton.TabIndex = 9;
            this.AddPoezdButton.Text = "Добавить";
            this.AddPoezdButton.UseVisualStyleBackColor = true;
            this.AddPoezdButton.Click += new System.EventHandler(this.AddHotelButton_Click);
            // 
            // PoezdPictureBox
            // 
            this.PoezdPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PoezdPictureBox.Location = new System.Drawing.Point(493, 41);
            this.PoezdPictureBox.Name = "PoezdPictureBox";
            this.PoezdPictureBox.Size = new System.Drawing.Size(277, 179);
            this.PoezdPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PoezdPictureBox.TabIndex = 8;
            this.PoezdPictureBox.TabStop = false;
            this.PoezdPictureBox.Click += new System.EventHandler(this.PoezdPictureBox_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(473, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Фото";
            // 
            // NamePoezdTextBox
            // 
            this.NamePoezdTextBox.Location = new System.Drawing.Point(106, 74);
            this.NamePoezdTextBox.Name = "NamePoezdTextBox";
            this.NamePoezdTextBox.Size = new System.Drawing.Size(256, 26);
            this.NamePoezdTextBox.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(101, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Название";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Добавление поезда";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(85, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 26);
            this.label9.TabIndex = 10;
            this.label9.Text = "*";
            // 
            // InfoPoezdsPanel
            // 
            this.InfoPoezdsPanel.AutoScroll = true;
            this.InfoPoezdsPanel.BackColor = System.Drawing.Color.LightCoral;
            this.InfoPoezdsPanel.Controls.Add(this.label2);
            this.InfoPoezdsPanel.Controls.Add(this.label1);
            this.InfoPoezdsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.InfoPoezdsPanel.Location = new System.Drawing.Point(0, 0);
            this.InfoPoezdsPanel.Name = "InfoPoezdsPanel";
            this.InfoPoezdsPanel.Size = new System.Drawing.Size(947, 257);
            this.InfoPoezdsPanel.TabIndex = 2;
            this.InfoPoezdsPanel.Click += new System.EventHandler(this.PoezdPictureBox_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Город";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // AdminPoezdaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 529);
            this.Controls.Add(this.AddPoezdsPanel);
            this.Controls.Add(this.InfoPoezdsPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AdminPoezdaForm";
            this.Text = "AdminPoezdaForm";
            this.Load += new System.EventHandler(this.AdminPoezdaForm_Load_1);
            this.AddPoezdsPanel.ResumeLayout(false);
            this.AddPoezdsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PoezdPictureBox)).EndInit();
            this.InfoPoezdsPanel.ResumeLayout(false);
            this.InfoPoezdsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel AddPoezdsPanel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button AddPoezdButton;
        private System.Windows.Forms.PictureBox PoezdPictureBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox NamePoezdTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel InfoPoezdsPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}