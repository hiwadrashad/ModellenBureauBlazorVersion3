using Data.Enums.BioMarker;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;


namespace Data.Models
{
    public class BioDataModel
    {
        [Key]
        public string id { get; set; }
        [Display(Name = "Eye color")]
        public EyeColor eyecolor { get; set; }
        [Display(Name = "Hair color")]
        public HairColor haircolor { get; set; }
        public Height height { get; set; }
    }
}
