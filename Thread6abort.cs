using System;
using System.Threading;

namespace batch34_day18
{
    class DemoThread
    {
        public Thread t;

        public DemoThread(string name)
        {
            t = new Thread(this.RunThread);
            t.Name = name;
            t.Start();
        }
        void RunThread()
        {
            try
            {
                Console.WriteLine("starting : "+ t.Name );
                for(int i=1;i<=80;i++)
                {
                    if(i%5 == 0)
                    {
                        Console.WriteLine();
                        Thread.Sleep(300);
                    }
                    Console.Write(i +"\t");
                }
                Console.WriteLine("Exiting : " + t.Name);
            }
            catch(ThreadAbortException e)
            {
                Console.WriteLine("Thread abort " + e.ExceptionState);
            }
        }
    }
    class Thread6abort
    {
        static void Main(string[] args)
        {
            DemoThread ob = new DemoThread("mythread");
            Thread.Sleep(2000);

            Console.WriteLine(ob.t.IsAlive);
            Console.WriteLine("stop the thread created");
            ob.t.Abort(200);
            ob.t.Join();
            Console.WriteLine("done ");
            Console.WriteLine(ob.t.IsAlive);
        }
    }
}
