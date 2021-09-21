using System;
using System.Threading;

namespace Matrixx
{
    class Program:Matrix
    {
        static void Main(string[] args)
        {
           
            Random random = new Random();
            while (true)
            {
                var Thread = new Thread(
                  () => ThreadMethod(new string(' ', random.Next(5, 60)), random.Next(10, 100)));
                Thread.Start();
                Thread.Sleep(500);
            }
        }
    }
}
