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
    public partial class UC_iutds_st_page : UserControl
    {
        public UC_iutds_st_page()
        {
            InitializeComponent();
        }


        
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OleDb.16.0; Data Source = dbst.accdb");

        



        OleDbCommand cmd = new OleDbCommand();

        


        OleDbDataAdapter adapter1 = new OleDbDataAdapter();
        

        DataTable dt1;

        void getDiscuss()
        {
            conn.Close();
            try
            {

                conn = new OleDbConnection("Provider=Microsoft.ACE.OleDb.16.0; Data Source =dbst.accdb");



                string f = "SELECT * FROM ds_discuss";

                cmd = new OleDbCommand(f, conn);

                conn.Open();
                OleDbDataReader dr = cmd.ExecuteReader();

                dgw_chat.Rows.Clear();

                while (dr.Read())
                {
                    int n = dgw_chat.Rows.Add();

                    dgw_chat.Rows[n].Cells[0].Value = dr["naam"].ToString();

                    dgw_chat.Rows[n].Cells[1].Value = dr["message"].ToString();
                }



                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        OleDbDataAdapter adapter = new OleDbDataAdapter();
        DataTable dt;
        void GetNotices()
        {
            
            
            
            conn = new OleDbConnection("Provider=Microsoft.ACE.OleDb.16.0; Data Source =dbst.accdb");




            dt = new DataTable();




            adapter = new OleDbDataAdapter("SELECT * FROM ds_notice", conn);

            



            conn.Open();
            
            


            adapter.Fill(dt);
            


            dgwNotices.DataSource = dt;
            

            conn.Close();
        }

        //this button is for IUTDS resource , forgot to change the button name accordingly ...
        private void Read_Quran_Button_Click(object sender, EventArgs e)
        {
   

            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=cqoNQP4IcyU&list=PL1pf33qWCkmisHCMKSfN8y0dfLFwDIQAM");
        }

        private void fb_button_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/iutdebatingsociety/");
        }

        private void btn_send_msg_Click(object sender, EventArgs e)
        {
            string f = "";
            for (int i = 0; i < IUTDS.arr_ds_students.Count; i++)
            {
                if (Convert.ToInt32(st_login_Form.id) == IUTDS.arr_ds_students[i].id)
                {
                    f = IUTDS.arr_ds_students[i].name;
                    break;
                }

            }
            try
            {


                conn.Open();


                string t = "INSERT INTO ds_discuss  (naam, message) VALUES" + "(@name,@msg)";

                cmd = new OleDbCommand(t, conn);

                cmd.Parameters.AddWithValue("@name", f);

                cmd.Parameters.AddWithValue("@msg", txt_msg.Text);

                cmd.ExecuteNonQuery();

                conn.Close();

                getDiscuss();




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UC_iutds_st_page_Load(object sender, EventArgs e)
        {
            getDiscuss();
            GetNotices();
        }
    }
}
