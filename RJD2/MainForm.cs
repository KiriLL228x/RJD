using System;
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

namespace RJD2
{
    public partial class MainForm : Form
    {
        //Функция SELECT-запроса
        public static List<string> MySelect(string cmdText)
        {
            List<string> list = new List<string>();
            MySqlConnection conn = new MySqlConnection(CONNECTION_STRING);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(cmdText, conn);
            DbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    list.Add(reader.GetValue(i).ToString());
                }
            }
            reader.Close();
            conn.Close();
            return list;
        }

        const string CONNECTION_STRING =
       "SslMode=none;Server=localhost;Database=bookingcom;port=3306;Uid=root;charset=utf8";



        public MainForm()
        {
            InitializeComponent();

            List<string> cityes = MySelect("SELECT DISTINCT name FROM cityes ORDER BY name");

            CityComboBox.Items.Clear();
            CityComboBox.Items.Add("");
            foreach (string city in cityes)
                CityComboBox.Items.Add(city);

            List<string> poezd = MySelect("SELECT id, name, adress_pic FROM hotels");

            int x = 20;
            for (int i = 0; i < poezd.Count; i += 3)
            {
                PictureBox pb = new PictureBox();
                try
                {
                    pb.Load("../../Pictures/" + poezd[i + 2]);
                }
                catch (Exception) { }
                pb.Location = new Point(x, 60);
                pb.Size = new Size(270, 184);
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                pb.Tag = poezd[i];
                pb.Click += new EventHandler(Poezd_Click);
                InfoPanel.Controls.Add(pb);

                x += 320;
            }

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

      
    }
}

