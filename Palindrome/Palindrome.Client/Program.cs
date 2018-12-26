using System;
using Palindrome.Library.Model;

namespace Palindrome.Client
{
    public class Program
    {
        static void Main(string[] args)
        {
            PlayWithPalindrome()
        }

        static void PlayWithPalindrome()
        {
            var c1 = "racecar";
            char[] c2 = c1.ToCharArray();
            Array.Reverse(c2);
            var c3 = new string(c2);

        }
    }
}
