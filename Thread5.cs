using System;
using System.Threading;

namespace batch34_day18
{
    class Thread5
    {
        static void myfun1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("myfun 1 ");
                //Thread.Sleep(200);
            }
        }
        static void myfun2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("myfun 2 ");
               // Thread.Sleep(100);
            }
        }
        static void Main(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(Thread5.myfun1));
            t1.Start();


            Thread t2 = new Thread(new ThreadStart(Thread5.myfun2));
            t2.Start();

            t2.Join();
            Console.WriteLine("thread 2 completed");
            t1.Join();
            Console.WriteLine("thread 1 completed");

        }
    }
}
