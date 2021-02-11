using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Data.Models
{
    public class MaleMeasurementsModel
    {
        [Key]
        public string id { get; set; }

        public Enums.Male.BackLength backlength { get; set; }
        public Enums.Male.CutWidth cutwidth { get; set; }
        public Enums.Male.HipWidth hipwidth { get; set; }
        public Enums.Male.UpperWidth upperwidth { get; set; }

    }
}
