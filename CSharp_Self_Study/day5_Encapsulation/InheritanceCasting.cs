using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day5_Encapsulation
{
    public class Computer
    {
        bool powerOn;   //private여서 자식에서 접근 불가능
        public void Boot() { }
        public void Shutdown() { }
        public void Reset() { }
    }
    public class NoteBook : Computer    //Computer를 상속받음
    {
        bool fingerScan;    //노트북 타입에 해당하는 맴버만 추가
        public bool HashFingerScanDevice()
        {
            return fingerScan;
        }
    }
    public class Desktop : Computer
    {

    }
    public class NetBook : Computer
    {

    }

    public class DeviceManager
    {
        public void TurnOff(Computer device)
        {
            device.Shutdown();
        }
    }
    class InheritanceCasting
    {
        static void Main(string[] args)
        {
            NoteBook notebook = new NoteBook();
            Desktop desktop = new Desktop();
            NetBook netbook = new NetBook();

            DeviceManager manager = new DeviceManager();
            manager.TurnOff(notebook);  //저부 Computer를 상속받으므로 Computer로 되어있는 필드로도 들어올 수 있음(암시적 형변환)
            manager.TurnOff(desktop);
            manager.TurnOff(netbook);
        }
    }
}
