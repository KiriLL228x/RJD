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

            PoezdTextBox.ReadOnly = !Convert.ToBoolean(MainForm.isAdmin);
            PoezdTextBox.Enabled = Convert.ToBoolean(MainForm.isAdmin);
            AddDescButton.Visible = Convert.ToBoolean(MainForm.isAdmin);

            List<string> poezd = SQLClass.MySelect("SELECT * FROM poezda WHERE id = " + _idPoezd);
            List<string> mesta = SQLClass.MySelect("SELECT id, name, adress_pic, price, kol FROM mesta WHERE id_poezd = " + _idPoezd);

          
            Text = poezd[1];
            PoezdLabel.Text = poezd[1];
            PoezdPB.Load("../../Pictures/" + poezd[3]);
            PoezdTextBox.Text = poezd[2];

           

            
            int x1 = 20;
            for (int i = 0; i < mesta.Count; i += 5)
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

                Label lbl1 = new Label();
                lbl1.Location = new Point(x1, 255);
                lbl1.Size = new Size(120, 30);
                lbl1.Font = new Font("Arial Narrow", 11);
                lbl1.Text = "Цена, руб.  " + mesta[i + 3];
                InfoPanel.Controls.Add(lbl1);

                Label lbl2 = new Label();
                lbl2.Location = new Point(x1 + 150, 255);
                lbl2.Size = new Size(120, 30);
                lbl2.Font = new Font("Arial Narrow", 11);
                lbl2.Text = "Кол-во, шт.  " + mesta[i + 4];
                InfoPanel.Controls.Add(lbl2);

                x1 += 320;
            }
            

        }

        private void Room_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            MestaForm rf = new MestaForm(pb.Tag.ToString());
            rf.ShowDialog();
        }

        private void labelRoom_Click(object sender, EventArgs e)
        {
            Label lb = (Label)sender;
            MestaForm rf = new MestaForm(lb.Tag.ToString());
            rf.ShowDialog();
        }

        private void AddDescButton_Click(object sender, EventArgs e)
        {
            SQLClass.MyUpDate("UPDATE poezda SET opis = '" + PoezdTextBox.Text + "' WHERE id = '" + _idPoezd + "'");
            MessageBox.Show("Сохранено");
        }
    }
}
