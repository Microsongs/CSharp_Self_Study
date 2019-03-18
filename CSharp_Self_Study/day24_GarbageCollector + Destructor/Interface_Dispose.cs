using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CSharp_Self_Study.day24_GarbageCollector2
{
    class Interface_Dispose
    {
        static void Main(string[] args)
        {
            /*
            FileLogger log = null;
            try
            {
                log = new FileLogger("sample.log");
                log.Write("start");
                log.Write("end");
            }
            finally //finally로 의해 무조건 자원 회수
            {
                log.Dispose();
            }
            */
            //using 사용
            using (FileLogger log = new FileLogger("sample.log"))
            {
                log.Write("Start");
                log.Write("End");
            }
        }
    }
    class FileLogger : IDisposable
    {
        FileStream _fs;
        StreamWriter sw;

        public FileLogger(string fileName)
        {
            _fs = new FileStream(fileName, FileMode.Create);
            sw = new StreamWriter(_fs);
        }

        public void Write(string txt)
        {
            sw.WriteLine(txt); 
        }

        public void Dispose()
        {
            sw.Close();
            _fs.Close();
        }
    }
}
