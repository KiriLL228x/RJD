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
    public partial class RoomForm : Form
    {
        public RoomForm(string RoomName)
        {
            InitializeComponent();
            Text = RoomName;
            RoomLabel.Text = RoomName;

            RoomPictureBox.Load("../../../Pictures/" + RoomName + ".jpg");
        }

        private void InfoRoomPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}