using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Microsoft.VisualBasic.ApplicationServices;
using System.Data.OleDb;

namespace IUTSMS_MAIN_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static List<student> arr_students = new List<student>();//total st in system

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OleDb.16.0; Data Source = dbst.accdb");

        OleDbCommand cmd = new OleDbCommand();

       // OleDbDataAdapter da = new OleDbDataAdapter();


        private void Form1_Load(object sender, EventArgs e)
        {

            WinAPI.AnimateWindow(this.Handle, 500, WinAPI.BLEND);
            
            fill_regst_list();


            // Showing association:

            IUTCS cs= new IUTCS();
            
            cs.fill_arr();

            IUTPS ps = new IUTPS();

            ps.fill_arr();

            IUTDS ds = new IUTDS();

            ds.fill_arr();

            IUTSIKS siks = new IUTSIKS();

            siks.fill_arr();

        }


        public void fill_regst_list()
        {

            conn.Close();

            arr_students.Clear();
            try
            {


                conn.Open();


                string t = "Select * from st_info";

                cmd = new OleDbCommand(t, conn);
                OleDbDataReader dr;

                dr = cmd.ExecuteReader();
                while (dr.Read())
                {


                    student st = new student(dr["naam"].ToString(), dr["dept"].ToString(), Convert.ToInt32(dr["st_id"].ToString()));
                    
                    arr_students.Add(st);

                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }





        //to move form_1 using mouse this code is necessary
        private bool dragging =false;
        private Point startPoint = new Point(0,0);

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging= true;
            startPoint= new Point(e.X,e.Y);

        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging= false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if(dragging)
            {

                Point p = PointToScreen(e.Location);

                Location = new Point(p.X-this.startPoint.X,p.Y-this.startPoint.Y);

            }
        }
        //to move form_1 using mouse this code is necessary

        //shifting to admin form
        Thread th; 
        public void openform_admin(object obj)
        {
            Application.Run(new Admin_Form());
        }
        private void SORA_Admin_button_Click(object sender, EventArgs e)
        {
            th = new Thread(openform_admin);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            this.Close();
        }


        public void openform_student(object obj)
        {
            Application.Run(new Student_Form());
        }
        private void SORA_Student_button_Click(object sender, EventArgs e)
        {
            th = new Thread(openform_student);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            this.Close();
        }

        private void form1_logo_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
