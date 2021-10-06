using System;
using System.Threading;

namespace batch34_day18
{
    class Number2
    {
        public static void printme(object n)
        {
            int num = 0;
            if(int.TryParse(n.ToString(),out num))
            {
                for(int i =0;i<num;i++)
                    Console.WriteLine(i);
            }
        }
    }
    class Thread2_param
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number =");
            object n = Console.ReadLine();

            ParameterizedThreadStart parm = new ParameterizedThreadStart(Number2.printme);

            Thread t = new Thread(parm);
            t.Start(n);
        }
    }
}
