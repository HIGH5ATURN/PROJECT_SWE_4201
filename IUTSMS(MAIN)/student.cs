using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IUTSMS_MAIN_
{
    public class student
    {
        public string name { get; set; }

        public string department { get; set; }

        public int id { get; set; }

        public student(string name, string department, int id) 
        {
            this.name =name;
            this.department =department;
            this.id = id;
        }

    }

    public class cs_student : student
    {
        public string java { get;set; }

        public string cp { get;set; }

        public string webdev { get;set; }

        public cs_student(string name, string department, int id, string java, string cp, string webdev) : base( name, department, id )
        {
            this.name=name;
            this.department=department;
            this.id=id;
            this.java = java;
            this.cp = cp;
            this.webdev = webdev;
        }
    }





    public class siks_student : student
    {
        public siks_student(string name,string department,int id) :base(name,department,id)
        {
            this.name = name;

            this.department = department;

            this.id = id;
        }
    }





    public class ps_student : student
    {
        public string cam { get; set; }
        
        public string adobe { get; set; }

        public string graph { get; set; }


        public ps_student(string name, string department, int id,string cam,string adobe,string graph):base(name,department,id)
        {
            this.name = name;

            this.department = department;

            this.id = id;

            this.cam = cam;

            this.adobe = adobe;

            this.graph = graph;
        }


    }





    public class ds_student : student
    {

        public ds_student(string name,string department,int id):base(name,department,id)
        {

            this.name = name;

            this.department = department;

            this.id = id;
        }

    }



}
