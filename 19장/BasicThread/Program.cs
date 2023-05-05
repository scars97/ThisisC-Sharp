using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BasicThread
{
    internal class Program
    {
        static void DoSomething()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"DoSomething : {i}");
                // Sleep()메서드를 만나면 인수만큼 CPU 사용 멈춤.
                Thread.Sleep(10);
            }
        }

        static void Main(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(DoSomething));

            Console.WriteLine("Starting thread...");
            t1.Start();

            // 위의 메서드가 실행되는 동시에 메인 스레드 반복문도 실행.
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Main : {i}");
                Thread.Sleep(10);
            }

            Console.WriteLine("Wating until thread stops...");
            t1.Join();

            Console.WriteLine("Finished");
        }
    }
}

