using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day9_ClassExpansion
{
    
    public class Disk
    {
        public int Clean(object arg)
        {
            Console.WriteLine("작업 실행");
            return 0;
        }
        
    }

    class DelegateBasic1
    {
        delegate int FuncDelegate(object arg);
        static void Main(string[] args)
        {
            Disk disk = new Disk();

            FuncDelegate cleanfunc = disk.Clean;

            disk.Clean(null);   //clean 메서드를 호출
            cleanfunc(null);    //델리게이트 인스턴스를 통해 clean 메서드를 호출
        }
    }
}
