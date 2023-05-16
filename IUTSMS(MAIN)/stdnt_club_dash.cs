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
            panel1.BackColor = Color.FromArgb(0, 52, 51);
            
            gunaGradientTileButton5.BaseColor1 = Color.FromArgb(0, 52, 51);
          
            
            gunaGradientTileButton5.BaseColor2 = Color.FromArgb(0, 52, 51);

            gunaGradientTileButton5.ForeColor = Color.FromArgb(240, 240, 240);

            gunaGradientTileButton5.OnHoverBaseColor1 = Color.FromArgb(0, 52, 51);


            gunaGradientTileButton5.OnHoverBaseColor2 = Color.FromArgb(0, 75, 73);

            //Iutcs_button

            gunaGradientTileButton6.BaseColor1 = Color.FromArgb(0, 52, 51);
            
            
            gunaGradientTileButton6.BaseColor2 = Color.FromArgb(0, 52, 51);

            gunaGradientTileButton6.ForeColor = Color.FromArgb(240, 240, 240);


            gunaGradientTileButton6.OnHoverBaseColor1 = Color.FromArgb(0, 52, 51);


            gunaGradientTileButton6.OnHoverBaseColor2 = Color.FromArgb(0, 75, 73);


            //iutps_button

            iutps_button.BaseColor1 = Color.FromArgb(0, 52, 51);


            iutps_button.BaseColor2 = Color.FromArgb(0, 52, 51);


            iutps_button.ForeColor = Color.FromArgb(240, 240, 240);


            iutps_button.OnHoverBaseColor1 = Color.FromArgb(0, 52, 51);


            iutps_button.OnHoverBaseColor2 = Color.FromArgb(0, 75, 73);


            //ds

            iutds_button.BaseColor1 = Color.FromArgb(0, 52, 51);


            iutds_button.BaseColor2 = Color.FromArgb(0, 52, 51);


            iutds_button.ForeColor = Color.FromArgb(240, 240, 240);

            iutds_button.OnHoverBaseColor1 = Color.FromArgb(0, 52, 51);


            iutds_button.OnHoverBaseColor2 = Color.FromArgb(0, 75, 73);

            //siks

            iutsiks_Button.BaseColor1 = Color.FromArgb(0, 52, 51);


            iutsiks_Button.BaseColor2 = Color.FromArgb(0, 52, 51);

            iutsiks_Button.ForeColor = Color.FromArgb(240, 240, 240);

            iutsiks_Button.OnHoverBaseColor1 = Color.FromArgb(0, 52, 51);


            iutsiks_Button.OnHoverBaseColor2 = Color.FromArgb(0, 75, 73);
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

        void ds_theme()
        {
            panel1.BackColor = Color.FromArgb(94, 84, 82);





            //dashboard button

            gunaGradientTileButton5.BaseColor1 = Color.FromArgb(94, 84, 82);


            gunaGradientTileButton5.BaseColor2 = Color.FromArgb(94, 84, 82);

            gunaGradientTileButton5.ForeColor = Color.Black;

            gunaGradientTileButton5.OnHoverBaseColor1 = Color.FromArgb(60, 29, 18);

            gunaGradientTileButton5.OnHoverBaseColor2 = Color.FromArgb(60, 29, 18);

            gunaGradientTileButton5.OnHoverForeColor = Color.FromArgb(240,240,240);

            //Iutcs_button

            gunaGradientTileButton6.BaseColor1 = Color.FromArgb(94, 84, 82);


            gunaGradientTileButton6.BaseColor2 = Color.FromArgb(94, 84, 82);

            
            gunaGradientTileButton6.ForeColor = Color.Black;

            gunaGradientTileButton6.OnHoverBaseColor1 = Color.FromArgb(60, 29, 18);

            gunaGradientTileButton6.OnHoverBaseColor2 = Color.FromArgb(60, 29, 18);

            gunaGradientTileButton6.OnHoverForeColor = Color.FromArgb(240, 240, 240);

            //iutps_button

            iutps_button.BaseColor1 = Color.FromArgb(94, 84, 82);


            iutps_button.BaseColor2 = Color.FromArgb(94, 84, 82);


            iutps_button.ForeColor = Color.Black;

            iutps_button.OnHoverBaseColor1 = Color.FromArgb(60, 29, 18);

            iutps_button.OnHoverBaseColor2 = Color.FromArgb(60, 29, 18);

            iutps_button.OnHoverForeColor = Color.FromArgb(240, 240, 240);
            


            //iutds
            iutds_button.BaseColor1 = Color.FromArgb(94, 84, 82);


            iutds_button.BaseColor2 = Color.FromArgb(94, 84, 82);

            iutds_button.ForeColor = Color.Black;

            iutds_button.OnHoverBaseColor1 = Color.FromArgb(60, 29, 18);

            iutds_button.OnHoverBaseColor2 = Color.FromArgb(60, 29, 18);

            iutds_button.OnHoverForeColor = Color.FromArgb(240, 240, 240);


            //iutsiks
            iutsiks_Button.BaseColor1 = Color.FromArgb(94, 84, 82);


            iutsiks_Button.BaseColor2 = Color.FromArgb(94, 84, 82);


            iutsiks_Button.ForeColor = Color.Black;

            iutsiks_Button.OnHoverBaseColor1 = Color.FromArgb(60, 29, 18);

            iutsiks_Button.OnHoverBaseColor2 = Color.FromArgb(60, 29, 18);

            iutsiks_Button.OnHoverForeColor = Color.FromArgb(240, 240, 240);
        }

        void cs_theme()
        {
           

            panel1.BackColor = Color.FromArgb(4, 8, 11);






            //dashboard button

            gunaGradientTileButton5.BaseColor1 = Color.FromArgb(4, 8, 11);


            gunaGradientTileButton5.BaseColor2 = Color.FromArgb(4, 8, 11);


            gunaGradientTileButton5.ForeColor = Color.FromArgb(252, 3, 4);


            gunaGradientTileButton5.OnHoverBaseColor1 = Color.FromArgb(202, 235, 218);

            gunaGradientTileButton5.OnHoverBaseColor2 = Color.FromArgb(202, 235, 218);

            gunaGradientTileButton5.OnHoverForeColor = Color.Black;


            //Iutcs_button

            gunaGradientTileButton6.BaseColor1 = Color.FromArgb(4, 8, 11);


            gunaGradientTileButton6.BaseColor2 = Color.FromArgb(4, 8, 11);



            gunaGradientTileButton6.ForeColor = Color.FromArgb(252, 3, 4);

            gunaGradientTileButton6.OnHoverBaseColor1 = Color.FromArgb(202, 235, 218);

            gunaGradientTileButton6.OnHoverBaseColor2 = Color.FromArgb(202, 235, 218);

            gunaGradientTileButton6.OnHoverForeColor = Color.Black;
            //iutps_button

            iutps_button.BaseColor1 = Color.FromArgb(4, 8, 11);

           
            iutps_button.BaseColor2 = Color.FromArgb(4, 8, 11);
            
            iutps_button.ForeColor = Color.FromArgb(252, 3, 4);


            iutps_button.OnHoverBaseColor1 = Color.FromArgb(202, 235, 218);
           
            iutps_button.OnHoverBaseColor2 = Color.FromArgb(202, 235, 218);

            iutps_button.OnHoverForeColor = Color.Black;



            //ds
            iutds_button.BaseColor1 = Color.FromArgb(4, 8, 11);


            iutds_button.BaseColor2 = Color.FromArgb(4, 8, 11);


            iutds_button.ForeColor = Color.FromArgb(252, 3, 4);

            iutds_button.OnHoverBaseColor1 = Color.FromArgb(202, 235, 218);

            iutds_button.OnHoverBaseColor2 = Color.FromArgb(202, 235, 218);

            iutds_button.OnHoverForeColor = Color.Black;


            //siks
            iutsiks_Button.BaseColor1 = Color.FromArgb(4, 8, 11);


            iutsiks_Button.BaseColor2 = Color.FromArgb(4, 8, 11);

            iutsiks_Button.ForeColor = Color.FromArgb(252, 3, 4);

            iutsiks_Button.OnHoverBaseColor1 = Color.FromArgb(202, 235, 218);

            iutsiks_Button.OnHoverBaseColor2 = Color.FromArgb(202, 235, 218);

            iutsiks_Button.OnHoverForeColor = Color.Black;
        }


        void ps_theme()
        {
            panel1.BackColor = Color.FromArgb(18, 16, 42);





            //dashboard button

            gunaGradientTileButton5.BaseColor1 = Color.FromArgb(18, 16, 42);


            gunaGradientTileButton5.BaseColor2 = Color.FromArgb(18, 16, 42);

            gunaGradientTileButton5.ForeColor = Color.FromArgb(131, 192, 68);

            gunaGradientTileButton5.OnHoverBaseColor1 = Color.FromArgb(131, 192, 68);

            gunaGradientTileButton5.OnHoverBaseColor2 = Color.FromArgb(18, 16, 42);

            gunaGradientTileButton5.OnHoverForeColor = Color.FromArgb(240, 240, 240);

            //Iutcs_button

            gunaGradientTileButton6.BaseColor1 = Color.FromArgb(18, 16, 42);


            gunaGradientTileButton6.BaseColor2 = Color.FromArgb(18, 16, 42);


            gunaGradientTileButton6.ForeColor = Color.FromArgb(131, 192, 68);


            gunaGradientTileButton6.OnHoverBaseColor1 = Color.FromArgb(131, 192, 68);

            gunaGradientTileButton6.OnHoverBaseColor2 = Color.FromArgb(18, 16, 42);

            gunaGradientTileButton6.OnHoverForeColor = Color.FromArgb(240, 240, 240);


            //iutps_button

            iutps_button.BaseColor1 = Color.FromArgb(18, 16, 42);

                
            iutps_button.BaseColor2 = Color.FromArgb(18, 16, 42);


            iutps_button.ForeColor = Color.FromArgb(131, 192, 68);


            iutps_button.OnHoverBaseColor1 = Color.FromArgb(131, 192, 68);

            iutps_button.OnHoverBaseColor2 = Color.FromArgb(18, 16, 42);

            iutps_button.OnHoverForeColor = Color.FromArgb(240, 240, 240);


            //iutds
            iutds_button.BaseColor1 = Color.FromArgb(18, 16, 42);


            iutds_button.BaseColor2 = Color.FromArgb(18, 16, 42);

            iutds_button.ForeColor = Color.FromArgb(131, 192, 68);


            iutds_button.OnHoverBaseColor1 = Color.FromArgb(131, 192, 68);

            iutds_button.OnHoverBaseColor2 = Color.FromArgb(18, 16, 42);

            iutds_button.OnHoverForeColor = Color.FromArgb(240, 240, 240);



            //iutsiks
            iutsiks_Button.BaseColor1 = Color.FromArgb(18, 16, 42);


            iutsiks_Button.BaseColor2 = Color.FromArgb(18, 16, 42);


            iutsiks_Button.ForeColor = Color.FromArgb(131, 192, 68);


            iutsiks_Button.OnHoverBaseColor1 = Color.FromArgb(131, 192, 68);

            iutsiks_Button.OnHoverBaseColor2 = Color.FromArgb(18, 16, 42);

            iutsiks_Button.OnHoverForeColor = Color.FromArgb(240, 240, 240);



        }

        void siks_theme()
        {


            panel1.BackColor = Color.FromArgb(46, 52, 54);





            //dashboard button

            gunaGradientTileButton5.BaseColor1 = Color.FromArgb(46, 52, 54);


            gunaGradientTileButton5.BaseColor2 = Color.FromArgb(46, 52, 54);

            gunaGradientTileButton5.ForeColor = Color.FromArgb(115, 196, 141);

            gunaGradientTileButton5.OnHoverBaseColor1 = Color.FromArgb(115, 196, 141);

            gunaGradientTileButton5.OnHoverBaseColor2 = Color.FromArgb(115, 196, 141);

            gunaGradientTileButton5.OnHoverForeColor = Color.FromArgb(240,240,240);

            //Iutcs_button

            gunaGradientTileButton6.BaseColor1 = Color.FromArgb(46, 52, 54);


            gunaGradientTileButton6.BaseColor2 = Color.FromArgb(46, 52, 54);


            gunaGradientTileButton6.ForeColor = Color.FromArgb(115, 196, 141);

            gunaGradientTileButton6.OnHoverBaseColor1 = Color.FromArgb(115, 196, 141);

            gunaGradientTileButton6.OnHoverBaseColor2 = Color.FromArgb(115, 196, 141);

            gunaGradientTileButton6.OnHoverForeColor = Color.FromArgb(240, 240, 240);


            //iutps_button

            iutps_button.BaseColor1 = Color.FromArgb(46, 52, 54);


            iutps_button.BaseColor2 = Color.FromArgb(46, 52, 54);


            iutps_button.ForeColor = Color.FromArgb(115, 196, 141);

            iutps_button.OnHoverBaseColor1 = Color.FromArgb(115, 196, 141);

            iutps_button.OnHoverBaseColor2 = Color.FromArgb(115, 196, 141);

            iutps_button.OnHoverForeColor = Color.FromArgb(240, 240, 240);


            //iutds
            iutds_button.BaseColor1 = Color.FromArgb(46, 52, 54);


            iutds_button.BaseColor2 = Color.FromArgb(46, 52, 54);

            iutds_button.ForeColor = Color.FromArgb(115, 196, 141);

            iutds_button.OnHoverBaseColor1 = Color.FromArgb(115, 196, 141);

            iutds_button.OnHoverBaseColor2 = Color.FromArgb(115, 196, 141);

            iutds_button.OnHoverForeColor = Color.FromArgb(240, 240, 240);



            //iutsiks
            iutsiks_Button.BaseColor1 = Color.FromArgb(46, 52, 54);


            iutsiks_Button.BaseColor2 = Color.FromArgb(46, 52, 54);


            iutsiks_Button.ForeColor = Color.FromArgb(115, 196, 141);

            iutsiks_Button.OnHoverBaseColor1 = Color.FromArgb(115, 196, 141);

            iutsiks_Button.OnHoverBaseColor2 = Color.FromArgb(115, 196, 141);

            iutsiks_Button.OnHoverForeColor = Color.FromArgb(240, 240, 240);


        }

        private void gunaGradientTileButton6_Click(object sender, EventArgs e)
        {




            cs_theme();





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
            
            ds_theme();


 


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
          
            ps_theme();






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
            siks_theme();


           


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
