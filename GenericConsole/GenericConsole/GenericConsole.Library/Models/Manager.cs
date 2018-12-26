using System;
using System.Collections.Generic;
using System.Text;

namespace GenericConsole.Library.Models
{
    public class Manager
    {
        public static People<Peep> Managers { get; set; }

        public Manager()
        {
            Managers.Peoples.Add(new Peep("manager"));
        }
    }
}
