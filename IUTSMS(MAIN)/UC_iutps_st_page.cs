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
    public partial class UC_iutps_st_page : UserControl
    {
        public UC_iutps_st_page()
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



                string f = "SELECT * FROM ps_discuss";

                cmd = new OleDbCommand(f, conn);

                conn.Open();
                OleDbDataReader dr = cmd.ExecuteReader();

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

            adapter = new OleDbDataAdapter("SELECT * FROM ps_notice", conn);

            conn.Open();
            adapter.Fill(dt);
            dgwNotices.DataSource = dt;
            conn.Close();
        }

        private void fb_button_Click(object sender, EventArgs e)
        {

            System.Diagnostics.Process.Start("https://www.facebook.com/IUTPS/");
        }

        private void go_button_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.gettyimages.com/workwithus");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgw_chat_CS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_send_msg_Click(object sender, EventArgs e)
        {
            string f = "";
            for (int i = 0; i < IUTPS.arr_ps_students.Count; i++)
            {
                if (Convert.ToInt32(st_login_Form.id) == IUTPS.arr_ps_students[i].id)
                {
                    f = IUTPS.arr_ps_students[i].name;
                    break;
                }

            }
            try
            {


                conn.Open();


                string t = "INSERT INTO ps_discuss  (naam, message) VALUES" + "(@name,@msg)";

                cmd = new OleDbCommand(t, conn);

                cmd.Parameters.AddWithValue("@name", f);

                cmd.Parameters.AddWithValue("@msg", txt_msg.Text);

                cmd.ExecuteNonQuery();

                conn.Close();

                getDiscuss();

                txt_msg.Text = "";



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




        void DoIunfreezeButton()
        {
            try
            {


                conn.Open();


                string t = "SELECT * FROM ps_table where st_id=" + st_login_Form.id + "";

                cmd = new OleDbCommand(t, conn);

                OleDbDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {

                    //MessageBox.Show($"{dr["java"].ToString()}\t{dr["cp"].ToString()}\t{dr["WebDev"].ToString()}");



                    if (dr["cam"].ToString() == "True")
                    {
                        gunaGradientTileButton1.Enabled = true;

                    }
                    if (dr["adobe"].ToString() == "True")
                    {
                        btn_rcs_photoshop_course.Enabled = true;
                    }
                    if (dr["graph"].ToString() == "True")
                    {
                        btn_rcs_graphic_course.Enabled = true;
                    }

                }

                conn.Close();







            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }






        private void UC_iutps_st_page_Load(object sender, EventArgs e)
        {
            getDiscuss();
            GetNotices();
            DoIunfreezeButton();
        }

        private void btn_course_enroll_Click(object sender, EventArgs e)
        {
            string f;
            if (cmb_enroll.Text == "Photography Course")
            {

                f = "cam";
               
                gunaGradientTileButton1.Enabled = true;

            }
            else if (cmb_enroll.Text == "Photoshop Course")
            {

                f = "adobe";
               
                
                btn_rcs_photoshop_course.Enabled = true;


            }
            else
            {
               
                f = "graph";
               
                btn_rcs_graphic_course.Enabled = true;



                
            }
            try
            {


                conn.Open();

                string g = "-1";
                string t = "UPDATE ps_table set " + f + "=" + g + "";

                cmd = new OleDbCommand(t, conn);

                cmd.ExecuteNonQuery();

                conn.Close();


                MessageBox.Show("Enrolled into" + cmb_enroll.Text + " !");




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void gunaGradientTileButton1_Click(object sender, EventArgs e)
        {


            System.Diagnostics.Process.Start("https://youtube.com/playlist?list=PL7W5udALs-AlIByQQ8KnleHQdKq_9m0vD");
        }

        private void btn_rcs_photoshop_course_Click(object sender, EventArgs e)
        {


            System.Diagnostics.Process.Start("https://youtube.com/playlist?list=PLjFxTzTNAMaMsqaenf6iI03ibw2q_7yAQ");
        }

        private void btn_rcs_graphic_course_Click(object sender, EventArgs e)
        {
           
            
            System.Diagnostics.Process.Start("https://youtube.com/playlist?list=PLYfCBK8IplO4E2sXtdKMVpKJZRBEoMvpn");
        }
    }
}
