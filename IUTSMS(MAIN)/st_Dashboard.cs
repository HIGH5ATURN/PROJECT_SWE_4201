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
    public partial class st_Dashboard : UserControl
    {
        public st_Dashboard()
        {
            InitializeComponent();
        }
        //now adding databse--->

        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OleDb.16.0; Data Source =dbst.accdb");

        OleDbCommand cmd = new OleDbCommand();

        OleDbDataAdapter da = new OleDbDataAdapter();

        private void st_Dashboard_Load(object sender, EventArgs e)
        {
            WinAPI.AnimateWindow(this.Handle, 500, WinAPI.BLEND);

            try
            {


                conn.Open();


                string t = "Select * from st_info where st_id=" + st_login_Form.id + "";

                cmd = new OleDbCommand(t, conn);
                OleDbDataReader dr;

                dr = cmd.ExecuteReader();


                if (dr.Read())
                {
                    // MessageBox.Show(st_login_Form.id);

                    txt_name.Text = dr["naam"].ToString();

                    txt_id.Text = st_login_Form.id;

                    txt_dept.Text = dr["dept"].ToString();
                }

                //just adding societies in the list box



                joind_club_listBox.Items.Clear();


                for (int i = 0; i < IUTCS.arr_cs_students.Count; i++)
                {
                    if (Convert.ToInt32(st_login_Form.id) == IUTCS.arr_cs_students[i].id)
                    {

                        joind_club_listBox.Items.Add("IUT Computer Society");
                        break;
                    }
                }

                for (int i = 0; i < IUTDS.arr_ds_students.Count; i++)
                {
                    if (Convert.ToInt32(st_login_Form.id) == IUTDS.arr_ds_students[i].id)
                    {

                        joind_club_listBox.Items.Add("IUT Debating Society");
                        break;
                    }
                }
                for (int i = 0; i < IUTPS.arr_ps_students.Count; i++)
                {
                    if (Convert.ToInt32(st_login_Form.id) == IUTPS.arr_ps_students[i].id)
                    {

                        joind_club_listBox.Items.Add("IUT Photographic Society");
                        break;
                    }
                }
                for (int i = 0; i < IUTSIKS.arr_siks_students.Count; i++)
                {
                    if (Convert.ToInt32(st_login_Form.id) == IUTSIKS.arr_siks_students[i].id)
                    {

                        joind_club_listBox.Items.Add("IUT Society For Islamic Knowledge Seekers");
                        break;
                    }
                }






                conn.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        //now the club suggesstion part code>>>>>>(ELITE CODE)
        int cs = 0, ds = 0, ps = 0, siks = 0;

        private void security_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if(security_checkbox.Checked)
            {
                cs++;
            }
            else
            {
                cs--;
            }
        }

        private void robotics_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if(robotics_checkbox.Checked)
            {
                cs++;
            }
            else
            {
                cs--;
            }
        }

        private void public_speaking_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if(public_speaking_checkbox.Checked)
            {
                ds++;
            }
            else
            {
                ds--;
            }
        }

        private void speech_writing_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if(speech_writing_checkBox.Checked)
            {
                ds++;
            }
            else
            {
                ds--;
            }

        }

        private void politics_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (politics_checkBox.Checked)
            {
                ds++;
            }
            else
            {
                ds--;
            }
        }

        private void negotiation_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (negotiation_checkBox.Checked )
            {
                ds++;
            }
            else
            {
                ds--;
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //this checkbox is for critical reasoning
            if ( checkBox1.Checked )
            {
                ds++;
            }
            else
            {
                ds--;
            }

        }

        private void photgraphy_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (photgraphy_checkbox.Checked )
            {
                ps++;
            }
            else
            {
                ps--;
            }
        }

        private void travelling_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (travelling_checkbox.Checked )
            {
                ps++;
            }
            else
            {
                ps--;
            }

        }

        private void creative_eye_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (creative_eye_checkbox.Checked )
            {
                ps++;
            }
            else
            {
                ps--;
            }
        }

        private void nature_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (nature_checkbox.Checked )
            {
                ps++;
            }
            else
            {
                ps--;
            }
        }

        private void photo_editing_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (photo_editing_checkbox.Checked )
            {
                ps++;
            }
            else
            {
                ps--;
            }
        }

        private void Reciting_quran_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if(Reciting_quran_checkbox.Checked )
            {
                siks++;
            }
            else
            {
                siks--;
            }
        }

        private void calligraphy_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (calligraphy_checkbox.Checked )
            {
                siks++;
            }
            else
            {
                siks--;
            }
        }

        private void memorizing_quran_checkbox_CheckedChanged(object sender, EventArgs e)
        {

            if (memorizing_quran_checkbox.Checked )
            {
                siks++;
            }
            else
            {
                siks--;
            }
        }

        private void islamic_discuss_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (islamic_discuss_checkBox.Checked )
            {
                siks++;
            }
            else
            {
                siks--;
            }
        }

        private void islamic_literature_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (islamic_literature_checkbox.Checked )
            {
                siks++;
            }
            else
            {
                siks--;
            }
        }

        private void web_design_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if(web_design_checkbox.Checked)
            {
                cs++;
                //MessageBox.Show(Convert.ToString(cs));
            }
            else
            {
                cs--;
            }
        }

        private void programming_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if(programming_checkbox.Checked)
            {
                cs++;
            }
            else
            {
                cs--;
            }
        }

        private void hobby_button_Click(object sender, EventArgs e)
        {
            show_the_suggestion();
        }

        private void Clear_Button_Click(object sender, EventArgs e)
        {
            dict.Clear();
            club_suggest_listBox.Items.Clear();
            game_devlop_checkbox.Checked = false;
            programming_checkbox.Checked= false;
            web_design_checkbox.Checked = false;
            security_checkbox.Checked = false;
            robotics_checkbox.Checked = false;
            public_speaking_checkbox.Checked = false;
            speech_writing_checkBox.Checked = false;
            politics_checkBox.Checked = false;
            negotiation_checkBox.Checked = false;
            checkBox1.Checked = false;
            Reciting_quran_checkbox.Checked = false;
            islamic_discuss_checkBox.Checked = false;
            calligraphy_checkbox.Checked = false;
            memorizing_quran_checkbox.Checked=false;
            islamic_literature_checkbox.Checked = false;
            photgraphy_checkbox.Checked = false;
            travelling_checkbox.Checked = false;
            creative_eye_checkbox.Checked = false;
            nature_checkbox.Checked = false;
            photo_editing_checkbox.Checked = false;

        }

        private void game_devlop_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if(game_devlop_checkbox.Checked)
            {
                cs++;
            }
            else
            {
                cs--;
            }
        }
        
        public Dictionary<string,int> dict = new Dictionary<string,int>();

        public void show_the_suggestion()
        {
            dict.Clear();
            club_suggest_listBox.Items.Clear();
            if (cs > 0)
            {
                dict.Add("IUTCS", cs);
            }
            if (ps > 0)
            {
                dict.Add("IUTPS", ps);

            }
            if (ds > 0)
            {
                dict.Add("IUTDS", ds);
            }
            if (siks > 0)
            {
                dict.Add("IUTSIKS", siks);
            }
            foreach(KeyValuePair<string,int> kvp in dict.OrderByDescending(key=>key.Value))
            {
                club_suggest_listBox.Items.Add(kvp.Key);
            }


        }
        
      



    }
}
