using System;
using System.Collections.Generic;
using System.Text;

namespace VarianceLibrary.Models
{
    public class Casting
    {
        public void Implicit()
        {
            int x = 10;
            long y = x;

            Console.WriteLine(y);
            // an int fits inside a long
        }

        public void Explicit()
        {
            short? x = 10;
            byte y = (byte)x; //throws exception if not able to cast
            Nullable<byte> z = x as Nullable<byte>; //raises a null value if not able to cast

            Console.WriteLine(y);
            //errors w/o explicit bc byte is smaller 
        }

        public IEnumerable<byte?> Explicit(short x)
        {
            byte y = (byte)x;
            byte? z = x as byte?;

            //return y;
            //return z;

            //return new  { y1 = y, z1 = z }; //anonymous object
            return new byte?[]{y, z};
        }

        public void Explicit(short x, out byte y, out byte? z)
        {
            y = (byte)x;
            z = x as byte?;
        }

        public void Explicit(ref short w, ref short x, out byte y, out byte? z)
        {
            x = 100;
            w = x;
            y = (byte)w;
            z = w as byte?; 
        }

        public void Explicit(short w, short x)
        {
            x = 100;
            w = x;
        }

        public void Converting()
        {
            int x = Convert.ToInt16(true);
            bool y = Convert.ToBoolean(x); //as long as not 0,  will return true
            int z = Convert.ToInt32("banana");
        }

        public int? ConvertingInt(string s)
        {
            try
            {
                return Convert.ToInt32(s);
            }
            catch (System.Exception)
            {
                return null;
            }
        }
    }
}
