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
            this.AuthPanel = new System.Windows.Forms.Panel();
            this.RegButton = new System.Windows.Forms.Button();
            this.AdminFormButton = new System.Windows.Forms.Button();
            this.HelloLabel = new System.Windows.Forms.Label();
            this.PassTextBox = new System.Windows.Forms.TextBox();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.AuthButton = new System.Windows.Forms.Button();
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
            this.AuthPanel.SuspendLayout();
            this.FiltrPanel.SuspendLayout();
            this.InfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PoezdPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // AuthPanel
            // 
            this.AuthPanel.BackColor = System.Drawing.Color.Red;
            this.AuthPanel.Controls.Add(this.RegButton);
            this.AuthPanel.Controls.Add(this.AdminFormButton);
            this.AuthPanel.Controls.Add(this.HelloLabel);
            this.AuthPanel.Controls.Add(this.PassTextBox);
            this.AuthPanel.Controls.Add(this.LoginTextBox);
            this.AuthPanel.Controls.Add(this.AuthButton);
            this.AuthPanel.Controls.Add(this.label2);
            this.AuthPanel.Controls.Add(this.label1);
            this.AuthPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AuthPanel.Location = new System.Drawing.Point(0, 0);
            this.AuthPanel.Margin = new System.Windows.Forms.Padding(2);
            this.AuthPanel.Name = "AuthPanel";
            this.AuthPanel.Size = new System.Drawing.Size(854, 41);
            this.AuthPanel.TabIndex = 0;
            // 
            // RegButton
            // 
            this.RegButton.Location = new System.Drawing.Point(403, 6);
            this.RegButton.Margin = new System.Windows.Forms.Padding(2);
            this.RegButton.Name = "RegButton";
            this.RegButton.Size = new System.Drawing.Size(142, 27);
            this.RegButton.TabIndex = 11;
            this.RegButton.Text = "Регистрация";
            this.RegButton.UseVisualStyleBackColor = true;
            this.RegButton.Click += new System.EventHandler(this.RegButton_Click);
            // 
            // AdminFormButton
            // 
            this.AdminFormButton.Location = new System.Drawing.Point(587, 6);
            this.AdminFormButton.Name = "AdminFormButton";
            this.AdminFormButton.Size = new System.Drawing.Size(135, 27);
            this.AdminFormButton.TabIndex = 10;
            this.AdminFormButton.Text = "AdminButton";
            this.AdminFormButton.UseVisualStyleBackColor = true;
            this.AdminFormButton.Click += new System.EventHandler(this.AdminButton_Click);
            // 
            // HelloLabel
            // 
            this.HelloLabel.AutoSize = true;
            this.HelloLabel.Location = new System.Drawing.Point(333, 18);
            this.HelloLabel.Name = "HelloLabel";
            this.HelloLabel.Size = new System.Drawing.Size(35, 13);
            this.HelloLabel.TabIndex = 9;
            this.HelloLabel.Text = "label7";
            this.HelloLabel.Visible = false;
            // 
            // PassTextBox
            // 
            this.PassTextBox.Location = new System.Drawing.Point(220, 11);
            this.PassTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.PassTextBox.Name = "PassTextBox";
            this.PassTextBox.Size = new System.Drawing.Size(108, 20);
            this.PassTextBox.TabIndex = 8;
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Location = new System.Drawing.Point(46, 11);
            this.LoginTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(108, 20);
            this.LoginTextBox.TabIndex = 7;
            // 
            // AuthButton
            // 
            this.AuthButton.Location = new System.Drawing.Point(727, 6);
            this.AuthButton.Margin = new System.Windows.Forms.Padding(2);
            this.AuthButton.Name = "AuthButton";
            this.AuthButton.Size = new System.Drawing.Size(116, 28);
            this.AuthButton.TabIndex = 4;
            this.AuthButton.Text = "Войти";
            this.AuthButton.UseVisualStyleBackColor = true;
            this.AuthButton.Click += new System.EventHandler(this.AuthButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 13);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
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
            this.FiltrPanel.Location = new System.Drawing.Point(0, 41);
            this.FiltrPanel.Margin = new System.Windows.Forms.Padding(2);
            this.FiltrPanel.Name = "FiltrPanel";
            this.FiltrPanel.Size = new System.Drawing.Size(854, 325);
            this.FiltrPanel.TabIndex = 1;
            // 
            // CityComboBox
            // 
            this.CityComboBox.FormattingEnabled = true;
            this.CityComboBox.Location = new System.Drawing.Point(149, 5);
            this.CityComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.CityComboBox.Name = "CityComboBox";
            this.CityComboBox.Size = new System.Drawing.Size(98, 21);
            this.CityComboBox.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(104, 34);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(260, 32);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "label5";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(763, 10);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 37);
            this.button3.TabIndex = 6;
            this.button3.Text = "Найти";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(260, 6);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 6);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "label3";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(142, 32);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(115, 20);
            this.dateTimePicker2.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(297, 27);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(115, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // textboxe
            // 
            this.textboxe.Location = new System.Drawing.Point(297, 4);
            this.textboxe.Margin = new System.Windows.Forms.Padding(2);
            this.textboxe.Name = "textboxe";
            this.textboxe.Size = new System.Drawing.Size(108, 20);
            this.textboxe.TabIndex = 8;
            // 
            // FiltrButton
            // 
            this.FiltrButton.Location = new System.Drawing.Point(0, 0);
            this.FiltrButton.Margin = new System.Windows.Forms.Padding(2);
            this.FiltrButton.Name = "FiltrButton";
            this.FiltrButton.Size = new System.Drawing.Size(102, 28);
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
            this.InfoPanel.Location = new System.Drawing.Point(0, 54);
            this.InfoPanel.Margin = new System.Windows.Forms.Padding(2);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(854, 271);
            this.InfoPanel.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(220, 10);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(210, 178);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "2poezd";
            this.pictureBox2.Click += new System.EventHandler(this.Poezd_Click);
            // 
            // PoezdPictureBox
            // 
            this.PoezdPictureBox.Location = new System.Drawing.Point(9, 10);
            this.PoezdPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.PoezdPictureBox.Name = "PoezdPictureBox";
            this.PoezdPictureBox.Size = new System.Drawing.Size(195, 178);
            this.PoezdPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PoezdPictureBox.TabIndex = 0;
            this.PoezdPictureBox.TabStop = false;
            this.PoezdPictureBox.Tag = "poezd";
            this.PoezdPictureBox.Click += new System.EventHandler(this.Poezd_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 366);
            this.Controls.Add(this.FiltrPanel);
            this.Controls.Add(this.AuthPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.AuthPanel.ResumeLayout(false);
            this.AuthPanel.PerformLayout();
            this.FiltrPanel.ResumeLayout(false);
            this.FiltrPanel.PerformLayout();
            this.InfoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PoezdPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel AuthPanel;
        private System.Windows.Forms.TextBox PassTextBox;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.Button AuthButton;
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
        private System.Windows.Forms.Label HelloLabel;
        private System.Windows.Forms.Button AdminFormButton;
        private System.Windows.Forms.Button RegButton;
    }
}

