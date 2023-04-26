using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IUTSMS_MAIN_
{
    public partial class Student_user_control : UserControl
    {
        public Student_user_control()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void society_info_LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new society_info_Form().Show();
            
            new Student_Form().Hide();
        }

        private void Login_LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {



            new st_login_Form().Show();
        }

        private void Student_user_control_Load(object sender, EventArgs e)
        {

        }
    }
}
