﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day10_Delegate_Interface
{
    interface IObjectToString { }   //ToString을 재정의한 클래스에만 사용될 빈 인터페이스 정의

    class Computer { }  //ToString을 재정의하지 않은 예제 타입

    class Person : IObjectToString  //ToString을 재정의헀다는 의미로 인터페이스 상속
    {
        string name;
        public Person(string name)
        {
            this.name = name;
        }
        public override string ToString()
        {
            return "Person : " + this.name;
        }
    }
    class Interface_apply
    {
        private static void DisplayObject(object obj)
        {
            if(obj is IObjectToString)  //인터페이스로 형변환이 가능한지 여부
            {
                Console.WriteLine(obj.ToString());
            }
        }
        static void Main(string[] args)
        {
            DisplayObject(new Computer());
            DisplayObject(new Person("홍길동"));
        }
    }
}
