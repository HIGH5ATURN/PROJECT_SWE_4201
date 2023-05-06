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
    public partial class st_change_pass_Form : Form
    {
     
        public st_change_pass_Form()
        {
            InitializeComponent();
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(txt_newPass.UseSystemPasswordChar && txt_confirm_newPass.UseSystemPasswordChar)
            {

                txt_confirm_newPass.UseSystemPasswordChar = false;
                
                
                txt_newPass.UseSystemPasswordChar = false;
                
             
            }
            else
            {

                txt_confirm_newPass.UseSystemPasswordChar =true;


                txt_newPass.UseSystemPasswordChar = true;

            }
        }

        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OleDb.16.0; Data Source =dbst.accdb");

        OleDbCommand cmd = new OleDbCommand();





       


        private void login_button_Click(object sender, EventArgs e)
        {
            WinAPI.AnimateWindow(this.Handle, 500, WinAPI.BLEND);

            try
            {
              
                if (txt_newPass.Text != "" && txt_confirm_newPass.Text!="")
                {
                    if (txt_newPass.Text == txt_confirm_newPass.Text)
                    {
                        conn.Open();


                        string t = "Update st_info SET passu=@password where st_id=" + st_login_Form.id + "";


                        cmd = new OleDbCommand(t, conn);


                        cmd.Parameters.AddWithValue("@password", txt_newPass.Text);


                        cmd.ExecuteNonQuery();


                        MessageBox.Show("Password Updated Successfully!");

                        txt_newPass.Text = "";


                        txt_confirm_newPass.Text = "";
                       
                        conn.Close();
                    }
                    else
                    {

                        throw new Exception("New password dont match!");

                    }
                }
                else
                {
                    throw new Exception("Fill the required Area!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }





        private bool dragging = false;
        private Point startPoint = new Point(0, 0);


        private void st_change_pass_Form_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void st_change_pass_Form_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void st_change_pass_Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {

                Point p = PointToScreen(e.Location);

                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);

            }
        }

        private void st_change_pass_Form_Load(object sender, EventArgs e)
        {
            WinAPI.AnimateWindow(this.Handle, 500, WinAPI.BLEND);

        }
    }
}
