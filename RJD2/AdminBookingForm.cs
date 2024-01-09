using System;
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
    public partial class AdminBookingForm : Form
    {
        public AdminBookingForm()
        {
            InitializeComponent();
        }

        private void AdminBookingForm_Load_1(object sender, EventArgs e)
        {
            List<string> bookinglist = SQLClass.MySelect(
                "SELECT booking.mesta_id, booking.user, booking.dateFrom, booking.dateTo, booking.CityWhere, booking.CityWhither, " +
                        "mesta.name, poezda.name" +
                " FROM booking" +
                  " JOIN mesta ON mesta.id = booking.mesta_id" +
                  " JOIN poezda ON poezda.id = mesta.id_poezd" +
                " ORDER BY booking.dateFrom");

            InfoBookingPanel.Controls.Clear();
            InfoBookingPanel.Controls.Add(label1);
            InfoBookingPanel.Controls.Add(label2);
            InfoBookingPanel.Controls.Add(label3);
            InfoBookingPanel.Controls.Add(label4);
            InfoBookingPanel.Controls.Add(label5);
            InfoBookingPanel.Controls.Add(label6);
            InfoBookingPanel.Controls.Add(label7);
            

            int y = 40;
            for (int i = 0; i < bookinglist.Count; i += 8)
            {
                #region Пользователь
                Label lbl = new Label();
                lbl.Location = new Point(10, y);
                lbl.Size = new Size(150, 25);
                lbl.Text = bookinglist[i + 1];
                InfoBookingPanel.Controls.Add(lbl);
                #endregion

                #region Дата заезда
                Label lbl1 = new Label();
                lbl1.Location = new Point(170, y);
                lbl1.Size = new Size(100, 25);
                lbl1.Text = bookinglist[i + 2];
                InfoBookingPanel.Controls.Add(lbl1);
                #endregion

                #region Дата выезда
                Label lbl2 = new Label();
                lbl2.Location = new Point(350, y);
                lbl2.Size = new Size(100, 25);
                lbl2.Text = bookinglist[i + 3];
                InfoBookingPanel.Controls.Add(lbl2);
                #endregion

                #region Откуда
                Label lbl3 = new Label();
                lbl3.Location = new Point(510, y);
                lbl3.Size = new Size(100, 25);
                lbl3.Text = bookinglist[i + 4];
                InfoBookingPanel.Controls.Add(lbl3);
                #endregion

                #region Куда
                Label lbl4 = new Label();
                lbl4.Location = new Point(650, y);
                lbl4.Size = new Size(130, 25);
                lbl4.Text = bookinglist[i + 5];
                InfoBookingPanel.Controls.Add(lbl4);
                #endregion

                #region Номер
                Label lbl5 = new Label();
                lbl5.Location = new Point(790, y);
                lbl5.Size = new Size(150, 25);
                lbl5.Text = bookinglist[i + 6];
                InfoBookingPanel.Controls.Add(lbl5);
                #endregion
               
                #region Поезд
                Label lbl6 = new Label();
                lbl6.Location = new Point(940, y);
                lbl5.Size = new Size(150, 25);
                lbl6.Text = bookinglist[i + 7];
                InfoBookingPanel.Controls.Add(lbl6);
                #endregion

                #region Удаление бронирования
                Button btn = new Button();
                btn.Location = new Point(1200, y);
                btn.Size = new Size(100, 30);
                btn.Font = new Font("Arial Narrow", 12);
                btn.Click += new EventHandler(DeleteBookingClick);
                btn.Text = "Удалить";
                InfoBookingPanel.Controls.Add(btn);
                #endregion
                y += 30;
            }
        }
        private void DeleteBookingClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int y = btn.Location.Y;

            foreach (Control control in InfoBookingPanel.Controls)
            {
                if (control.Location == new Point(10, y))
                {
                    SQLClass.MyUpDate(
                        "DELETE FROM booking" +
                        " WHERE user = '" + control.Text + "'" +
                        " AND mesta_id = '" + control.Tag + "'" +
                        " AND dateFrom = '" + Convert.ToDateTime(control.AccessibleName).ToString("yyyy-MM-dd") + "'" +
                        " AND dateTo = '" + Convert.ToDateTime(control.AccessibleDescription).ToString("yyyy-MM-dd") + "'");



                    MessageBox.Show("Удаление успешно");
                    AdminBookingForm_Load_1(sender, e);
                }
            }

        }

        private void InfoBookingPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
     
