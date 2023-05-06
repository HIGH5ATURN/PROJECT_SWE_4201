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
    public partial class PS_admin : Form
    {
        public PS_admin()
        {
            InitializeComponent();
        }

        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OleDb.16.0; Data Source =dbst.accdb");

        OleDbCommand cmd = new OleDbCommand();

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

        private void PS_admin_Load(object sender, EventArgs e)
        {
            WinAPI.AnimateWindow(this.Handle, 500, WinAPI.BLEND);
            GetNotices();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_publish_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "INSERT INTO ps_notice (notice) VALUES" + "(@ntc)";

                cmd = new OleDbCommand(query, conn);
                cmd.Parameters.AddWithValue("@ntc", txt_notice.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Notice published!");
                GetNotices();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {

                string query = "DELETE FROM ps_notice where ID=@id";

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

        private void dgwNotices_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            txt_notice_no.Text = dgwNotices.CurrentRow.Cells[0].Value.ToString();
        }

        private void admin_back_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Admin_Form().Show();
        }
    }
}
