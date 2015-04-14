using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Counter counter1 = new Counter();
            Thread[] threads = new Thread[5];
            for (int i = 0; i < threads.Length; i++)
            {
                threads[i] = new Thread(new ThreadStart(counter1.Increment));
                threads[i].Name = i + "";
                threads[i].Start();
            }
        }

        class Counter
        {
            private static int count = 0;
            private Object simpleLock = new object();

            public void Increment()
            {
                lock (simpleLock)
                //lock (this)
                {
                    for (int i = 0; i < 100; i++)
                    {
                        Thread.Sleep(new Random().Next(5));
                        count++;
                        Console.WriteLine("Thread {0}: {1} ", Thread.CurrentThread.Name, count);
                    }
                }
            }
        }

    }


}
