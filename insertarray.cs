using System;

namespace batch34_day18
{
    class insertarray
    {
        static void display(int[] a,int n)
        {
            Console.WriteLine("elements = ");
            for(int i =0;i<n;i++)
                Console.Write(a[i] + "\t");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[] a = new int[50];
            int n=0,ele,ch,pos;
            do
            {
                Console.WriteLine("enter ele");
                ele = int.Parse(Console.ReadLine());
                if (n == 0)
                    a[0] = ele;
                else
                {
                    int i;
                    for(i=0;i<n;i++)
                    {
                        if (a[i] > ele)
                            break;
                    }
                    pos = i;
                    for (i = n; i > pos; i--)
                        a[i] = a[i - 1];
                    a[pos] = ele;
                }
                n++;
                display(a, n);
                Console.WriteLine("press 1 to exit");
                ch = int.Parse(Console.ReadLine());
            } while (ch != 1);
        }
    }
}
