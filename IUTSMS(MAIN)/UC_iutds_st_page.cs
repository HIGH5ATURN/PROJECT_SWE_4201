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
    public partial class UC_iutds_st_page : UserControl
    {
        public UC_iutds_st_page()
        {
            InitializeComponent();
        }

        private void Read_Quran_Button_Click(object sender, EventArgs e)
        {
   

            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=cqoNQP4IcyU&list=PL1pf33qWCkmisHCMKSfN8y0dfLFwDIQAM");
        }

        private void fb_button_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/iutdebatingsociety/");
        }
    }
}
