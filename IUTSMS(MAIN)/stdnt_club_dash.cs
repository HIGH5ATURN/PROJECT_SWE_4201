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
    public partial class stdnt_club_dash : Form
    {
        public stdnt_club_dash()
        {
            InitializeComponent();

            st_Dashboard uc = new st_Dashboard();

            addUserControl(uc);
        }

        private void hobby_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            new st_login_Form().Show();
            
        }
        void reset_btn_color()
        {
            //dashboard button
            
            gunaGradientTileButton5.BaseColor1 = Color.FromArgb(0, 52, 51);
          
            
            gunaGradientTileButton5.BaseColor2 = Color.FromArgb(0, 75, 73);



            //Iutcs_button

            gunaGradientTileButton6.BaseColor1 = Color.FromArgb(0, 52, 51);
            
            
            gunaGradientTileButton6.BaseColor2 = Color.FromArgb(0, 75, 73);



            //iutps_button
           
            iutps_button.BaseColor1 = Color.FromArgb(0, 52, 51);


            iutps_button.BaseColor2 = Color.FromArgb(0,75,73);




            iutds_button.BaseColor1 = Color.FromArgb(0, 52, 51);


            iutds_button.BaseColor2 = Color.FromArgb(0, 75, 73);




            iutsiks_Button.BaseColor1 = Color.FromArgb(0, 52, 51);


            iutsiks_Button.BaseColor2 = Color.FromArgb(0, 75, 73);


        }
        private void stdnt_club_dash_Load(object sender, EventArgs e)
        {
            reset_btn_color();

            WinAPI.AnimateWindow(this.Handle, 500, WinAPI.BLEND);



        }





        //to move the form>
        private bool dragg = false;
        private Point StartPoint = new Point(0, 0);

        private void stdnt_club_dash_MouseDown(object sender, MouseEventArgs e)
        {
            dragg = true;
            StartPoint = new Point(e.X, e.Y);

        }

        private void stdnt_club_dash_MouseUp(object sender, MouseEventArgs e)
        {
            dragg = false;
        }

        private void stdnt_club_dash_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragg)
            {

                Point p = PointToScreen(e.Location);

                Location = new Point(p.X - this.StartPoint.X, p.Y - this.StartPoint.Y);

            }
        }
        //to move the form<
        //arranging the code to jump from one uc to another dependent UC

        

        static stdnt_club_dash _obj;
        public static stdnt_club_dash Instance
        {
            get
            {
                if(_obj == null)
                {
                    _obj = new stdnt_club_dash();
                }
                return _obj;
            }
        }

        public Panel PnlContainer
        {
            get
            {
                return container_panel;
            }
            set
            {
                container_panel = value;
            }
        }

        // to traverse through user controlss>
        public void addUserControl(UserControl userControl)
        {
            userControl.Dock= DockStyle.Fill;
           // container_panel.Controls.Clear();
            container_panel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void gunaGradientTileButton5_Click(object sender, EventArgs e)
        {

            reset_btn_color();

            gunaGradientTileButton5.BaseColor1 = Color.FromArgb(0, 75, 73);


            gunaGradientTileButton5.BaseColor2 = Color.FromArgb(0, 52, 51);



            



            _obj = this;
            st_Dashboard uc = new st_Dashboard();

           
            uc.Dock = DockStyle.Fill;   

            container_panel.Controls.Add(uc);

            uc.BringToFront();
            
        }
        //adding db--->
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OleDb.16.0; Data Source = dbst.accdb");

        OleDbCommand cmd = new OleDbCommand();

        // OleDbDataAdapter da = new OleDbDataAdapter();

        private void gunaGradientTileButton6_Click(object sender, EventArgs e)
        {
            reset_btn_color();


            
          gunaGradientTileButton6.BaseColor1 = Color.FromArgb(0, 75, 73);


          gunaGradientTileButton6.BaseColor2 = Color.FromArgb(0, 52, 51);






            bool flag = false;
            //first we will check for two viable options, 1) if the stdnt is already a member, or 2) he isnt yet member
           /*
            try
            {
                conn.Open();


                string t = "SELECT * FROM cs_table where st_id ="+st_login_Form.id+"";

                cmd = new OleDbCommand(t, conn);
                OleDbDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    flag = true;
                }

                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/


            for(int i=0;i<IUTCS.arr_cs_students.Count;i++)
            {
                if (IUTCS.arr_cs_students[i].id == Convert.ToInt32(st_login_Form.id))
                {
                    flag= true;
                    break;
                }
            }
            _obj = this;

            //if he isnt a member yet(option 2) >
            if (!flag)
            {
                UC_reg_cs uc_reg_cs = new UC_reg_cs();

                uc_reg_cs.Dock = DockStyle.Fill;

                container_panel.Controls.Add(uc_reg_cs);

                uc_reg_cs.BringToFront();
            }
            else
            {
               UC_iutcs_st_page uc_st_cs = new UC_iutcs_st_page();

                uc_st_cs.Dock = DockStyle.Fill;

                container_panel.Controls.Add(uc_st_cs);

                uc_st_cs.BringToFront();
            }
            //if he isnt a member yet(option 2)<

            //else another user control, main user control will open
        }

        private void iutds_button_Click(object sender, EventArgs e)
        {
            reset_btn_color();
            
           iutds_button.BaseColor1 = Color.FromArgb(0, 75, 73);


           iutds_button.BaseColor2 = Color.FromArgb(0, 52, 51);



            bool flag = false;

            for(int i=0;i<IUTDS.arr_ds_students.Count;i++)
            {
                if (IUTDS.arr_ds_students[i].id==Convert.ToInt32(st_login_Form.id))
                {

                    flag= true; 
                    
                    break;


                }
            }
            _obj = this;

            if (!flag)
            {
                UC_reg_ds uc_reg_ds = new UC_reg_ds();

                uc_reg_ds.Dock = DockStyle.Fill;

                container_panel.Controls.Add(uc_reg_ds);

                uc_reg_ds.BringToFront();
            }

            else
            {
                UC_iutds_st_page uc_st_ds = new UC_iutds_st_page();

                uc_st_ds.Dock = DockStyle.Fill;

                container_panel.Controls.Add(uc_st_ds);

                uc_st_ds.BringToFront();
            }
        }

        private void iutps_button_Click(object sender, EventArgs e)
        {
            reset_btn_color();

            
           iutps_button.BaseColor1 = Color.FromArgb(0, 75, 73);


           iutps_button.BaseColor2 = Color.FromArgb(0, 52, 51);




            bool flag = false;

            for (int i = 0; i < IUTPS.arr_ps_students.Count; i++)
            {
                if (IUTPS.arr_ps_students[i].id == Convert.ToInt32(st_login_Form.id))
                {

                    flag = true;

                    break;


                }
            }
            _obj = this;
            if (!flag)
            {
                UC_reg_ps uc_reg_ps = new UC_reg_ps();

                uc_reg_ps.Dock = DockStyle.Fill;

                container_panel.Controls.Add(uc_reg_ps);

                uc_reg_ps.BringToFront();
            }
            else
            {
                UC_iutps_st_page uc_st_ps = new UC_iutps_st_page();

                uc_st_ps.Dock = DockStyle.Fill;

                container_panel.Controls.Add(uc_st_ps);

                uc_st_ps.BringToFront();
            }
        }

        private void iutsiks_Button_Click(object sender, EventArgs e)
        {
            reset_btn_color();

            
           iutsiks_Button.BaseColor1 = Color.FromArgb(0, 75, 73);


           iutsiks_Button.BaseColor2 = Color.FromArgb(0, 52, 51);






            bool flag = false;

            for (int i = 0; i < IUTSIKS.arr_siks_students.Count; i++)
            {
                if (IUTSIKS.arr_siks_students[i].id == Convert.ToInt32(st_login_Form.id))
                {

                    flag = true;

                    break;


                }
            }

            _obj = this;
            if (!flag)
            {
                UC_reg_siks uc_reg_siks = new UC_reg_siks();

                uc_reg_siks.Dock = DockStyle.Fill;

                container_panel.Controls.Add(uc_reg_siks);

                uc_reg_siks.BringToFront();
            }

            else
            {
                UC_iutsiks_st_page uc_st_siks = new UC_iutsiks_st_page();

                uc_st_siks.Dock = DockStyle.Fill;

                container_panel.Controls.Add(uc_st_siks);

                uc_st_siks.BringToFront();
            }
        }

        // to traverse through user controlss<
    }
}
