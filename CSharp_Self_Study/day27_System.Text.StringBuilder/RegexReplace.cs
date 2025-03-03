﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day27_System.Text.StringBuilder
{
    class RegexReplace
    {
        static void Main(string[] args)
        {
            string txt = "Hello, World! Welcome to my world";

            Regex regex = new Regex("world", RegexOptions.IgnoreCase);
            string result = regex.Replace(txt, funcMatch);

            Console.Write(result);
        }
        static string funcMatch(Match match)
        {
            return "universe";
        }
    }

}
