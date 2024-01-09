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
    public partial class AdminPoezdaForm : Form
    {
        public AdminPoezdaForm()
        {
            InitializeComponent();
        }

        string adress;
        private void PoezdPictureBox_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                adress = openFileDialog1.FileName;
                PoezdPictureBox.Load(adress);
                adress = Path.GetFileName(adress);
            }
        }

        private void AddHotelButton_Click(object sender, EventArgs e)
        {
            if (NamePoezdTextBox.Text != "")
            {
                SQLClass.MyUpDate("INSERT INTO poezda (name, adress_pic) VALUES ('" + NamePoezdTextBox.Text + "', '" + adress + "')");
                MessageBox.Show("Сохранено");
                AdminPoezdaForm_Load_1(sender, e);
                NamePoezdTextBox.Text = "";
                PoezdPictureBox.Image = null;
            }
            else
            {
                MessageBox.Show("Заполните обязательные поля");
            }
        }

        private void AdminPoezdaForm_Load_1(object sender, EventArgs e)
        {
            InfoPoezdsPanel.Controls.Clear();
            InfoPoezdsPanel.Controls.Add(label1);
            InfoPoezdsPanel.Controls.Add(label2);

            List<string> poezda = SQLClass.MySelect("SELECT id, name FROM poezda");
            int y = 50;
            for (int i = 0; i < poezda.Count; i += 2)
            {
                Label lbl = new Label();
                lbl.Location = new Point(20, y);
                lbl.Size = new Size(220, 30);
                lbl.Font = new Font("Arial Narrow", 13);
                lbl.Tag = poezda[i];
                lbl.Text = poezda[i+1];
                InfoPoezdsPanel.Controls.Add(lbl);

                Label lbl1 = new Label();
                lbl1.Location = new Point(250, y);
                lbl1.Size = new Size(120, 30);
                lbl1.Font = new Font("Arial Narrow", 13);
                lbl1.Text = poezda[i + 1];
                InfoPoezdsPanel.Controls.Add(lbl1);

                

                Button btn = new Button();
                btn.Location = new Point(800, y);
                btn.Size = new Size(100, 30);
                btn.Font = new Font("Arial Narrow", 12);
                btn.Click += new EventHandler(DeletePoezdClick);
                btn.Text = "Удалить";
                InfoPoezdsPanel.Controls.Add(btn);

                y += 35;
            }
        }

        private void DeletePoezdClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int y = btn.Location.Y;

            foreach (Control control in InfoPoezdsPanel.Controls)
            {
                if (control.Location == new Point(20, y))
                {
                    SQLClass.MyUpDate("DELETE FROM poezda WHERE id = '" + control.Tag + "'");
                    MessageBox.Show("Удаление успешно");
                    AdminPoezdaForm_Load_1(sender, e);
                }
            }
        }

       
    }

}
