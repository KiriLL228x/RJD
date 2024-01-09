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
            this.button3 = new System.Windows.Forms.Button();
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
            this.AuthPanel.BackColor = System.Drawing.Color.LightCoral;
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
            this.AuthPanel.Size = new System.Drawing.Size(1370, 85);
            this.AuthPanel.TabIndex = 0;
            // 
            // RegButton
            // 
            this.RegButton.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegButton.Location = new System.Drawing.Point(735, 28);
            this.RegButton.Margin = new System.Windows.Forms.Padding(2);
            this.RegButton.Name = "RegButton";
            this.RegButton.Size = new System.Drawing.Size(177, 28);
            this.RegButton.TabIndex = 11;
            this.RegButton.Text = "Регистрация";
            this.RegButton.UseVisualStyleBackColor = true;
            this.RegButton.Click += new System.EventHandler(this.RegButton_Click);
            // 
            // AdminFormButton
            // 
            this.AdminFormButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AdminFormButton.Location = new System.Drawing.Point(1121, 10);
            this.AdminFormButton.Name = "AdminFormButton";
            this.AdminFormButton.Size = new System.Drawing.Size(54, 64);
            this.AdminFormButton.TabIndex = 10;
            this.AdminFormButton.Text = "🐛";
            this.AdminFormButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AdminFormButton.UseVisualStyleBackColor = true;
            this.AdminFormButton.Click += new System.EventHandler(this.AdminButton_Click);
            // 
            // HelloLabel
            // 
            this.HelloLabel.AutoSize = true;
            this.HelloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HelloLabel.Location = new System.Drawing.Point(506, 27);
            this.HelloLabel.Name = "HelloLabel";
            this.HelloLabel.Size = new System.Drawing.Size(79, 29);
            this.HelloLabel.TabIndex = 9;
            this.HelloLabel.Text = "label7";
            this.HelloLabel.Visible = false;
            // 
            // PassTextBox
            // 
            this.PassTextBox.Location = new System.Drawing.Point(310, 34);
            this.PassTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.PassTextBox.Name = "PassTextBox";
            this.PassTextBox.Size = new System.Drawing.Size(108, 20);
            this.PassTextBox.TabIndex = 8;
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Location = new System.Drawing.Point(79, 35);
            this.LoginTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(108, 20);
            this.LoginTextBox.TabIndex = 7;
            // 
            // AuthButton
            // 
            this.AuthButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthButton.Location = new System.Drawing.Point(1199, 23);
            this.AuthButton.Margin = new System.Windows.Forms.Padding(2);
            this.AuthButton.Name = "AuthButton";
            this.AuthButton.Size = new System.Drawing.Size(169, 39);
            this.AuthButton.TabIndex = 4;
            this.AuthButton.Text = "Войти";
            this.AuthButton.UseVisualStyleBackColor = true;
            this.AuthButton.Click += new System.EventHandler(this.AuthButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(211, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Пароль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(11, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логин";
            // 
            // FiltrPanel
            // 
            this.FiltrPanel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.FiltrPanel.Controls.Add(this.button3);
            this.FiltrPanel.Controls.Add(this.FiltrButton);
            this.FiltrPanel.Controls.Add(this.InfoPanel);
            this.FiltrPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FiltrPanel.Location = new System.Drawing.Point(0, 85);
            this.FiltrPanel.Margin = new System.Windows.Forms.Padding(2);
            this.FiltrPanel.Name = "FiltrPanel";
            this.FiltrPanel.Size = new System.Drawing.Size(1370, 496);
            this.FiltrPanel.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1279, 4);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 37);
            this.button3.TabIndex = 6;
            this.button3.Text = "Найти";
            this.button3.UseVisualStyleBackColor = true;
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
            this.InfoPanel.AutoScroll = true;
            this.InfoPanel.BackColor = System.Drawing.SystemColors.Window;
            this.InfoPanel.Controls.Add(this.pictureBox2);
            this.InfoPanel.Controls.Add(this.PoezdPictureBox);
            this.InfoPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.InfoPanel.Location = new System.Drawing.Point(0, 46);
            this.InfoPanel.Margin = new System.Windows.Forms.Padding(2);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(1370, 450);
            this.InfoPanel.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(278, 35);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(230, 180);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "2poezd";
            this.pictureBox2.Click += new System.EventHandler(this.Poezd_Click);
            // 
            // PoezdPictureBox
            // 
            this.PoezdPictureBox.Location = new System.Drawing.Point(11, 35);
            this.PoezdPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.PoezdPictureBox.Name = "PoezdPictureBox";
            this.PoezdPictureBox.Size = new System.Drawing.Size(230, 180);
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
            this.ClientSize = new System.Drawing.Size(1370, 581);
            this.Controls.Add(this.FiltrPanel);
            this.Controls.Add(this.AuthPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.AuthPanel.ResumeLayout(false);
            this.AuthPanel.PerformLayout();
            this.FiltrPanel.ResumeLayout(false);
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
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button FiltrButton;
        private System.Windows.Forms.Panel InfoPanel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox PoezdPictureBox;
        private System.Windows.Forms.Label HelloLabel;
        private System.Windows.Forms.Button AdminFormButton;
        private System.Windows.Forms.Button RegButton;
    }
}

