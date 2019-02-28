using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day14_구문
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    class AuthorAttribute : System.Attribute
    {
        string name;
        public AuthorAttribute(string name)
        {
            this.name = name;
        }
    }
    [type:Author("Tester")]
    class AttributeUsage
    {
        [method:Author("Tester")]
        static void Main(string[] args)
        {

        }
    }
}
