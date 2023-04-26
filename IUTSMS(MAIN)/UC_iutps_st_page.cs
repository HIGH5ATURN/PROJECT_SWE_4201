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
    public partial class UC_iutps_st_page : UserControl
    {
        public UC_iutps_st_page()
        {
            InitializeComponent();
        }

        private void fb_button_Click(object sender, EventArgs e)
        {

            System.Diagnostics.Process.Start("https://www.facebook.com/IUTPS/");
        }

        private void go_button_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.gettyimages.com/workwithus");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
