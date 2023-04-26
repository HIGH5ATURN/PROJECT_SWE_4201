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
    public partial class Loading_Form : Form
    {
        public Loading_Form()
        {
            InitializeComponent();
            pbar.Value = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pbar.Value +=1;

            if(pbar.Value==100)
            {
                timer1.Stop();

                new Form1().Show();

                this.Hide();
            }
        }

        private void Loading_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
