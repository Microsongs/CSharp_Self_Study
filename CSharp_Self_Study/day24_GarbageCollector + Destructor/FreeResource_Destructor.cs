using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace CSharp_Self_Study.day24_GarbageCollector2
{
    class FreeResource_Destructor
    {
        static void Main(string[] args)
        {
            while (true)
            {
                UnmanagedMemoryManager m = new UnmanagedMemoryManager();
                m = null;

                GC.Collect();   //GC로 의해 소멸자가 호출되어 비관리 메모리도 해제
                Console.WriteLine(Process.GetCurrentProcess().PrivateMemorySize64);
            }
        }
    }
    class UnmanagedMemoryManager : IDisposable
    {
        IntPtr pBuffer;
        bool _disposed;

        public UnmanagedMemoryManager()
        {
            pBuffer = Marshal.AllocCoTaskMem(4096 * 1024);
        }

        public void Dispose()
        {
            if(_disposed == false)
            {
                Marshal.FreeCoTaskMem(pBuffer);
                _disposed = true;
            }
        }

        ~UnmanagedMemoryManager()   //소멸자  가비지 수집이 되면 호출됨
        {
            Dispose();
        }
    }
}
