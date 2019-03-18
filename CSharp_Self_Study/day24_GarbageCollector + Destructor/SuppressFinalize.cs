using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace CSharp_Self_Study.day24_GarbageCollector2
{
    class SuppressFinalize
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

        public void Dispose(bool disposing)
        {
            if (_disposed == false)
            {
                Marshal.FreeCoTaskMem(pBuffer);
                _disposed = true;
            }

            if(disposing == false)
            {
                //disposing이 false인 경우 명시적으로 Dispose()를 호출한 경우이다.
                //따라서 종료 큐에서 자신을 제거해 GC의 부담을 줄인다.
                GC.SuppressFinalize(this);
            }
        }
        public void Dispose()
        {
            Dispose(false);
        }

        ~UnmanagedMemoryManager()   //소멸자  가비지 수집이 되면 호출됨
        {
            Dispose(true);
        }
    }
}
