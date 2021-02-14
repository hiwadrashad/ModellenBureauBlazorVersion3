using Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logic.StaticResources
{
    public static class GeneralStaticdata
    {
        public static bool loggedin { get; set; }
        public static bool shownavmenu { get; set; }
        public static MaleModeModel currentmalemodel { get; set; }
        public static FemaleModelModel currentfemalemodel {get;set;}
        public static ClientModel currentclientmodel { get; set; }
        public static AdminModel currentadminmodel { get; set; }

    }
}
