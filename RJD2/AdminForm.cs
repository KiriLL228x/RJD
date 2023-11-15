﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RJD2
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminCityButton_Click(object sender, EventArgs e)
        {
            AdminCityForm acf = new AdminCityForm();
            acf.ShowDialog();
        }

        private void AdminPoezdaButton_Click(object sender, EventArgs e)
        {
            AdminPoezdaForm ahf = new AdminPoezdaForm();
            ahf.ShowDialog();
        }

        private void AdminMestaButton_Click(object sender, EventArgs e)
        {
            AdminMestaForm arf = new AdminMestaForm();
            arf.ShowDialog();
        }

        private void AdminUsersButton_Click(object sender, EventArgs e)
        {
            AdminUsersForm auf = new AdminUsersForm();
            auf.ShowDialog();
        }
    }
}
