using RJD2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RJD
{
    public partial class MestaForm : Form
    {
        string id_mesta;
        int kol = 0;
        public MestaForm(string idMesta)
        {
            InitializeComponent();

            RoomTextBox.ReadOnly = !Convert.ToBoolean(MainForm.isAdmin);
            RoomTextBox.Enabled = Convert.ToBoolean(MainForm.isAdmin);

            PriceTextBox.ReadOnly = !Convert.ToBoolean(MainForm.isAdmin);
            PriceTextBox.Enabled = Convert.ToBoolean(MainForm.isAdmin);

            QuantityTextBox.ReadOnly = !Convert.ToBoolean(MainForm.isAdmin);
            QuantityTextBox.Enabled = Convert.ToBoolean(MainForm.isAdmin);

            SaveRoomButton.Visible = Convert.ToBoolean(MainForm.isAdmin);
            SaveParamButton.Visible = Convert.ToBoolean(MainForm.isAdmin);

           

            id_mesta = idMesta;

            List<string> mesta = SQLClass.MySelect("SELECT name, adress_pic, opis, id_poezd, price, kol FROM mesta WHERE id = " + idMesta);
            List<string> poezd = SQLClass.MySelect("SELECT name FROM poezda WHERE id = " + mesta[3]);

            Text = poezd[0] + ": " + mesta[0];
            RoomLabel.Text = poezd[0] + ": " + mesta[0];

            RoomPictureBox.Load("../../Pictures/" + mesta[1]);
            RoomTextBox.Text = mesta[2];
            PriceTextBox.Text = mesta[4];
            QuantityTextBox.Text = mesta[5];
            kol = Convert.ToInt32(mesta[5]);

            List<string> cityes = SQLClass.MySelect("SELECT DISTINCT name FROM cityes ORDER BY name");

            CityCBWhere.Items.Clear();
            CityCBWhere.Items.Add("");
            CityCBWhither.Items.Clear();
            CityCBWhither.Items.Add("");
            foreach (string city in cityes)
            {
                CityCBWhere.Items.Add(city);
                CityCBWhither.Items.Add(city);
            }

            if (MainForm.Login != "")
            {
                CommentPanel.Visible = true;
            }
            else
            {
                CommentPanel.Visible = false;
            }
        }


        private void SaveRoomButton_Click(object sender, EventArgs e)
        {
            SQLClass.MyUpDate("UPDATE mesta SET opis = '" + RoomTextBox.Text + "' WHERE id = '" + id_mesta + "'");
            MessageBox.Show("Сохранено");
        }

        private void SaveParamButton_Click(object sender, EventArgs e)
        {
            SQLClass.MyUpDate("UPDATE mesta SET price = '" + PriceTextBox.Text + "', kol = '" + QuantityTextBox.Text + "', opis = '" + "' WHERE id = '" + id_mesta + "'");
            MessageBox.Show("Сохранено");
        }

        private void PriceTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox tb = (TextBox)sender;

            if (e.KeyCode == Keys.Enter)
            {
                SQLClass.MyUpDate("UPDATE mesta SET price = '" + PriceTextBox.Text + "' WHERE id = '" + id_mesta + "'");
                MessageBox.Show("Сохранено");
            }

        }
        private void BronButton_Click(object sender, EventArgs e)
        {
            #region Проверки корректрости
            if (MainForm.Login == "")
            {
                MessageBox.Show("Вы не авторизованы");
                return;
            }

            DateTime dt = DTfrom.Value;
            while (dt <= DTto.Value.AddDays(0.5))
            {
                List<string> exitBooking = SQLClass.MySelect("SELECT COUNT(*) FROM booking WHERE dateFrom <= '" + dt.ToString("yyyy-MM-dd") + "' AND dateTo >= '" + dt.ToString("yyyy-MM-dd") + "'");
                if (Convert.ToInt32(exitBooking[0]) >= kol)
                {
                    MessageBox.Show("Мест нет. Выберите другие даты.");
                    return;
                }
                dt = dt.AddDays(1);
            }
            #endregion

            if (CityCBWhere.Text == "" || CityCBWhither.Text == "")
            {
                MessageBox.Show("Заполните города!");
                return;
            }



            SQLClass.MyUpDate("INSERT INTO booking(user, dateFrom, dateTo, CityWhere, CityWhither, mesta_id) VALUES ('" + MainForm.Login + "', '" + DTfrom.Value.ToString("yyyy-MM-dd") + "', '" + DTto.Value.ToString("yyyy-MM-dd") + "', '" + CityCBWhere.Text + "', '" + CityCBWhither.Text + "', '" + id_mesta + "')");
            MessageBox.Show("Успешно");
        }
    }
}
