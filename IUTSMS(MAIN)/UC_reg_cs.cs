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
    public partial class UC_reg_cs : UserControl
    {
        public UC_reg_cs()
        {
            InitializeComponent();
            pbar.Value = 0;
        }

        private void UC_reg_cs_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pbar.Value += 1;

            if (pbar.Value == 100)
            {
                //now will add the student in the student list of IUTCS 
                timer1.Stop();
                MessageBox.Show("Congrats! You're now a member of IUTCS");
                
                
                UC_iutcs_st_page uc_st_page = new UC_iutcs_st_page();

                uc_st_page.Dock = DockStyle.Fill;

                stdnt_club_dash.Instance.PnlContainer.Controls.Add(uc_st_page);

                stdnt_club_dash.Instance.PnlContainer.Controls["UC_iutcs_st_page"].BringToFront();


            }
        }


        //adding db-->

        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OleDb.16.0; Data Source = dbst.accdb");

        OleDbCommand cmd = new OleDbCommand();

        // OleDbDataAdapter da = new OleDbDataAdapter();

        void add_in_cs_table(string nme, string idd, string dpp)
        {
            try
            {
                conn.Close();

                conn.Open();


                string t = "INSERT INTO cs_table (naam, st_id ,dept) VALUES" + "(@name,@id,@dp)";

                cmd = new OleDbCommand(t, conn);
                cmd.Parameters.AddWithValue("@name", nme );
                cmd.Parameters.AddWithValue("@id",Convert.ToInt32( idd));
                cmd.Parameters.AddWithValue("@dp", dpp);
                
                cmd.ExecuteNonQuery();
                conn.Close();


                IUTCS cs=new IUTCS();

                cs.fill_cs_arr();


                //MessageBox.Show("Joined in IUTCS_table");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        

       
        private void Join_Button_Click(object sender, EventArgs e)
        {

            try
            {
                conn.Open();


                string t = "Select * from st_info where st_id=" + st_login_Form.id + "";

                cmd = new OleDbCommand(t, conn);
                OleDbDataReader dr;

                dr = cmd.ExecuteReader();


                if (dr.Read())
                {
                    add_in_cs_table(dr["naam"].ToString(), dr["st_id"].ToString() , dr["dept"].ToString());
                }

                conn.Close();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }

            this.timer1.Start();




        }
    }
}
