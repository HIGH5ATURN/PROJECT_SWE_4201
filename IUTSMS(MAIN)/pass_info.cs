using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IUTSMS_MAIN_
{
    public partial class pass_info : Form
    {
        public pass_info()
        {
            InitializeComponent();
        }


        private bool dragg = false;
        private Point StartPoint = new Point(0, 0);
        private void pass_info_MouseDown(object sender, MouseEventArgs e)
        {
            dragg = true;
            StartPoint = new Point(e.X, e.Y);

        }

        private void pass_info_MouseUp(object sender, MouseEventArgs e)
        {
            dragg = false;
        }

        private void pass_info_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragg)
            {

                Point p = PointToScreen(e.Location);

                Location = new Point(p.X - this.StartPoint.X, p.Y - this.StartPoint.Y);

            }
        }
    }
}
