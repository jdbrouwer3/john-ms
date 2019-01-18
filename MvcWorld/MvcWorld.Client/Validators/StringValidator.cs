using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MvcWorld.Client.Validators
{
    public class StringValidator : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var s = (string)value;
            var r = new Regex("[a-zA-Z]+");

            if (!(r.Match(s).Length == s.Length))
            {
                return false;
            }
            return true;
        }
    }
}
