﻿namespace RJD
{
    partial class MestaForm
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
            this.MestoPanel = new System.Windows.Forms.Panel();
            this.CityCBWhither = new System.Windows.Forms.ComboBox();
            this.CityCBWhere = new System.Windows.Forms.ComboBox();
            this.whither = new System.Windows.Forms.Label();
            this.where = new System.Windows.Forms.Label();
            this.CommentPanel = new System.Windows.Forms.Panel();
            this.CommentButton = new System.Windows.Forms.Button();
            this.CommentComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CommentTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BronButton = new System.Windows.Forms.Button();
            this.DTto = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.DTfrom = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.InfoPanel = new System.Windows.Forms.Panel();
            this.SaveParamButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.QuantityTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SaveRoomButton = new System.Windows.Forms.Button();
            this.RoomTextBox = new System.Windows.Forms.TextBox();
            this.RoomLabel = new System.Windows.Forms.Label();
            this.RoomPictureBox = new System.Windows.Forms.PictureBox();
            this.MestoPanel.SuspendLayout();
            this.CommentPanel.SuspendLayout();
            this.InfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoomPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MestoPanel
            // 
            this.MestoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MestoPanel.Controls.Add(this.CityCBWhither);
            this.MestoPanel.Controls.Add(this.CityCBWhere);
            this.MestoPanel.Controls.Add(this.whither);
            this.MestoPanel.Controls.Add(this.where);
            this.MestoPanel.Controls.Add(this.CommentPanel);
            this.MestoPanel.Controls.Add(this.BronButton);
            this.MestoPanel.Controls.Add(this.DTto);
            this.MestoPanel.Controls.Add(this.label2);
            this.MestoPanel.Controls.Add(this.DTfrom);
            this.MestoPanel.Controls.Add(this.label1);
            this.MestoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MestoPanel.Location = new System.Drawing.Point(0, 270);
            this.MestoPanel.Name = "MestoPanel";
            this.MestoPanel.Size = new System.Drawing.Size(1095, 334);
            this.MestoPanel.TabIndex = 3;
            // 
            // CityCBWhither
            // 
            this.CityCBWhither.FormattingEnabled = true;
            this.CityCBWhither.Location = new System.Drawing.Point(517, 46);
            this.CityCBWhither.Margin = new System.Windows.Forms.Padding(2);
            this.CityCBWhither.Name = "CityCBWhither";
            this.CityCBWhither.Size = new System.Drawing.Size(172, 21);
            this.CityCBWhither.TabIndex = 18;
            // 
            // CityCBWhere
            // 
            this.CityCBWhere.FormattingEnabled = true;
            this.CityCBWhere.Location = new System.Drawing.Point(517, 14);
            this.CityCBWhere.Margin = new System.Windows.Forms.Padding(2);
            this.CityCBWhere.Name = "CityCBWhere";
            this.CityCBWhere.Size = new System.Drawing.Size(172, 21);
            this.CityCBWhere.TabIndex = 17;
            // 
            // whither
            // 
            this.whither.AutoSize = true;
            this.whither.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.whither.Location = new System.Drawing.Point(436, 45);
            this.whither.Name = "whither";
            this.whither.Size = new System.Drawing.Size(46, 20);
            this.whither.TabIndex = 7;
            this.whither.Text = "Куда";
            // 
            // where
            // 
            this.where.AutoSize = true;
            this.where.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.where.Location = new System.Drawing.Point(436, 14);
            this.where.Name = "where";
            this.where.Size = new System.Drawing.Size(65, 20);
            this.where.TabIndex = 6;
            this.where.Text = "Откуда";
            // 
            // CommentPanel
            // 
            this.CommentPanel.Controls.Add(this.CommentButton);
            this.CommentPanel.Controls.Add(this.CommentComboBox);
            this.CommentPanel.Controls.Add(this.label5);
            this.CommentPanel.Controls.Add(this.CommentTextBox);
            this.CommentPanel.Controls.Add(this.label4);
            this.CommentPanel.Location = new System.Drawing.Point(353, 144);
            this.CommentPanel.Name = "CommentPanel";
            this.CommentPanel.Size = new System.Drawing.Size(736, 187);
            this.CommentPanel.TabIndex = 5;
            // 
            // CommentButton
            // 
            this.CommentButton.Location = new System.Drawing.Point(577, 115);
            this.CommentButton.Name = "CommentButton";
            this.CommentButton.Size = new System.Drawing.Size(142, 58);
            this.CommentButton.TabIndex = 4;
            this.CommentButton.Text = "Отправить";
            this.CommentButton.UseVisualStyleBackColor = true;
            // 
            // CommentComboBox
            // 
            this.CommentComboBox.FormattingEnabled = true;
            this.CommentComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.CommentComboBox.Location = new System.Drawing.Point(577, 41);
            this.CommentComboBox.Name = "CommentComboBox";
            this.CommentComboBox.Size = new System.Drawing.Size(142, 21);
            this.CommentComboBox.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(572, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ваша оценка:";
            // 
            // CommentTextBox
            // 
            this.CommentTextBox.Location = new System.Drawing.Point(15, 41);
            this.CommentTextBox.Multiline = true;
            this.CommentTextBox.Name = "CommentTextBox";
            this.CommentTextBox.Size = new System.Drawing.Size(538, 133);
            this.CommentTextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Оставьте отзыв";
            // 
            // BronButton
            // 
            this.BronButton.Location = new System.Drawing.Point(69, 85);
            this.BronButton.Name = "BronButton";
            this.BronButton.Size = new System.Drawing.Size(212, 66);
            this.BronButton.TabIndex = 4;
            this.BronButton.Text = "Забронировать";
            this.BronButton.UseVisualStyleBackColor = true;
            this.BronButton.Click += new System.EventHandler(this.BronButton_Click);
            // 
            // DTto
            // 
            this.DTto.Location = new System.Drawing.Point(130, 44);
            this.DTto.Name = "DTto";
            this.DTto.Size = new System.Drawing.Size(291, 20);
            this.DTto.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Дата выезда";
            // 
            // DTfrom
            // 
            this.DTfrom.Location = new System.Drawing.Point(130, 13);
            this.DTfrom.Name = "DTfrom";
            this.DTfrom.Size = new System.Drawing.Size(291, 20);
            this.DTfrom.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дата заезда";
            // 
            // InfoPanel
            // 
            this.InfoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.InfoPanel.Controls.Add(this.SaveParamButton);
            this.InfoPanel.Controls.Add(this.label8);
            this.InfoPanel.Controls.Add(this.QuantityTextBox);
            this.InfoPanel.Controls.Add(this.label9);
            this.InfoPanel.Controls.Add(this.label7);
            this.InfoPanel.Controls.Add(this.PriceTextBox);
            this.InfoPanel.Controls.Add(this.label6);
            this.InfoPanel.Controls.Add(this.SaveRoomButton);
            this.InfoPanel.Controls.Add(this.RoomTextBox);
            this.InfoPanel.Controls.Add(this.RoomLabel);
            this.InfoPanel.Controls.Add(this.RoomPictureBox);
            this.InfoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.InfoPanel.Location = new System.Drawing.Point(0, 0);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(1095, 270);
            this.InfoPanel.TabIndex = 2;
            // 
            // SaveParamButton
            // 
            this.SaveParamButton.Location = new System.Drawing.Point(904, 226);
            this.SaveParamButton.Name = "SaveParamButton";
            this.SaveParamButton.Size = new System.Drawing.Size(121, 35);
            this.SaveParamButton.TabIndex = 13;
            this.SaveParamButton.Text = "Сохранить";
            this.SaveParamButton.UseVisualStyleBackColor = true;
            this.SaveParamButton.Click += new System.EventHandler(this.SaveParamButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(958, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "шт.";
            // 
            // QuantityTextBox
            // 
            this.QuantityTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QuantityTextBox.Location = new System.Drawing.Point(837, 189);
            this.QuantityTextBox.Name = "QuantityTextBox";
            this.QuantityTextBox.Size = new System.Drawing.Size(116, 13);
            this.QuantityTextBox.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(701, 192);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Количество:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(577, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "руб.";
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PriceTextBox.Location = new System.Drawing.Point(455, 189);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(116, 13);
            this.PriceTextBox.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(385, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Цена:";
            // 
            // SaveRoomButton
            // 
            this.SaveRoomButton.Location = new System.Drawing.Point(904, 34);
            this.SaveRoomButton.Name = "SaveRoomButton";
            this.SaveRoomButton.Size = new System.Drawing.Size(121, 35);
            this.SaveRoomButton.TabIndex = 5;
            this.SaveRoomButton.Text = "Сохранить";
            this.SaveRoomButton.UseVisualStyleBackColor = true;
            this.SaveRoomButton.Click += new System.EventHandler(this.SaveRoomButton_Click);
            // 
            // RoomTextBox
            // 
            this.RoomTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.RoomTextBox.Enabled = false;
            this.RoomTextBox.Location = new System.Drawing.Point(385, 75);
            this.RoomTextBox.Multiline = true;
            this.RoomTextBox.Name = "RoomTextBox";
            this.RoomTextBox.ReadOnly = true;
            this.RoomTextBox.Size = new System.Drawing.Size(640, 102);
            this.RoomTextBox.TabIndex = 2;
            // 
            // RoomLabel
            // 
            this.RoomLabel.AutoSize = true;
            this.RoomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RoomLabel.Location = new System.Drawing.Point(384, 19);
            this.RoomLabel.Name = "RoomLabel";
            this.RoomLabel.Size = new System.Drawing.Size(79, 29);
            this.RoomLabel.TabIndex = 1;
            this.RoomLabel.Text = "label1";
            // 
            // RoomPictureBox
            // 
            this.RoomPictureBox.Location = new System.Drawing.Point(27, 22);
            this.RoomPictureBox.Name = "RoomPictureBox";
            this.RoomPictureBox.Size = new System.Drawing.Size(327, 229);
            this.RoomPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RoomPictureBox.TabIndex = 0;
            this.RoomPictureBox.TabStop = false;
            // 
            // MestaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 604);
            this.Controls.Add(this.MestoPanel);
            this.Controls.Add(this.InfoPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MestaForm";
            this.Text = "RoomForm";
            this.MestoPanel.ResumeLayout(false);
            this.MestoPanel.PerformLayout();
            this.CommentPanel.ResumeLayout(false);
            this.CommentPanel.PerformLayout();
            this.InfoPanel.ResumeLayout(false);
            this.InfoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoomPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MestoPanel;
        private System.Windows.Forms.Panel CommentPanel;
        private System.Windows.Forms.Button CommentButton;
        private System.Windows.Forms.ComboBox CommentComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CommentTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BronButton;
        private System.Windows.Forms.DateTimePicker DTto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DTfrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel InfoPanel;
        private System.Windows.Forms.Button SaveParamButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox QuantityTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button SaveRoomButton;
        private System.Windows.Forms.TextBox RoomTextBox;
        private System.Windows.Forms.Label RoomLabel;
        private System.Windows.Forms.PictureBox RoomPictureBox;
        private System.Windows.Forms.Label whither;
        private System.Windows.Forms.Label where;
        private System.Windows.Forms.ComboBox CityCBWhither;
        private System.Windows.Forms.ComboBox CityCBWhere;
    }
}