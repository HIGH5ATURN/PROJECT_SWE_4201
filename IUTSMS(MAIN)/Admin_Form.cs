using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
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

        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OleDb.16.0; Data Source =dbst.accdb");

        OleDbCommand cmd = new OleDbCommand();
        private void login_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (admin_login_combobox.Text == "IUTCS")
                {
                    try
                    {
                        conn.Close();
                        conn.Open();


                        string t = "SELECT * FROM cs_admin where username ='" + login_u_id_textBox.Text + "' and pass ='" + login_pass_textBox.Text + "'";

                        cmd = new OleDbCommand(t, conn);
                        OleDbDataReader dr = cmd.ExecuteReader();

                        if (dr.Read())
                        {
                            //when password matched-->
                            new CS_admin().Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password,Please Try again", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        conn.Close();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

                else if (admin_login_combobox.Text == "IUTPS")
                {
                    try
                    {
                        conn.Close();
                        conn.Open();


                        string t = "SELECT * FROM ps_admin where username ='" + login_u_id_textBox.Text + "' and pass ='" + login_pass_textBox.Text + "'";

                        cmd = new OleDbCommand(t, conn);
                        OleDbDataReader dr = cmd.ExecuteReader();

                        if (dr.Read())
                        {
                            //when password matched-->
                            new PS_admin().Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password,Please Try again", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        conn.Close();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else if (admin_login_combobox.Text == "IUTSIKS")
                {
                    try
                    {
                        conn.Close();
                        conn.Open();


                        string t = "SELECT * FROM siks_admin where username ='" + login_u_id_textBox.Text + "' and pass ='" + login_pass_textBox.Text + "'";

                        cmd = new OleDbCommand(t, conn);
                        OleDbDataReader dr = cmd.ExecuteReader();

                        if (dr.Read())
                        {
                            //when password matched-->
                            new SIKS_admin().Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password,Please Try again", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        conn.Close();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else if (admin_login_combobox.Text == "IUTDS")
                {
                    try
                    {
                        conn.Close();
                        conn.Open();


                        string t = "SELECT * FROM ds_admin where username ='" + login_u_id_textBox.Text + "' and pass ='" + login_pass_textBox.Text + "'";

                        cmd = new OleDbCommand(t, conn);
                        OleDbDataReader dr = cmd.ExecuteReader();

                        if (dr.Read())
                        {
                            //when password matched-->
                            new DS_admin().Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password,Please Try again", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        conn.Close();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
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
