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
    public partial class AdminPoezdaForm : Form
    {
        public AdminPoezdaForm()
        {
            InitializeComponent();

            List<string> poezda = SQLClass.MySelect("SELECT name, name_city FROM poezda");
            int y = 50;
            for (int i = 0; i < poezda.Count; i += 3)
            {
                Label lbl = new Label();
                lbl.Location = new Point(20, y);
                lbl.Size = new Size(220, 30);
                lbl.Font = new Font("Arial Narrow", 13);
                lbl.Text = poezda[i];
                InfoPoezdaPanel.Controls.Add(lbl);

                Label lbl1 = new Label();
                lbl1.Location = new Point(250, y);
                lbl1.Size = new Size(220, 30);
                lbl1.Font = new Font("Arial Narrow", 13);
                lbl1.Text = poezda[i + 1];
                InfoPoezdaPanel.Controls.Add(lbl1);

                Label lbl2 = new Label();
                lbl2.Location = new Point(450, y);
                lbl2.Size = new Size(220, 30);
                lbl2.Font = new Font("Arial Narrow", 13);
                lbl2.Text = poezda[i + 2];
                InfoPoezdaPanel.Controls.Add(lbl2);

                y += 35;

            }
        }
    }
}
