using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzzConsole.Library.Models
{
    class FizzBuzzModel
    {
        public void FizzBuzz()
        {
            int FB = 4;
            int F = 2;
            int B = 3;
            int FBCount = 0;
            int FCount = 0;
            int BCount = 0;
            int i = 0;
            for(i = 0; FBCount < 5; i += 1)
            {
                if (i % FB == 0) {
                    FBCount += 1;
                } else if (i % F == 0) {
                    FCount += 1;
                } else if (i % B == 0) {
                    BCount += 1;
                } else
                {
                    i += 1;
                }
            }
        }
    }
}
