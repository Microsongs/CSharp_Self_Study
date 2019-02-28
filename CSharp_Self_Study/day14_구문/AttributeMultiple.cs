using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day14_구문
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    class AuthorAttribute : System.Attribute
    {
        string name;
        public AuthorAttribute(string name)
        {
            this.name = name;
        }
    }
    //사용방법1 
    [Flags]
    [Author("Anders")]
    enum Days
    {

    }
    //사용방법2
    [Flags, Author("Anders")]
    enum Day
    {

    }
    class AttributeMultiple
    {
    }
}
