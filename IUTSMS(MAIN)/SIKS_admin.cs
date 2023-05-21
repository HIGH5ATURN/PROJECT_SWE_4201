using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace IUTSMS_MAIN_
{
    public partial class SIKS_admin : Form
    {
        public SIKS_admin()
        {
            InitializeComponent();
        }

        private void SIKS_admin_Load(object sender, EventArgs e)
        {
            WinAPI.AnimateWindow(this.Handle, 500, WinAPI.BLEND);
            GetNotices();
            
            
            fillmember();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        //adding databse--->

        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OleDb.16.0; Data Source =dbst.accdb");

        OleDbCommand cmd = new OleDbCommand();

        OleDbDataAdapter adapter = new OleDbDataAdapter();
     
        DataTable dt;
        
        void GetNotices()
        
        {
            try
            {
                conn = new OleDbConnection("Provider=Microsoft.ACE.OleDb.16.0; Data Source =dbst.accdb");

                dt = new DataTable();

                adapter = new OleDbDataAdapter("SELECT * FROM siks_notice", conn);


                conn.Open();


                adapter.Fill(dt);


                dgwNotices.DataSource = dt;


                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
        
        }




        OleDbDataAdapter adapter1 = new OleDbDataAdapter();
      
        DataTable dt1;

        void fillmember()
        {
            try
            {
                conn = new OleDbConnection("Provider=Microsoft.ACE.OleDb.16.0; Data Source =dbst.accdb");


                dt1 = new DataTable();


                adapter1 = new OleDbDataAdapter("SELECT * FROM siks_table", conn);



                conn.Open();


                adapter1.Fill(dt1);


                dgw_members.DataSource = dt1;


                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void btn_publish_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "INSERT INTO siks_notice (notice) VALUES" + "(@ntc)";

                cmd = new OleDbCommand(query, conn);
              
                
                cmd.Parameters.AddWithValue("@ntc", txt_notice.Text);

               
                
                conn.Open();
                
                
                cmd.ExecuteNonQuery();
                
                
                conn.Close();
                
                
                MessageBox.Show("Notice published!");
                
                
                GetNotices();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgwNotices_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                txt_notice_no.Text = dgwNotices.CurrentRow.Cells[0].Value.ToString();

            }
            catch
            {
                txt_notice_no.Text = "NO NOTICE";

            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (txt_notice_no.Text != "NO NOTICE")
            {
                try
                {


                    string query = "DELETE FROM siks_notice where EID=@id";





                    cmd = new OleDbCommand(query, conn);


                    cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txt_notice_no.Text));


                    conn.Open();


                    cmd.ExecuteNonQuery();


                    conn.Close();


                    MessageBox.Show("Notice Deleted!");


                    GetNotices();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);

                }
            }
        }

        private void admin_back_Button_Click(object sender, EventArgs e)
        {
          
            this.Hide();
            
            
            new Admin_Form().Show();
        }

        private void dgw_members_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                txt_EID.Text = dgw_members.CurrentRow.Cells[0].Value.ToString();




                txt_name.Text = dgw_members.CurrentRow.Cells[1].Value.ToString();



                txt_st_id.Text = dgw_members.CurrentRow.Cells[2].Value.ToString();




                txt_dept.Text = dgw_members.CurrentRow.Cells[3].Value.ToString();
            }
            catch
            {
                txt_EID.Text = "No member here";
            }
        
        
        }

        private void btn_remove_member_Click(object sender, EventArgs e)
        {

            if (txt_EID.Text != "No member here")
            {
                try
                {


                    string query = "DELETE FROM siks_table where EID= @eid ";



                    cmd = new OleDbCommand(query, conn);


                    cmd.Parameters.AddWithValue("@eid", Convert.ToInt32(txt_EID.Text));



                    conn.Open();


                    cmd.ExecuteNonQuery();


                    conn.Close();


                    MessageBox.Show("Member Removed!");


                    IUTSIKS iutsiks = new IUTSIKS();


                    iutsiks.fill_arr();



                    fillmember();


                }
                catch (Exception ex)
                {


                    MessageBox.Show(ex.Message);


                }
            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {

            try
            {

                DataView dv = dt1.DefaultView;


                dv.RowFilter = "naam LIKE'%" + txt_search.Text + "%'";


                dgw_members.DataSource = dv;


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);


            }
        }


        //to move the form

        private bool dragg = false;

        private Point StartPoint = new Point(0, 0);


        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {

            dragg = true;

            StartPoint = new Point(e.X, e.Y);

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragg)
            {

                Point p = PointToScreen(e.Location);

                Location = new Point(p.X - this.StartPoint.X, p.Y - this.StartPoint.Y);

            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {

            dragg = false;


        }

        private void SIKS_admin_MouseDown(object sender, MouseEventArgs e)
        {

            dragg = true;

            StartPoint = new Point(e.X, e.Y);

        }

        private void SIKS_admin_MouseMove(object sender, MouseEventArgs e)
        {

            if (dragg)
            {

                Point p = PointToScreen(e.Location);

                Location = new Point(p.X - this.StartPoint.X, p.Y - this.StartPoint.Y);

            }

        }

        private void SIKS_admin_MouseUp(object sender, MouseEventArgs e)
        {

            dragg = false;


        }

        private void btn_changePass_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();


                string t = "Update siks_admin SET pass=@password where username='" + "adminsiks" + "'";


                cmd = new OleDbCommand(t, conn);


                cmd.Parameters.AddWithValue("@password", txt_new_pass.Text);


                cmd.ExecuteNonQuery();


                MessageBox.Show("Password Updated Successfully!");

                this.Hide();
                new Admin_Form().Show();

                txt_new_pass.Text = "";


                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
