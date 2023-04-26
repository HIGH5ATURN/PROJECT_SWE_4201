using System;
using System.Collections.Generic;
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

}
