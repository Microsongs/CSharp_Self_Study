using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day27_System.Text.StringBuilder
{
    class RegexNoUse
    {
        static void Main(string[] args)
        {
            string email = "tester@test.com";
            Console.WriteLine(IsEmail(email));  //출력 결과 : true
        }
        static bool IsEmail(string email)
        {
            string[] parts = email.Split('@');  //@기준으로 분리
            if(parts.Length != 2)   //@기준으로 2로 안나뉠 경우 false
                return false;

            if (IsAlphaNumeric(parts[0]) == false)   //문자/숫자가 아닌게 들어가있을 경우
                return false;

            parts = parts[1].Split('.');    //이메일의 점 기준으로 분리
            if (parts.Length == 1)  //길이가 1이면 .이 없는 것
                return false;

            foreach (string part in parts)
                if (IsAlphaNumeric(part) == false)
                    return false;

            return true;
        }
        static bool IsAlphaNumeric(string text)
        {
            foreach (char ch in text)
                if (char.IsLetterOrDigit(ch) == false)
                    return false;

            return true;
        }
    }
}
