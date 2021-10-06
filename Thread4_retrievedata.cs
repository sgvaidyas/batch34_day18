using System;
using System.Threading;

namespace batch34_day18
{
    public delegate void factorialcallback(int fact);
    class Factorial
    {
        int num;
        factorialcallback callback;
        public Factorial(int n,factorialcallback callbackfun)
        {
            num = n;
            callback = callbackfun;
        }
        public void getfactorial()
        {
            int res = 1;
            for (int i = 1; i <= num; i++)
                res = res * i;

            if (callback != null)
                callback(res);
        }
    }
    class Thread4_retrievedata
    {
        public static void printfact(int res)
        {
            Console.WriteLine("Factorial = "+res);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number =");
            int num = int.Parse(Console.ReadLine());

            factorialcallback callback = new factorialcallback(printfact);

            Factorial ob = new Factorial(num, callback);
            Thread t = new Thread(new ThreadStart(ob.getfactorial));
            t.Start();

        }
    }
}
