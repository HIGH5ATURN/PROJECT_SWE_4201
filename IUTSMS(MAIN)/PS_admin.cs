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
    public partial class PS_admin : Form
    {
        public PS_admin()
        {
            InitializeComponent();
        }

        private void PS_admin_Load(object sender, EventArgs e)
        {
            WinAPI.AnimateWindow(this.Handle, 500, WinAPI.BLEND);
        }
    }
}
