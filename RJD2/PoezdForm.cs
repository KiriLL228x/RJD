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
        public PoezdForm(string PoezdName)
        {
            InitializeComponent();

            InfoPictureBox.Load("../../Pictures/" + PoezdName + ".jpg");
        }

        private void Room_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            RoomForm rf = new RoomForm(pb.Tag.ToString());
            rf.ShowDialog();
        }
    }
}
