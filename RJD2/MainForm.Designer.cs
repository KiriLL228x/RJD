namespace RJD2
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FiltrPanel = new System.Windows.Forms.Panel();
            this.CityComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textboxe = new System.Windows.Forms.TextBox();
            this.FiltrButton = new System.Windows.Forms.Button();
            this.InfoPanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PoezdPictureBox = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.FiltrPanel.SuspendLayout();
            this.InfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PoezdPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 50);
            this.panel1.TabIndex = 0;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(293, 14);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(143, 22);
            this.textBox4.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(61, 14);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(143, 22);
            this.textBox1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(643, 7);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // FiltrPanel
            // 
            this.FiltrPanel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.FiltrPanel.Controls.Add(this.CityComboBox);
            this.FiltrPanel.Controls.Add(this.label6);
            this.FiltrPanel.Controls.Add(this.label5);
            this.FiltrPanel.Controls.Add(this.button3);
            this.FiltrPanel.Controls.Add(this.label4);
            this.FiltrPanel.Controls.Add(this.label3);
            this.FiltrPanel.Controls.Add(this.dateTimePicker2);
            this.FiltrPanel.Controls.Add(this.dateTimePicker1);
            this.FiltrPanel.Controls.Add(this.textboxe);
            this.FiltrPanel.Controls.Add(this.FiltrButton);
            this.FiltrPanel.Controls.Add(this.InfoPanel);
            this.FiltrPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FiltrPanel.Location = new System.Drawing.Point(0, 50);
            this.FiltrPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FiltrPanel.Name = "FiltrPanel";
            this.FiltrPanel.Size = new System.Drawing.Size(800, 400);
            this.FiltrPanel.TabIndex = 1;
            // 
            // CityComboBox
            // 
            this.CityComboBox.FormattingEnabled = true;
            this.CityComboBox.Location = new System.Drawing.Point(199, 6);
            this.CityComboBox.Name = "CityComboBox";
            this.CityComboBox.Size = new System.Drawing.Size(129, 24);
            this.CityComboBox.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(139, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(347, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "label5";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(683, 6);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 46);
            this.button3.TabIndex = 6;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(347, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "label3";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(189, 39);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(152, 22);
            this.dateTimePicker2.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(396, 33);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(152, 22);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // textboxe
            // 
            this.textboxe.Location = new System.Drawing.Point(396, 5);
            this.textboxe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textboxe.Name = "textboxe";
            this.textboxe.Size = new System.Drawing.Size(143, 22);
            this.textboxe.TabIndex = 8;
            // 
            // FiltrButton
            // 
            this.FiltrButton.Location = new System.Drawing.Point(0, 0);
            this.FiltrButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FiltrButton.Name = "FiltrButton";
            this.FiltrButton.Size = new System.Drawing.Size(136, 34);
            this.FiltrButton.TabIndex = 5;
            this.FiltrButton.Text = "button2";
            this.FiltrButton.UseVisualStyleBackColor = true;
            // 
            // InfoPanel
            // 
            this.InfoPanel.BackColor = System.Drawing.SystemColors.Info;
            this.InfoPanel.Controls.Add(this.pictureBox2);
            this.InfoPanel.Controls.Add(this.PoezdPictureBox);
            this.InfoPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.InfoPanel.Location = new System.Drawing.Point(0, 66);
            this.InfoPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(800, 334);
            this.InfoPanel.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(293, 12);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(280, 219);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "2poezd";
            this.pictureBox2.Click += new System.EventHandler(this.Poezd_Click);
            // 
            // PoezdPictureBox
            // 
            this.PoezdPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("PoezdPictureBox.Image")));
            this.PoezdPictureBox.Location = new System.Drawing.Point(12, 12);
            this.PoezdPictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PoezdPictureBox.Name = "PoezdPictureBox";
            this.PoezdPictureBox.Size = new System.Drawing.Size(260, 219);
            this.PoezdPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PoezdPictureBox.TabIndex = 0;
            this.PoezdPictureBox.TabStop = false;
            this.PoezdPictureBox.Tag = "poezd";
            this.PoezdPictureBox.Click += new System.EventHandler(this.Poezd_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FiltrPanel);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.FiltrPanel.ResumeLayout(false);
            this.FiltrPanel.PerformLayout();
            this.InfoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PoezdPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel FiltrPanel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textboxe;
        private System.Windows.Forms.Button FiltrButton;
        private System.Windows.Forms.Panel InfoPanel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox PoezdPictureBox;
        private System.Windows.Forms.ComboBox CityComboBox;
    }
}

