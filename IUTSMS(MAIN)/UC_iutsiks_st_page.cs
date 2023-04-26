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
    public partial class UC_iutsiks_st_page : UserControl
    {
        public UC_iutsiks_st_page()
        {
            InitializeComponent();
        }

        private void Quran_Button_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://quran.com/en");
        }

        private void Hadith_Button_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://sunnah.com/");
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void zakah_calculate_button_Click(object sender, EventArgs e)
        {
            try
            {
                int balance = Convert.ToInt32(zakah_bank_balance_textbox.Text);
                int investment = Convert.ToInt32(zakah_investment_text_box.Text);
                int loan = Convert.ToInt32(zakah_loan_amount_textbox.Text);
                int payable = Convert.ToInt32(zakah_payable_textbox.Text);
                int net = balance + investment + loan - payable;

                double zakah = net * 0.025;
                if (net < 100000)
                {
                    throw new Exception("Your Nisab is not enough to provide Zakah.");
                }
                else
                {
                    zakah_net_amount_textbox.Text = Convert.ToString(net);
                    zakah_net_zakah_textbox.Text = Convert.ToString(zakah);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void zakah_clear_button_Click(object sender, EventArgs e)
        {
            zakah_bank_balance_textbox.Clear();
            zakah_investment_text_box.Clear();
            zakah_loan_amount_textbox.Clear();
            zakah_payable_textbox.Clear();
            zakah_payable_textbox.Clear();
            zakah_net_amount_textbox.Clear();
            zakah_net_zakah_textbox.Clear();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void fb_button_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/iutsiks");

        }
        //adding the database-->
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OleDb.16.0; Data Source =dbst.accdb");

        OleDbCommand cmd = new OleDbCommand();

        OleDbDataAdapter adapter = new OleDbDataAdapter();
        DataTable dt;
        void GetNotices()
        {
            conn = new OleDbConnection("Provider=Microsoft.ACE.OleDb.16.0; Data Source =dbst.accdb");

            dt = new DataTable();

            adapter = new OleDbDataAdapter("SELECT * FROM siks_notice", conn);

            conn.Open();
            adapter.Fill(dt);
            dgwNotices.DataSource = dt;
            conn.Close();
        }

        private void UC_iutsiks_st_page_Load(object sender, EventArgs e)
        {
            GetNotices();
        }
    }
}
