using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace batch34_day18
{
    class dictionary_Ex
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> mydata = new Dictionary<int, int>();
            mydata.Add(11, 1);
            mydata.Add(22, 1);

            //updating the existing key
            mydata[11] = 2;
            //to check if the key exists
            Console.WriteLine(mydata.ContainsKey(26));
            //print the value
            Console.WriteLine(mydata[11]);
            foreach (KeyValuePair<int, int> kv in mydata)
            {
                Console.WriteLine(kv.Key + " : " + kv.Value);
            }
        }
    }
}
