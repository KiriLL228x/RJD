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
    public partial class RoomForm : Form
    {
        public RoomForm(string idMesto)
        {
            InitializeComponent();

            List<string> mesta = SQLClass.MySelect("SELECT name, adress_pic, id_poezd FROM mesta WHERE id = " + idMesto);
            List<string> poezd = SQLClass.MySelect("SELECT name FROM poezda WHERE id = " + mesta[2]);

            Text = poezd[0] + ": " + mesta[0];
            RoomLabel.Text = poezd[0] + ": " + mesta[0];

            RoomPictureBox.Load("../../Pictures/" + mesta[1]);

        }


    }
}