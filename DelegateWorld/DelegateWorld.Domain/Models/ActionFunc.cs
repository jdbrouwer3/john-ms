﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateWorld.Domain.Models
{
    public class ActionFunc
    {
        Action<string> NameTag = (string name) =>
        {
            Console.WriteLine(name);
        };

        Func<string, string, string> Sharpie = (string first, string last) =>
        {
            return string.Format("{0} {1}", first, last);
        };

        public string Sharpie2(string f, string l)
        {
            //return string.Format("{0} {1}", first, last);
            return Sharpie(f, l);
        }

        public void MyConference()
        {
            NameTag(Sharpie("fred", "belotte"));
        }

        public void MyConference2(Func<string, string, string> sharper, string first, string last)
        {
            NameTag(sharper(first, last));
        }

        public void TheConference()
        {
            MyConference2(Sharpie, "fred", "belotte");
            MyConference2(Sharpie2, "fred", "belotte");

        }
    }
}
