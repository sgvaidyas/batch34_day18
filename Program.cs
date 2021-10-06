using System;
using System.Threading;

namespace batch34_day18
{
    class Number
    {
        public void printeven()
        {
            for(int i=0;i<20;i++)
            {
                if(i%2==0)
                Console.WriteLine(i);
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Number ob = new Number();
            Thread t = new Thread(() => ob.printeven());
            t.Start();
        }
    }
}
