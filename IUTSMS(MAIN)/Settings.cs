using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IUTSMS_MAIN_
{
    internal class Settings
    {



        public static int height { get; set; } 



        public static int width { get; set; }




        public static string direction;






        public Settings()
        {


            height = 16;




            width = 16;



            direction = "left";
        }

    }
}
