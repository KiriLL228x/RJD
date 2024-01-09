namespace RJD2
{
    partial class AdminMestaForm
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
            this.AddRoomsPanel = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.AddMestaButton = new System.Windows.Forms.Button();
            this.RoomPictureBox = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.PoezdsComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.NameRoomTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.InfoMestaPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.AddRoomsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoomPictureBox)).BeginInit();
            this.InfoMestaPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddRoomsPanel
            // 
            this.AddRoomsPanel.BackColor = System.Drawing.Color.Silver;
            this.AddRoomsPanel.Controls.Add(this.label12);
            this.AddRoomsPanel.Controls.Add(this.label11);
            this.AddRoomsPanel.Controls.Add(this.AddMestaButton);
            this.AddRoomsPanel.Controls.Add(this.RoomPictureBox);
            this.AddRoomsPanel.Controls.Add(this.label8);
            this.AddRoomsPanel.Controls.Add(this.PoezdsComboBox);
            this.AddRoomsPanel.Controls.Add(this.label7);
            this.AddRoomsPanel.Controls.Add(this.NameRoomTextBox);
            this.AddRoomsPanel.Controls.Add(this.label5);
            this.AddRoomsPanel.Controls.Add(this.label4);
            this.AddRoomsPanel.Controls.Add(this.label10);
            this.AddRoomsPanel.Controls.Add(this.label9);
            this.AddRoomsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddRoomsPanel.Location = new System.Drawing.Point(0, 173);
            this.AddRoomsPanel.Name = "AddRoomsPanel";
            this.AddRoomsPanel.Size = new System.Drawing.Size(903, 352);
            this.AddRoomsPanel.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(33, 266);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(368, 24);
            this.label12.TabIndex = 27;
            this.label12.Text = "Поля обязательные для заполнения";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(21, 257);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 20);
            this.label11.TabIndex = 26;
            this.label11.Text = "*";
            // 
            // AddMestaButton
            // 
            this.AddMestaButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AddMestaButton.Location = new System.Drawing.Point(0, 298);
            this.AddMestaButton.Name = "AddMestaButton";
            this.AddMestaButton.Size = new System.Drawing.Size(903, 54);
            this.AddMestaButton.TabIndex = 23;
            this.AddMestaButton.Text = "Добавить";
            this.AddMestaButton.UseVisualStyleBackColor = true;
            this.AddMestaButton.Click += new System.EventHandler(this.AddMestoButton_Click);
            // 
            // RoomPictureBox
            // 
            this.RoomPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RoomPictureBox.Location = new System.Drawing.Point(538, 75);
            this.RoomPictureBox.Name = "RoomPictureBox";
            this.RoomPictureBox.Size = new System.Drawing.Size(277, 179);
            this.RoomPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RoomPictureBox.TabIndex = 22;
            this.RoomPictureBox.TabStop = false;
            this.RoomPictureBox.Click += new System.EventHandler(this.RoomPictureBox_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(533, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "Фото";
            // 
            // PoezdsComboBox
            // 
            this.PoezdsComboBox.FormattingEnabled = true;
            this.PoezdsComboBox.Location = new System.Drawing.Point(229, 147);
            this.PoezdsComboBox.Name = "PoezdsComboBox";
            this.PoezdsComboBox.Size = new System.Drawing.Size(251, 21);
            this.PoezdsComboBox.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(224, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Поезда";
            // 
            // NameRoomTextBox
            // 
            this.NameRoomTextBox.Location = new System.Drawing.Point(229, 75);
            this.NameRoomTextBox.Name = "NameRoomTextBox";
            this.NameRoomTextBox.Size = new System.Drawing.Size(256, 20);
            this.NameRoomTextBox.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(224, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Название";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(22, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "Добавление номеров";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(208, 119);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 26);
            this.label10.TabIndex = 25;
            this.label10.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(208, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 26);
            this.label9.TabIndex = 24;
            this.label9.Text = "*";
            // 
            // InfoMestaPanel
            // 
            this.InfoMestaPanel.AutoScroll = true;
            this.InfoMestaPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.InfoMestaPanel.Controls.Add(this.label2);
            this.InfoMestaPanel.Controls.Add(this.label1);
            this.InfoMestaPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.InfoMestaPanel.Location = new System.Drawing.Point(0, 0);
            this.InfoMestaPanel.Name = "InfoMestaPanel";
            this.InfoMestaPanel.Size = new System.Drawing.Size(903, 173);
            this.InfoMestaPanel.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(475, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Поезда";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Название";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // AdminMestaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 525);
            this.Controls.Add(this.AddRoomsPanel);
            this.Controls.Add(this.InfoMestaPanel);
            this.Name = "AdminMestaForm";
            this.Text = "AdminMestaForm";
            this.Load += new System.EventHandler(this.AdminMestaForm_Load_1);
            this.AddRoomsPanel.ResumeLayout(false);
            this.AddRoomsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoomPictureBox)).EndInit();
            this.InfoMestaPanel.ResumeLayout(false);
            this.InfoMestaPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel AddRoomsPanel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button AddMestaButton;
        private System.Windows.Forms.PictureBox RoomPictureBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox PoezdsComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox NameRoomTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel InfoMestaPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}