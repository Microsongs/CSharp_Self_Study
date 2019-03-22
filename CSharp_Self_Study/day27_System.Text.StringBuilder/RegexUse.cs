using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day27_System.Text.StringBuilder
{
    class RegexUse
    {
        static void Main(string[] args)
        {
            string email = "tester@test.com";
            Console.WriteLine(IsEmail2(email));
        }
        static bool IsEmail2(string email)
        {
            Regex regex = new Regex(@"^([0-9a-zA-Z]+)@([0-9a-zA-Z]+)(\.[0-9a-zA-Z]+){1,}$");
            return regex.IsMatch(email);
        }
    }
}
