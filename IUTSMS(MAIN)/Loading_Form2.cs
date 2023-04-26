using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IUTSMS_MAIN_
{
    public partial class Loading_Form2 : Form
    {
        [DllImport("Gdi32.dll",EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int RightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse

        );

        public Loading_Form2()
        {
            InitializeComponent();
            gunaProgressBar1.Value = 0;

            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        
        private void gunaProgressBar1_Click(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            gunaProgressBar1.Value += 1;

            if (gunaProgressBar1.Value == 100)
            {
                timer1.Stop();

                new Form1().Show();

                this.Hide();
            }
        }
    }
}
