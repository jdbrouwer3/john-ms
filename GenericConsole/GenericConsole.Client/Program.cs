using System;
using GenericConsole.Library.Models;

namespace GenericConsole.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var g = new GenericModel<string>();
            var h = new GenericModel<int>();
            g.Hello();
            h.Hello();
        }
    }
} 
