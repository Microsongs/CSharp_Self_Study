using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day8_Polymorphism
{
    class Currency
    {
        decimal money;
        public decimal Money
        {
            get { return money; }
        }
        public Currency(decimal money)
        {
            this.money = money;
        }
    }

    class Won : Currency
    {
        public Won(decimal money) : base(money) { }
        public override string ToString()
        {
            return Money + "Won";
        }
    }
    class Dollar : Currency
    {
        public Dollar(decimal money) : base(money) { }
        public override string ToString()
        {
            return Money + "Dollar";
        }
        public static explicit operator Won(Dollar dollar)  //explicit은 명시적만 가능
        {
            return new Won(dollar.Money * 1000m);
        }
    }
    class Yen : Currency
    {
        public Yen(decimal money) : base(money) { }
        public override string ToString()
        {
            return base.Money + "Yen";
        }
        public static implicit operator Won(Yen yen)
        {
            return new Won(yen.Money * 13m);
        }
    }
    class CastingOverload
    {
        static void Main(string[] args)
        {
            Won won = new Won(1000);
            Dollar dollar = new Dollar(1);
            Yen yen = new Yen(13);
            won = yen;  //이 경우 타입이 다르므로 오류 발생, 오버로딩을 통해 해결
            Won won2 = (Won)yen;   //명시적 형변환도 가능
            Console.WriteLine(won2);

            //Won won3 = dollar;  //암시적 형변환 불가능
            Won won4 = (Won)dollar; //명시적 형변환 가능
            Console.WriteLine(won4);
        }
    }
}
