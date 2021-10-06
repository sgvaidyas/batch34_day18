using System;

namespace batch34_day18
{
    class nthhighest
    {
        static void Main(string[] args)
        {
            int[] a = { 11, 2, 33, 4, 55, 66, 7, 8, 99 };
            int n = a.Length;
            int temp,i,j;
            int k;
            Console.WriteLine("give the kth term");
            k = int.Parse(Console.ReadLine());
            for (i = 0; i < k; i++)
            {
                for (j = 0; j < n - i - 1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("sorted:");
            for(i=0;i<n;i++)
                Console.Write(a[i]+"\t");
            Console.WriteLine();
            Console.WriteLine(k+"th higest element = " + a[n-k]);
        }
    }
}
