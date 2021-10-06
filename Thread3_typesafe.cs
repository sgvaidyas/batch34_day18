using System;
using System.Threading;

namespace batch34_day18
{
    class Number3
    {
        int target;
        public Number3(int num)
        {
            target = num;
        }
        public void printme()
        {
            for (int i = 0; i < target; i++)
                 Console.WriteLine(i);            
        }

    }
    class Thread3_typesafe
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number =");
            int num = int.Parse(Console.ReadLine());

            Number3 ob = new Number3(num);

            Thread t = new Thread(new ThreadStart(ob.printme));
            t.Start();
        }
    }
}
