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
    public partial class PoezdForm : Form
    {
        string _idPoezd = "";

        public PoezdForm(string idPoezd)
        {
            _idPoezd = idPoezd;

            InitializeComponent();

            List<string> poezd = MainForm.MySelect("SELECT * FROM poezda WHERE id = " + _idPoezd);
            List<string> mesta = MainForm.MySelect("SELECT id, name, adress_pic FROM mesta WHERE id_poezd = " + _idPoezd);

            #region Выбранная гостиница на панеле HotelPanel 
            Text = poezd[1];
            PoezdLabel.Text = poezd[1];
            
            PoezdPB.Load("../../Pictures/" + poezd[4]);
            PoezdTextBox.Text = poezd[3];
            int ratingHotel = Convert.ToInt32(poezd[2]);
            int x = 415;
            for (int i = 0; i < ratingHotel; i++)
            {
                PictureBox box = new PictureBox();
                box.Load("../../Pictures/Star.png");
                box.Location = new Point(x, 70);
                box.Size = new Size(50, 50);
                box.SizeMode = PictureBoxSizeMode.Zoom;
                PoezdPanel.Controls.Add(box);

                x += 55;
            }
            #endregion

            #region Номера выбранной гостиницы на панеле InfoPanel
            int x1 = 20;
            for (int i = 0; i < mesta.Count; i += 3)
            {
                Label lbl = new Label();
                lbl.Location = new Point(x1, 30);
                lbl.Size = new Size(220, 30);
                lbl.Font = new Font("Arial Narrow", 13);
                lbl.Text = mesta[i + 1];
                lbl.Tag = mesta[i];
                lbl.Click += new EventHandler(labelRoom_Click);
                InfoPanel.Controls.Add(lbl);

                PictureBox pb = new PictureBox();
                try
                {
                    pb.Load("../../Pictures/" + mesta[i + 2]);
                }
                catch (Exception) { }
                pb.Location = new Point(x1, 70);
                pb.Size = new Size(270, 184);
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                pb.Tag = mesta[i];
                pb.Click += new EventHandler(Room_Click);
                InfoPanel.Controls.Add(pb);

                x1 += 320;
            }
            #endregion

        }

        private void Room_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            RoomForm rf = new RoomForm(pb.Tag.ToString());
            rf.ShowDialog();
        }

        private void labelRoom_Click(object sender, EventArgs e)
        {
            Label lb = (Label)sender;
            RoomForm rf = new RoomForm(lb.Tag.ToString());
            rf.ShowDialog();
        }
    }
}
