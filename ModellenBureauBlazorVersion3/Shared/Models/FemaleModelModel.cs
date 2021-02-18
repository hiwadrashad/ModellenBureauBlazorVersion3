using Data.Enums.BioMarker;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Data.Models
{
    public class FemaleModelModel
    {
        [Key]
        public string id { get; set; } = Guid.NewGuid().ToString();
        public NAWDataModel NAWData { get; set; } = new NAWDataModel();
        public FemaleMeasurementsModel Measurements { get; set; } = new FemaleMeasurementsModel();
        public string Password { get; set; }
        [Display(Name = "User name")]
        public string Username { get; set; }
        public IFormFile Image { get; set; }
        public string imagepath { get; set; }
        public bool Invited { get; set; }
        public BioDataModel biodata { get; set; } = new BioDataModel();
        [Display(Name = "Previously attended events")]
        public List<EventModel> previousevents { get; set; } = new List<EventModel>();
        public List<EventModel> invitedevents { get; set; } = new List<EventModel>();
        public Action<object, string> Notifications { get; set; }


    }
}
