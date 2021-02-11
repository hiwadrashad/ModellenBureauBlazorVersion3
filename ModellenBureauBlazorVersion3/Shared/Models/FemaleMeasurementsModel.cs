using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Data.Models
{
    public class FemaleMeasurementsModel
    {
        [Key]
        public string id { get; set; }
        public Enums.Female.BackLength backlength {get;set;}
        public Enums.Female.CutWidth cutwidth { get; set; }
        public Enums.Female.HipWidth hipwidth { get; set; }
        public Enums.Female.SittingHeight sittingheight { get; set; }
        public Enums.Female.SleeveLength sleevelength { get; set; }
        public Enums.Female.UpperArmWidth upperarmwidth { get; set; }
        public Enums.Female.UpperWidth upperwidth { get; set; }



    }
}
