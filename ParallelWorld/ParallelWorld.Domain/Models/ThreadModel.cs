using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ParallelWorld.Domain.Models
{
    public class ThreadModel
    {
        public string ThreadMaster(string s)
        {


            var t1 = new Thread(() =>
            {
                Console.WriteLine("hello");
            });

            var t2 = new Thread(() =>
            {
                Writer('B', 5);
            });

            Console.WriteLine("fred");



            t1.Start();
            t2.Start();

            Thread.Sleep(4000);

            return s;
        }

        private void Writer(string c, int count)
        {
            for(int i = 0; i < count; i++)
            {
                Console.Write(c);
            }
        }
    }
}
