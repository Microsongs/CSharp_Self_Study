﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day16_예약어
{
    class Managed
    {
        public int Count;
        public string Name;
    }
    class fixed_C_and_C___s_Object_Pointer
    {
        unsafe static void Main(string[] args)
        {
            Managed inst = new Managed();

            inst.Count = 5;
            inst.Name = "text";
            fixed(int* pValue = &inst.Count)
            {
                *pValue = 6;
            }
            

            fixed(char* pChar = inst.Name.ToCharArray())
            {
                for(int i=0; i<inst.Name.Length; i++)
                {
                    Console.WriteLine(*(pChar + i));
                }
            }
        }
    }
}
