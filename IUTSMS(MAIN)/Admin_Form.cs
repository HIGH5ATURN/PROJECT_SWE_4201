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
    public partial class Admin_Form : Form
    {//adasdasdasdasdasdasdadadasdsada
        public Admin_Form()
        {
            InitializeComponent();
        }

        private void Admin_Form_Load(object sender, EventArgs e)
        {
            WinAPI.AnimateWindow(this.Handle, 500, WinAPI.BLEND);
        }
        //to move the form
        private bool dragg = false;
        private Point StartPoint = new Point(0, 0);

        private void Admin_Form_MouseDown(object sender, MouseEventArgs e)
        {
            dragg = true;
            StartPoint = new Point(e.X, e.Y);


        }

        private void Admin_Form_MouseUp(object sender, MouseEventArgs e)
        {
            dragg = false;
        }

        private void Admin_Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragg)
            {

                Point p = PointToScreen(e.Location);

                Location = new Point(p.X - this.StartPoint.X, p.Y - this.StartPoint.Y);

            }
        }
        //to move the form
        private void admin_back_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (admin_login_combobox.Text == "IUTCS")
                {
                    if (login_u_id_textBox.Text == "admincs" && login_pass_textBox.Text == "passcs")
                    {
                        new CS_admin().Show();
                        this.Hide();
                    }
                    else
                    {
                        throw new Exception("Invalid Username or password!");
                    }
                }

                else if (admin_login_combobox.Text == "IUTPS")
                {
                    if (login_u_id_textBox.Text == "adminps" && login_pass_textBox.Text == "passps")
                    {
                        new PS_admin().Show();
                        this.Hide();
                    }
                    else
                    {
                        throw new Exception("Invalid Username or password!");
                    }
                }
                else if (admin_login_combobox.Text == "IUTSIKS")
                {
                    if (login_u_id_textBox.Text == "adminsiks" && login_pass_textBox.Text == "passsiks")
                    {
                        new SIKS_admin().Show();
                        this.Hide();
                    }
                    else
                    {
                        throw new Exception("Invalid Username or password!");
                    }
                }
                else if (admin_login_combobox.Text == "IUTDS")
                {
                    if (login_u_id_textBox.Text == "adminds" && login_pass_textBox.Text == "passds")
                    {
                        new DS_admin().Show();
                        this.Hide();
                    }
                    else
                    {
                        throw new Exception("Invalid Username or password!");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (login_pass_textBox.UseSystemPasswordChar)
            {
                login_pass_textBox.UseSystemPasswordChar = false;
            }
            else
            {
                login_pass_textBox.UseSystemPasswordChar = true;
            }
        }
    }
}
