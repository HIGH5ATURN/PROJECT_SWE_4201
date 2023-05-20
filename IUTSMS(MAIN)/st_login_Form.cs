using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.OleDb;

namespace IUTSMS_MAIN_
{
    public partial class st_login_Form : Form
    {
        
        public st_login_Form()
        {
            InitializeComponent();
        }

        private void st_login_Form_Load(object sender, EventArgs e)
        {
            WinAPI.AnimateWindow(this.Handle, 500, WinAPI.BLEND);
        }

        private void register_LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Student_Form().Show();
            this.Hide();
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

        private void gunaControlBox2_Click(object sender, EventArgs e)
        {
            WinAPI.AnimateWindow(this.Handle, 2000, WinAPI.BLEND);
        }


        //now adding Databse --->


        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OleDb.16.0; Data Source =dbst.accdb");

        OleDbCommand cmd = new OleDbCommand();

        OleDbDataAdapter da = new OleDbDataAdapter();

        public static string id;//for the purpose to show info in dashboard

        private void st_login_button_Click(object sender, EventArgs e)
        {
            try
            {

                conn.Open();


                string t = "SELECT * FROM st_info where st_id=" + login_u_id_textBox.Text + " and passu ='" + login_pass_textBox.Text + "'";

                cmd = new OleDbCommand(t, conn);
                OleDbDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    //when password matched-->
                    new stdnt_club_dash().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password,Please Try again", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conn.Close();

            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }

    
        }

        private void login_u_id_textBox_TextChanged(object sender, EventArgs e)
        {
            id = login_u_id_textBox.Text;
        }

        private void admin_back_Button_Click(object sender, EventArgs e)
        {
            this.Hide();

            
            new Form1().Show();

        }
    }
}
