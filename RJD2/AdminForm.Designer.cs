namespace RJD2
{
    partial class AdminForm
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
            this.AdminCityesButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AdminBookingButton = new System.Windows.Forms.Button();
            this.AdminMestaForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AdminCityesButton
            // 
            this.AdminCityesButton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.AdminCityesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AdminCityesButton.Location = new System.Drawing.Point(12, 12);
            this.AdminCityesButton.Name = "AdminCityesButton";
            this.AdminCityesButton.Size = new System.Drawing.Size(166, 67);
            this.AdminCityesButton.TabIndex = 0;
            this.AdminCityesButton.Text = "Города";
            this.AdminCityesButton.UseVisualStyleBackColor = false;
            this.AdminCityesButton.Click += new System.EventHandler(this.AdminCityButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Snow;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 67);
            this.button1.TabIndex = 1;
            this.button1.Text = "Поезда";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.AdminPoezdaButton_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(472, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 67);
            this.button2.TabIndex = 2;
            this.button2.Text = "Пользователи";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.AdminUsersButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlText;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(184, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Форма администрирования БД";
            // 
            // AdminBookingButton
            // 
            this.AdminBookingButton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.AdminBookingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AdminBookingButton.Location = new System.Drawing.Point(185, 85);
            this.AdminBookingButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AdminBookingButton.Name = "AdminBookingButton";
            this.AdminBookingButton.Size = new System.Drawing.Size(276, 67);
            this.AdminBookingButton.TabIndex = 6;
            this.AdminBookingButton.Text = "Бронирования";
            this.AdminBookingButton.UseVisualStyleBackColor = false;
            this.AdminBookingButton.Click += new System.EventHandler(this.AdminBookingButton_Click);
            // 
            // AdminMestaForm
            // 
            this.AdminMestaForm.BackColor = System.Drawing.SystemColors.HighlightText;
            this.AdminMestaForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AdminMestaForm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AdminMestaForm.Location = new System.Drawing.Point(471, 85);
            this.AdminMestaForm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AdminMestaForm.Name = "AdminMestaForm";
            this.AdminMestaForm.Size = new System.Drawing.Size(166, 67);
            this.AdminMestaForm.TabIndex = 7;
            this.AdminMestaForm.Text = "Номера";
            this.AdminMestaForm.UseVisualStyleBackColor = false;
            this.AdminMestaForm.Click += new System.EventHandler(this.AdminMestaButton_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(650, 174);
            this.Controls.Add(this.AdminMestaForm);
            this.Controls.Add(this.AdminBookingButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AdminCityesButton);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AdminCityesButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AdminBookingButton;
        private System.Windows.Forms.Button AdminMestaForm;
    }
}