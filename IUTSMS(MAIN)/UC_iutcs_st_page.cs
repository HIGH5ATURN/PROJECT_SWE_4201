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
    public partial class UC_iutcs_st_page : UserControl
    {
        public UC_iutcs_st_page()
        {
            InitializeComponent();
        }


        //adding databse-->
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OleDb.16.0; Data Source = dbst.accdb");

        OleDbCommand cmd = new OleDbCommand();

        // OleDbDataAdapter da = new OleDbDataAdapter();


        private void btn_course_enroll_Click(object sender, EventArgs e)
        {
            string f;
            if(cmb_enroll.Text== "JAVA lang. Course")
            {
                f = "java";
                gunaGradientTileButton1.Enabled = true;
            }
            else if(cmb_enroll.Text== "Competitive Programming Course")
            {
                f = "cp";
                btn_rcs_cp.Enabled = true;

            }
            else
            {
                f = "WebDev";
                btn_rcs_web.Enabled = true;
            }
            try
            {


                conn.Open();

                string g = "-1";
                string t = "UPDATE cs_table set "+f+"="+g+"";

                cmd = new OleDbCommand(t, conn);
              
                cmd.ExecuteNonQuery();

                conn.Close();


                MessageBox.Show("Enrolled into"+cmb_enroll.Text+" !");

              
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        

        void DoIunfreezeButton()
        {
            try
            {


                conn.Open();


                string t = "SELECT * FROM cs_table where st_id=" + st_login_Form.id + "";

                cmd = new OleDbCommand(t, conn);

                OleDbDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {

                    //MessageBox.Show($"{dr["java"].ToString()}\t{dr["cp"].ToString()}\t{dr["WebDev"].ToString()}");



                    if (dr["java"].ToString() == "True")
                    {
                        gunaGradientTileButton1.Enabled = true;

                    }
                    if (dr["cp"].ToString() == "True")
                    {
                        btn_rcs_cp.Enabled = true;
                    }
                    if (dr["WebDev"].ToString() == "True")
                    {
                        btn_rcs_web.Enabled = true;
                    }

                }

                conn.Close();







            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void UC_iutcs_st_page_Load(object sender, EventArgs e)
        {
            GetNotices();
            getDiscuss();
            DoIunfreezeButton();

        }

        private void gunaGradientTileButton1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/results?search_query=java+language+tutorial+for+beginners+");
        }

        private void btn_rcs_cp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=OMcxQ3IY-qc&list=PLauivoElc3ggagradg8MfOZreCMmXMmJ-");
        }

        private void btn_rcs_web_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=l1EssrLxt7E&list=PLfqMhTWNBTe3H6c9OGXb5_6wcc1Mca52n");
        }

        private void fb_button_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/IUTCS");
        }

        OleDbDataAdapter adapter = new OleDbDataAdapter();
        DataTable dt;
        void getDiscuss()
        {
            conn.Close();
            try {

                conn = new OleDbConnection("Provider=Microsoft.ACE.OleDb.16.0; Data Source =dbst.accdb");

              

                string f = "SELECT * FROM cs_discuss";

                cmd = new OleDbCommand(f, conn);

                conn.Open();
                OleDbDataReader dr = cmd.ExecuteReader();

                while(dr.Read())
                {
                    int n = dgw_chat_CS.Rows.Add();
                   
                    dgw_chat_CS.Rows[n].Cells[0].Value= dr["naam"].ToString();

                    dgw_chat_CS.Rows[n].Cells[1].Value = dr["message"].ToString();
                }



                conn.Close();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
        OleDbDataAdapter adapter1 = new OleDbDataAdapter();
        DataTable dt1;
        void GetNotices()
        {
            conn = new OleDbConnection("Provider=Microsoft.ACE.OleDb.16.0; Data Source =dbst.accdb");

            dt1 = new DataTable();

            adapter1 = new OleDbDataAdapter("SELECT * FROM cs_notice", conn);

            conn.Open();
            adapter1.Fill(dt1);
            dgwNotices.DataSource = dt1;
            conn.Close();
        }


        private void btn_send_msg_Click(object sender, EventArgs e)
        {
            string f="";
            for(int i=0;i<IUTCS.arr_cs_students.Count;i++)
            {
                if (Convert.ToInt32(st_login_Form.id) == IUTCS.arr_cs_students[i].id)
                {
                    f = IUTCS.arr_cs_students[i].name;
                    break;
                }

            }
            try
            {


                conn.Open();


                string t = "INSERT INTO cs_discuss  (naam, message) VALUES" + "(@name,@msg)";

                cmd = new OleDbCommand(t, conn);
                cmd.Parameters.AddWithValue("@name",f);
                cmd.Parameters.AddWithValue("@msg", txt_msg.Text);

                cmd.ExecuteNonQuery();
                conn.Close();
                getDiscuss();

                txt_msg.Clear();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_play_snake_Click(object sender, EventArgs e)
        {
            new Classic_Snake_Game().Show();
        }
    }
}
