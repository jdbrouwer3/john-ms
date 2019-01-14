using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcWorld.Client.Models
{
    public class Invite
    {
        public bool Rsvp { get; set; }

        public string Name { get; set; }

        public void AreYouComing()
        {
            var r = new Random();
            Rsvp = r.Next(0, 2) == 1;
        }
    }
}
