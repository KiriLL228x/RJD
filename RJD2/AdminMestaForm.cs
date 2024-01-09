using RJD2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RJD2
{
    public partial class AdminMestaForm : Form
    {
        public AdminMestaForm()
        {
            InitializeComponent();

        }

        private void AdminMestaForm_Load_1(object sender, EventArgs e)
        {
            InfoMestaPanel.Controls.Clear();
            InfoMestaPanel.Controls.Add(label1);
            InfoMestaPanel.Controls.Add(label2);

            List<string> poezda = SQLClass.MySelect("SELECT id, name FROM poezda");

            PoezdsComboBox.Items.Clear();
            for (int i = 0; i < poezda.Count; i += 2)
            {
                PoezdsComboBox.Items.Add(poezda[i] + ". " + poezda[i + 1]);
            }

            List<string> rooms = SQLClass.MySelect("SELECT id, name, id_poezd FROM mesta");
            int y = 50;
            for (int i = 0; i < rooms.Count; i += 3)
            {
                Label lbl = new Label();
                lbl.Location = new Point(20, y);
                lbl.Size = new Size(220, 30);
                lbl.Font = new Font("Arial Narrow", 13);
                lbl.Tag = rooms[i];
                lbl.Text = rooms[i + 1];
                InfoMestaPanel.Controls.Add(lbl);

                List<string> poezd = new List<string>();
                poezd.Clear();
                poezd = SQLClass.MySelect("SELECT name FROM poezda WHERE id = " + rooms[i + 2]);

                Label lbl1 = new Label();
                lbl1.Location = new Point(475, y);
                lbl1.Size = new Size(250, 30);
                lbl1.Font = new Font("Arial Narrow", 13);
                lbl1.Text = poezd[0];
                InfoMestaPanel.Controls.Add(lbl1);

                Button btn = new Button();
                btn.Location = new Point(800, y);
                btn.Size = new Size(100, 30);
                btn.Font = new Font("Arial Narrow", 12);
                btn.Click += new EventHandler(DeleteMestoClick);
                btn.Text = "Удалить";
                InfoMestaPanel.Controls.Add(btn);

                y += 35;
            }
        }

        string adress;
        private void RoomPictureBox_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                adress = openFileDialog1.FileName;
                RoomPictureBox.Load(adress);
                adress = Path.GetFileName(adress);
            }
        }

        private void AddMestoButton_Click(object sender, EventArgs e)
        {
            string id_poezd = "";
            string[] text = PoezdsComboBox.Text.Split(new string[] { ". " }, StringSplitOptions.None);
            id_poezd = text[0];

            if (NameRoomTextBox.Text != "" &&  PoezdsComboBox.Text != "")
            {
                SQLClass.MyUpDate("INSERT INTO mesta (name, adress_pic, id_poezd) VALUES ('" + NameRoomTextBox.Text + "','" + adress + "', '" + id_poezd + "')");
                MessageBox.Show("Сохранено");
                AdminMestaForm_Load_1(sender, e);
                NameRoomTextBox.Text = "";
                PoezdsComboBox.Text = "";
                RoomPictureBox.Image = null;
            }
            else
            {
                MessageBox.Show("Заполните обязательные поля");
            }
        }

        private void DeleteMestoClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int y = btn.Location.Y;

            foreach (Control control in InfoMestaPanel.Controls)
            {
                if (control.Location == new Point(20, y))
                {
                    SQLClass.MyUpDate("DELETE FROM mesta WHERE id = '" + control.Tag + "'");
                    MessageBox.Show("Удаление успешно");
                    AdminMestaForm_Load_1(sender, e);
                }
            }
        }

      
    }
}
