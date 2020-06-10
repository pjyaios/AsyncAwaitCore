using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwaitCore
{
    class Program
    {
        static void Main(string[] args)
        {
            var timer = Stopwatch.StartNew();

            while (true)
            {
                Task.Factory.StartNew(Cal);
            }

            Console.WriteLine($"{timer.ElapsedMilliseconds}s");
        }

        static void Cal()
        {
            var value = 0;

            for (int i = 0; i < 10; i++)
            {
                value += i;
                Thread.Sleep(100);
            }

            Console.WriteLine($"Cal Thread ID is {Thread.CurrentThread.ManagedThreadId}.");
        }
    }
}

// 출처: https://hijuworld.tistory.com/72
