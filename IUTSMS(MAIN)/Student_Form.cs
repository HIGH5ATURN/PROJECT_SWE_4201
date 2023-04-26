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
using System.Diagnostics.Eventing.Reader;

namespace IUTSMS_MAIN_
{
    public partial class Student_Form : Form
    {
        public Student_Form()
        {
            InitializeComponent();
        }

        
        private void Student_Form_Load(object sender, EventArgs e)
        {
            WinAPI.AnimateWindow(this.Handle, 500, WinAPI.BLEND);
        }
        
        
        private void student_user_control1_MouseDown(object sender, MouseEventArgs e)
        {

        }
        //to move the form
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);
        private void Student_Form_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void Student_Form_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void Student_Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {

                Point p = PointToScreen(e.Location);

                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);

            }
        }

        private void admin_back_Button_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void student_user_control1_Load(object sender, EventArgs e)
        {

        }

        private void society_info_LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new society_info_Form().Show();
            
        }

        private void Login_LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
            this.Hide(); 
            new st_login_Form().Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        //Now adding databse--->


        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OleDb.16.0; Data Source =dbst.accdb");

        OleDbCommand cmd = new OleDbCommand();

        OleDbDataAdapter da = new OleDbDataAdapter();
        private void register_button_Click(object sender, EventArgs e)
        {
            if (st_reg_pass_TextBox.Text == st_reg_conf_pass_textbox.Text)
            {

                try
                {


                    conn.Open();


                    string t = "INSERT INTO st_info (naam, st_id,dept,passu) VALUES" + "(@name,@id,@dp,@pass)";

                    cmd = new OleDbCommand(t, conn);

                    cmd.Parameters.AddWithValue("@name", st_reg_name_textbox.Text);
                    cmd.Parameters.AddWithValue("@id", st_reg_id_textbox.Text);
                    cmd.Parameters.AddWithValue("@dp", st_reg_ComboBox.Text);
                    cmd.Parameters.AddWithValue("@pass", st_reg_pass_TextBox.Text);

                    cmd.ExecuteNonQuery();
                    conn.Close();

                    Form1 f1 = new Form1();

                    f1.fill_regst_list();

                    MessageBox.Show("You've Registered in the System Successfully!");


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Password mismatch!");
                st_reg_conf_pass_textbox.Clear();
                st_reg_pass_TextBox.Clear();
            }
        }
       
    }
}
