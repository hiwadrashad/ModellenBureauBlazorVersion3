using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Data.Models
{
    public class EventModel
    {
        [Key]
        public string id { get; set; } = Guid.NewGuid().ToString();
        public bool Public { get; set; }
        [Display(Name = "Female models")]
        public List<FemaleModelModel> FemaleModels { get; set; } = new List<FemaleModelModel>();
        [Display(Name = "Male models")]
        public List<MaleModeModel> MaleModels { get; set; } = new List<MaleModeModel>();
        public ClientModel Organizer { get; set; } = new ClientModel();

    }
}
