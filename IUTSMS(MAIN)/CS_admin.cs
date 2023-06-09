﻿using System;
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
    public partial class CS_admin : Form
    {
        public CS_admin()
        {
            InitializeComponent();
        }

        private void CS_admin_Load(object sender, EventArgs e)
        {
            WinAPI.AnimateWindow(this.Handle, 500, WinAPI.BLEND);
            GetNotices();
            fillmember();
        }


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



                adapter = new OleDbDataAdapter("SELECT * FROM cs_notice", conn);



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
            conn = new OleDbConnection("Provider=Microsoft.ACE.OleDb.16.0; Data Source =dbst.accdb");


            dt1 = new DataTable();


            adapter1 = new OleDbDataAdapter("SELECT * FROM cs_table", conn);



            conn.Open();


            adapter1.Fill(dt1);


            dgw_members.DataSource = dt1;


            conn.Close();
        }
        private void btn_publish_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "INSERT INTO cs_notice (notice) VALUES" + "(@ntc)";

               
                
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
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {

                string query = "DELETE FROM cs_notice where ID=@id";

                cmd = new OleDbCommand(query, conn);




                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txt_notice_no.Text));


                conn.Open();


                cmd.ExecuteNonQuery();


                conn.Close();
                GetNotices();

                MessageBox.Show("Notice Deleted!");
            }
            catch(Exception ex)
            {

                MessageBox.Show(ex.Message);
            
            }
            
            
        }

        private void dgwNotices_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
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

        private void admin_back_Button_Click(object sender, EventArgs e)
        {
           
            
            this.Hide();
            
            
            new Admin_Form().Show();
        
        
        }

        private void dgw_members_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txt_EID.Text = dgw_members.CurrentRow.Cells[0].Value.ToString();

            txt_name.Text = dgw_members.CurrentRow.Cells[1].Value.ToString();

            txt_st_id.Text = dgw_members.CurrentRow.Cells[2].Value.ToString();

            txt_dept.Text = dgw_members.CurrentRow.Cells[3].Value.ToString();
        }

        private void btn_remove_member_Click(object sender, EventArgs e)
        {
            try
            {

                string query = "DELETE FROM cs_table where EID= @eid ";



                cmd = new OleDbCommand(query, conn);


                cmd.Parameters.AddWithValue("@eid",Convert.ToInt32( txt_EID.Text));



                conn.Open();


                cmd.ExecuteNonQuery();


                conn.Close();


                MessageBox.Show("Member Removed!");


                IUTCS iutcs = new IUTCS();
                
                iutcs.fill_arr();
               
                fillmember();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataView dv = dt1.DefaultView;

                dv.RowFilter = "naam LIKE'%" + textBox1.Text + "%'";

                dgw_members.DataSource = dv;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //to move the Form

        private bool dragg = false;

        private Point StartPoint = new Point(0, 0);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            dragg= true;
            StartPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {

            dragg= false;

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragg)
            {

                Point p = PointToScreen(e.Location);

                Location = new Point(p.X - this.StartPoint.X, p.Y - this.StartPoint.Y);

            }
        }

        private void CS_admin_MouseDown(object sender, MouseEventArgs e)
        {
            dragg = true;
            StartPoint = new Point(e.X, e.Y);
        }

        private void CS_admin_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragg)
            {

                Point p = PointToScreen(e.Location);

                Location = new Point(p.X - this.StartPoint.X, p.Y - this.StartPoint.Y);

            }
        }

        private void CS_admin_MouseUp(object sender, MouseEventArgs e)
        {
            dragg = false;
        }

        private void btn_changePass_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();


                string t = "Update cs_admin SET pass=@password where username='" +"admincs" + "'";


                cmd = new OleDbCommand(t, conn);


                cmd.Parameters.AddWithValue("@password", txt_new_pass.Text);


                cmd.ExecuteNonQuery();


                MessageBox.Show("Password Updated Successfully!");

                this.Hide();
                new Admin_Form().Show();

                txt_new_pass.Text = "";


                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
