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
using RJD2;

namespace RJD
{
    public partial class MainForm : Form
    {
        const string CONNECTION_STRING = "SslMode=none;Server=localhost;Database=rjd;port=3306;Uid=root;charet=utf8";

        public MainForm()
        {
            InitializeComponent();

            MySqlConnection conn = new MySqlConnection(CONNECTION_STRING);
            conn.Open();

            MySqlCommand cmd = new MySqlCommand("SELECT id, name FROM city", conn);

            DbDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string id = reader.GetValue(0).ToString();
                string name = reader.GetValue(1).ToString();
            }
            reader.Close();
            conn.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            PoezdForm pf = new PoezdForm(pb.Tag.ToString());
            pf.ShowDialog();
        }
    }
}
