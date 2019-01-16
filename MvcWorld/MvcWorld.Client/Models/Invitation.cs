using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcWorld.Client.Models
{
    public class Invitation
    {
        [Required] //attributes
        [MaxLength(25, ErrorMessage = "no more than 25 chars")]
        public string Name { get; set; }

        [Range(0,5, ErrorMessage = "no more than 5")]
        public int Guests { get; set; }

        [Display(Name = "GlutenOption")]
        public string Menu { get; set; }

        //[RsvpValidation()]
        public bool Rsvp { get; set; }
        
        public string Message { get; set; }
    }
}
