﻿namespace RJD2
{
    partial class AdminCityForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.InfoCityPanel = new System.Windows.Forms.Panel();
            this.AddCityButton = new System.Windows.Forms.Button();
            this.AddCityPanel = new System.Windows.Forms.Panel();
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.InfoCityPanel.SuspendLayout();
            this.AddCityPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(33, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Добавление городов в БД";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Список городов в БД";
            // 
            // InfoCityPanel
            // 
            this.InfoCityPanel.AutoScroll = true;
            this.InfoCityPanel.BackColor = System.Drawing.Color.LightCoral;
            this.InfoCityPanel.Controls.Add(this.label1);
            this.InfoCityPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.InfoCityPanel.Location = new System.Drawing.Point(0, 0);
            this.InfoCityPanel.Name = "InfoCityPanel";
            this.InfoCityPanel.Size = new System.Drawing.Size(478, 450);
            this.InfoCityPanel.TabIndex = 3;
            // 
            // AddCityButton
            // 
            this.AddCityButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AddCityButton.Location = new System.Drawing.Point(0, 399);
            this.AddCityButton.Name = "AddCityButton";
            this.AddCityButton.Size = new System.Drawing.Size(553, 51);
            this.AddCityButton.TabIndex = 2;
            this.AddCityButton.Text = "Добавить";
            this.AddCityButton.UseVisualStyleBackColor = true;
            this.AddCityButton.Click += new System.EventHandler(this.AddCityButton_Click);
            // 
            // AddCityPanel
            // 
            this.AddCityPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.AddCityPanel.Controls.Add(this.AddCityButton);
            this.AddCityPanel.Controls.Add(this.label2);
            this.AddCityPanel.Controls.Add(this.CityTextBox);
            this.AddCityPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.AddCityPanel.Location = new System.Drawing.Point(484, 0);
            this.AddCityPanel.Name = "AddCityPanel";
            this.AddCityPanel.Size = new System.Drawing.Size(553, 450);
            this.AddCityPanel.TabIndex = 4;
            // 
            // CityTextBox
            // 
            this.CityTextBox.Location = new System.Drawing.Point(38, 74);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(461, 20);
            this.CityTextBox.TabIndex = 0;
            // 
            // AdminCityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 450);
            this.Controls.Add(this.InfoCityPanel);
            this.Controls.Add(this.AddCityPanel);
            this.Name = "AdminCityForm";
            this.Text = "AdminCityForm";
            this.Load += new System.EventHandler(this.AdminCityForm_Load);
            this.InfoCityPanel.ResumeLayout(false);
            this.InfoCityPanel.PerformLayout();
            this.AddCityPanel.ResumeLayout(false);
            this.AddCityPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel InfoCityPanel;
        private System.Windows.Forms.Button AddCityButton;
        private System.Windows.Forms.Panel AddCityPanel;
        private System.Windows.Forms.TextBox CityTextBox;
    }
}