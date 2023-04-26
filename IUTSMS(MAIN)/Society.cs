using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IUTSMS_MAIN_
{
    
    public abstract class Society
    {


    }

    public class IUTCS : Society
    {
        public static List<cs_student> arr_cs_students = new List<cs_student>();//aggregation

        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OleDb.16.0; Data Source = dbst.accdb");

        OleDbCommand cmd = new OleDbCommand();

        public void fill_cs_arr()
        {
            arr_cs_students.Clear();
            //New comment

            try
            {


                conn.Open();


                string t = "Select * from cs_table";

                cmd = new OleDbCommand(t, conn);
                OleDbDataReader dr;

                dr = cmd.ExecuteReader();
                while (dr.Read())
                {


                    cs_student st = new cs_student(dr["naam"].ToString(), dr["dept"].ToString(), Convert.ToInt32(dr["st_id"].ToString()), dr["java"].ToString().ToLower(), dr["cp"].ToString().ToLower(), dr["WebDev"].ToString().ToLower());

                    arr_cs_students.Add(st);

                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
    public class IUTDS : Society
    {
        public static List<ds_student> arr_ds_students = new List<ds_student>();



        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OleDb.16.0; Data Source = dbst.accdb");


        OleDbCommand cmd = new OleDbCommand();


        public void fill_ds_arr()
        {
            arr_ds_students.Clear();




            try
            {


                conn.Open();


                string t = "Select * from ds_table";

                cmd = new OleDbCommand(t, conn);
                OleDbDataReader dr;

                dr = cmd.ExecuteReader();
                while (dr.Read())
                {


                    ds_student st = new ds_student(dr["naam"].ToString(), dr["dept"].ToString(), Convert.ToInt32(dr["st_id"].ToString()));
                    arr_ds_students.Add(st);

                }




                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }






        }
    }

    public class IUTPS : Society
    {
        public static List<ps_student> arr_ps_students = new List<ps_student>();



        OleDbConnection conn = new OleDbConnection("\"Provider=Microsoft.ACE.OleDb.16.0; Data Source = dbst.accdb\"");


        OleDbCommand cmd=new OleDbCommand();



        public void fill_ps_arr()
        {
            arr_ps_students.Clear();






            try
            {


                conn.Open();


                string t = "Select * from ps_table";

                cmd = new OleDbCommand(t, conn);
                OleDbDataReader dr;

                dr = cmd.ExecuteReader();
                while (dr.Read())
                {


                    ps_student st = new ps_student(dr["naam"].ToString(), dr["dept"].ToString(), Convert.ToInt32(dr["st_id"].ToString()), dr["cam"].ToString().ToLower(), dr["adobe"].ToString().ToLower(), dr["graph"].ToString().ToLower());



                    arr_ps_students.Add(st);

                }

                conn.Close();
            }



            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



    }
    public class IUTSIKS : Society
    {
        public static List<siks_student> arr_siks_students = new List<siks_student>();




        OleDbConnection conn = new OleDbConnection("\"Provider=Microsoft.ACE.OleDb.16.0; Data Source = dbst.accdb\"");


        OleDbCommand cmd = new OleDbCommand();



        public void fill_siks_arr()
        {
            arr_siks_students.Clear();



            try
            {


                conn.Open();


                string t = "Select * from siks_table";

                cmd = new OleDbCommand(t, conn);
                OleDbDataReader dr;



                dr = cmd.ExecuteReader();
                while (dr.Read())
                {


                    siks_student st = new siks_student(dr["naam"].ToString(), dr["dept"].ToString(), Convert.ToInt32(dr["st_id"].ToString()));



                    arr_siks_students.Add(st);

                }

                conn.Close();
            }



            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }


    }


}
