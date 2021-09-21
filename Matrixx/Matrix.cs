using System;
using System.Threading;


namespace Matrixx
{
    class Matrix
    {
        static object locker = new object();

        static string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

        static char GetLetters()
        {
            return letters.ToCharArray()[new Random().Next(letters.Length)];
        }

        static public void ThreadMethod(string indent, int delay)
        {
            for (int i = 0; i < letters.Length ; i++ )
            {
                lock (locker)
                {
                    
                    Console.WriteLine(indent + GetLetters());
                    Thread.Sleep(delay);

                    if (i%2==0)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                    }
                    

                    
                }

            }
        }
    }
}
