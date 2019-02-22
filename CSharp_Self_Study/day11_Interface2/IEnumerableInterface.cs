using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CSharp_Self_Study.day11_Interface2
{
    class Hardware { }
    class USB
    {
        string name;
        public USB(string name){
            this.name = name;
        }
        public override string ToString()
        {
            return name;
        }
    }
    class Notebook : Hardware, IEnumerable  //IEnumerable 인터페이스 구현
    {
        USB[] usbList = new USB[] { new USB("USB1"), new USB("USB2") };

        public IEnumerator GetEnumerator()  //IEmunerator를 구현한 열거자 인스턴스 반환
        {
            return new USBEnumerator(usbList);
        }
        public class USBEnumerator : IEnumerator    //중첩 클래스로 정의된 열거자 타입
        {
            int pos = -1;
            int length = 0;
            object[] list;
            public USBEnumerator(USB[] usb)
            {
                list = usb;
                length = usb.Length;
            }
            public object Current   //현재 요소를 반환하도록 약속된 접근자 메서드
            {
                get { return list[pos]; }
            }
            public bool MoveNext()  //다음 순서의 요소를 지정하도록 약속된 메서드
            {
                if(pos >= length - 1)
                {
                    return false;
                }
                pos++;
                return true;
            }
            public void Reset() //처음부터 열거하고 싶을 떄 호출하면 되는 메서드
            {
                pos = -1;
            }
        }
    }
    class IEnumerableInterface
    {
        static void Main(string[] args)
        {
            Notebook notebook = new Notebook();
            foreach(USB usb in notebook)
            {
                Console.WriteLine(usb);
            }
        }
    }
}
