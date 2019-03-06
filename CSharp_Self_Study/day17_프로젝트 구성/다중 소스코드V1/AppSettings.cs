using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//App.config의 appSettings 사용
using System.Configuration;

namespace CSharp_Self_Study.day17_프로젝트_구성.다중_소스코드V1
{
    class AppSettings
    {
        static void Main(string[] args)
        {
            //아래 방법을 사용하면 경고가 뜨지 않는다.
            string txt = ConfigurationManager.AppSettings["AdminEmailAddress"];
            Console.WriteLine(txt); //출력 결과 : admin@sysnet.pe.kr

            //아래 방법을 사용하면 경고가 뜬다.
            txt = ConfigurationSettings.AppSettings["Delay"];
            int delay = int.Parse(txt);
            Console.WriteLine(delay);   //출력 결과 : 5000

        }
    }
}
