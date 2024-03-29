﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using RJD;
using RJD2;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace RJD2
{
    public partial class MainForm : Form
    {
        public static string Login = "";
        public static string NameFamily = "";
        public static int isAdmin;



        public MainForm()
        {
            InitializeComponent();
            FindButton_Click(null, null);
            AdminFormButton.Visible = false;

        }

        private void FiltrButton_Click(object sender, EventArgs e)
        {
            if (FiltrPanel.Height < 140)
            {
                FiltrPanel.Height = 140;
            }
            else
            {
                FiltrPanel.Height = FiltrButton.Size.Height;
            }
        }

        private void Poezd_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            PoezdForm pf = new PoezdForm(pb.Tag.ToString());
            pf.ShowDialog();
        }

        private void labelPoezd_Click(object sender, EventArgs e)
        {
            Label lb = (Label)sender;
            PoezdForm pf = new PoezdForm(lb.Tag.ToString());
            pf.ShowDialog();
        }
        private void FindButton_Click(object sender, EventArgs e)
        {
            List<string> cityes = SQLClass.MySelect("SELECT DISTINCT name FROM cityes ORDER BY name");

            

            string command = "SELECT id, name, adress_pic FROM poezda WHERE 1";

           

           
            List<string> poezda = SQLClass.MySelect(command);

            InfoPanel.Controls.Clear();
            int x = 20;
            for (int i = 0; i < poezda.Count; i += 3)
            {
                Label lbl = new Label();
                lbl.Location = new Point(x, 20);
                lbl.Size = new Size(265, 30);
                lbl.Font = new Font("Arial Narrow", 13);
                lbl.Text = poezda[i + 1];
                lbl.Tag = poezda[i];
                lbl.Click += new EventHandler(labelPoezd_Click);
                InfoPanel.Controls.Add(lbl);

                PictureBox pb = new PictureBox();
                try
                {
                    pb.Load("../../Pictures/" + poezda[i + 2]);
                }
                catch (Exception) { }
                pb.Location = new Point(x, 60);
                pb.Size = new Size(270, 184);
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                pb.Tag = poezda[i];
                pb.Click += new EventHandler(Poezd_Click);
                InfoPanel.Controls.Add(pb);

                x += 320;
            }

        }

        private void AuthButton_Click(object sender, EventArgs e)
        {
            List<string> user_date = SQLClass.MySelect("SELECT login, name, family, admin FROM users WHERE login = '" + LoginTextBox.Text + "' AND pass = '" + PassTextBox.Text + "'");

            if (AuthButton.Text == "Выйти")
            {
                Login = "";
                AuthPanel.Controls.Clear();
                AuthPanel.Controls.Add(label1);
                LoginTextBox.Text = "";
                AuthPanel.Controls.Add(LoginTextBox);
                AuthPanel.Controls.Add(label2);
                PassTextBox.Text = "";
                AuthPanel.Controls.Add(PassTextBox);
                AuthButton.Text = "Войти";
                AuthPanel.Controls.Add(AuthButton);
                AuthPanel.Controls.Add(RegButton);
                HelloLabel.Visible = false;
                HelloLabel.Text = "";
                isAdmin = 0;

            }
            else
            {
                if (user_date.Count > 0)
                {
                    isAdmin = Convert.ToInt32(user_date[3]);
                    Login = user_date[0];
                    NameFamily = user_date[1] + " " + user_date[2];
                    AuthPanel.Controls.Clear();
                    AuthButton.Text = "Выйти";
                    AuthPanel.Controls.Add(AuthButton);
                    AuthPanel.Controls.Add(HelloLabel);
                    HelloLabel.Visible = true;
                    HelloLabel.Text = "Приветствуем Вас, " + NameFamily;
                    AdminFormButton.Visible = Convert.ToBoolean(isAdmin);
                    AuthPanel.Controls.Add(AdminFormButton);
                }
                else
                {
                    var result = MessageBox.Show("Вы указали неверный логин/пароль", "Зарегистрироваться", MessageBoxButtons.YesNo);
                    LoginTextBox.Text = "";
                    PassTextBox.Text = "";
                    if (result == DialogResult.Yes)
                    {
                        RegForm reg = new RegForm();
                        reg.ShowDialog();
                    }
                }

            }
        }

        private void AdminButton_Click(object sender, EventArgs e)
        {
            AdminForm af = new AdminForm();
            af.ShowDialog();
        }
        private void RegButton_Click(object sender, EventArgs e)
        {
            RegForm reg = new RegForm();
            reg.ShowDialog();
        }
    }
}

