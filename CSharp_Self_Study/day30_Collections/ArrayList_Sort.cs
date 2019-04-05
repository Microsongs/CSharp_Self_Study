using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CSharp_Self_Study.day30_Collections
{
    class ArrayList_Sort
    {
        static void Main(string[] args)
        {
            ArrayList ar = new ArrayList();

            ar.Add("Hello");
            ar.Add("World");
            ar.Add("My");
            ar.Add("Sample");

            ar.Sort();
            foreach (string txt in ar)
                Console.WriteLine(txt);
        }
    }
}
