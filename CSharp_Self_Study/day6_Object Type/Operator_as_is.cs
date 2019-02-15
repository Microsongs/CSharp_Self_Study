using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day6_Object_Type
{
    public class Computer
    {
        protected string name;
        protected int price;
        public string Name  //property
        {
            get{ return name; }
            set { name = value; }
        }
        public void error()
        {
            Console.WriteLine("error");
        }
    }
    public class Notebook : Computer
    {
        public void CloseLid()
        {
            Console.WriteLine("hi");
            error();
        }
    }
    public class Operator_as_is
    {
        static void Main(string[] args)
        {
            //as 연산자의 올바른 사용법
            Computer pc = new Computer();
            Notebook notebook = pc as Notebook;
            if(notebook != null)    //pc를 Notebook형으로 형변환한 결과 notebook에는 null이 들어간다.
            {
                notebook.CloseLid();
                notebook.error();
            }
            //is 연산자의 올바른 사용법
            string txt = "text";
            if(txt is int)
            {
                Console.WriteLine("변수 txt는 int타입");
            }
            else if(txt is string)
            {
                Console.WriteLine("변수 txt는 string타입");
            }
        }
    }
}
