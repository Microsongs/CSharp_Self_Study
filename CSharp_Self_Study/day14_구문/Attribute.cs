using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day14_구문
{
    //특성(attribute) 생성
    class AuthorAttribute : System.Attribute
    {
        string name;
        public AuthorAttribute(string name)
        {
            this.name = name;
        }
        public AuthorAttribute() { }
        int _version;
        public int Version
        {
            get { return _version; }
            set { _version = value; }
        }
    }
    //기본적인 Attribute 사용 방법
    [AuthorAttribute]
    class Dummy1
    {

    }
    //클래스에는 Attribute를 제외하고 사용해도 된다.
    [Author]
    class Dummy2
    {

    }
    //Attribute도 생성자를 통해 내용 전달이 가능 
    [Author("Anders")]
    class Dummy3
    {

    }
    //생성자에서 정의되지 않은 것은 이름 = 값 형식으로 전달한다.
    [Author("Anders",Version = 3)]
    class Attribute
    {
        static void Main(string[] args)
        {

        }
    }
}
