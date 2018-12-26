using System;
using System.Collections.Generic;
using System.Text;

namespace GenericConsole.Library.Models
{
    public class Associate
    {
        public static People<Peep> Associates { get; set; }

        public Associate()
        {
            Associates.Peoples.Add(new Peep("associate"));
        }
    }
}
