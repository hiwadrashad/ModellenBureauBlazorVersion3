using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Data.Models
{
    public class ClientModel
    {
        [Key]
        public string id { get; set; } = Guid.NewGuid().ToString();
        public NAWDataModel data { get; set; } = new NAWDataModel();
        [Display(Name = "KVK number")]
        public string KVKNumber { get; set; }
        [Display(Name = "BTW number")]
        public string BTWNumber { get; set; }
        [Display(Name = "User name")]
        public string UserName { get; set; }
        public string Password { get; set; }
        public IFormFile Image {get;set;}
        public string imagepath { get; set; }
        public bool Invited { get; set; }
        public List<EventModel> Events { get; set; } = new List<EventModel>();
        public Action<object,string> Notifications { get; set; }
    }
}
