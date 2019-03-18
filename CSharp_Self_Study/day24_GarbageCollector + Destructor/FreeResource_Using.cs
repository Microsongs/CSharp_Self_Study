using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day24_GarbageCollector2
{
    class FreeResource_Using
    {
        static void Main(string[] args)
        {
            while (true)
            {
                /*
                UnmanagedMemoryManager m = new UnmanagedMemoryManager();
                m = null;
                GC.Collect();   //GC를 강제로 수행
                */
                //using을 사용하여 수행
                using(UnmanagedMemoryManager m = new UnmanagedMemoryManager())
                {

                }

                //현재 프로세스가 사용하는 메모리 크기 출력
                Console.WriteLine(Process.GetCurrentProcess().PrivateMemorySize64);
            }
        }
    }
    class UnmanagedMemoryManager
    {
        IntPtr pBuffer;

        public UnmanagedMemoryManager()
        {
            //AllocCoTaskMem 메서드는 비관리 메모리를 할당한다.
            pBuffer = Marshal.AllocCoTaskMem(4096 * 1024);
        }
    }
}
