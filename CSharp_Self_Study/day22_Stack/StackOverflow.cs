﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day22_HeapAndStack
{
    class StackOverflow
    {
        static void Main(string[] args)
        {
            int result = Sum(5, 6);
            Console.WriteLine(result);
        }
        static int Sum(int v1,int v2)
        {
            int sum = InnerSum(v1, v2);
            return sum;
        }
        static int InnerSum(int v1,int v2)
        {
            int sum = v1 + v2;
            return sum;
        }
    }
}
