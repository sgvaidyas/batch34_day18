using System;
using System.Collections.Generic;

namespace batch34_day18
{
    class Missingnum
    {
        public void getdata(int[] a)
        {
            int d=0,cnt=1;
            Dictionary<int, int> mydata = new Dictionary<int, int>();
            for(int i=1;i<a.Length;i++)
            {
                d = a[i] - a[i - 1];
                if (mydata.ContainsKey(d) == false)
                    mydata.Add(d, cnt);
                else
                {
                    mydata[d] = mydata[d] + 1;
                    break;
                }
            }
            foreach (KeyValuePair<int, int> kv in mydata)
            {
                if (kv.Value == 2)
                    d = kv.Key;
            }
            int flag = 1;
            for(int i=0;i<a.Length-1;i++)
            {
                if(a[i]+ d != a[i+1])
                {
                    flag = 0;
                    Console.WriteLine("missing element "+a[i]+d);
                }
            }
            if(flag==1)
                Console.WriteLine("No missing element");
        }
    }
    class Missingelement_array
    {
        static void Main(string[] args)
        {
             Missingnum ob = new Missingnum();
             int[] a = {33, 44, 55, 77 ,88 ,99};
             ob.getdata(a);            
        }
    }
}
