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
    public partial class society_info_Form : Form
    {
        public society_info_Form()
        {
            InitializeComponent();
        }

        private void gunaVScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private bool dragg = false;
        private Point StartPoint = new Point(0, 0);

        private void society_info_Form_MouseDown(object sender, MouseEventArgs e)
        {
            dragg = true;
            StartPoint = new Point(e.X, e.Y);
        }

        private void society_info_Form_MouseUp(object sender, MouseEventArgs e)
        {
            dragg = false;
        }

        private void society_info_Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragg)
            {

                Point p = PointToScreen(e.Location);

                Location = new Point(p.X - this.StartPoint.X, p.Y - this.StartPoint.Y);

            }
        }

        private void society_info_Form_Load(object sender, EventArgs e)
        {
            WinAPI.AnimateWindow(this.Handle, 500, WinAPI.BLEND);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
