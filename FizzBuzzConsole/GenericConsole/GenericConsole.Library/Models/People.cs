using System;
using System.Collections.Generic;
using System.Text;

namespace GenericConsole.Library.Models
{
    public class People<T> where T : APerson
    {
        // public List<Client> Clients { get; set; }
        // public List<Associate> Associates { get; set; }
        // public List<Trainer> Trainers { get; set; }
        // public List<Manager> Managers { get; set; }
        // now that we created the List<T> and the seperate classes, we don't need 4 lines above.
        public List<T> Peoples { get; set; }

        public People()
        {
            Peoples = new List<T>();
        }

    }
}
