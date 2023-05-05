using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Async
{
    internal class Program
    {
        async static private void MyMethodAsync(int count)
        {
            Console.WriteLine("C");
            Console.WriteLine("D");

            await Task.Run(async () =>
            {
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine($"{i}/{count} ...");
                    await Task.Delay(100);
                }
            });

            Console.WriteLine("G");
            Console.WriteLine("H");
        }

        static void Caller()
        {
            Console.WriteLine("A");
            Console.WriteLine("B");

            MyMethodAsync(3);

            Console.WriteLine("E");
            Console.WriteLine("F");
        }

        static void Main(string[] args)
        {
            Caller();

            Console.ReadLine();
        }
    }
}

