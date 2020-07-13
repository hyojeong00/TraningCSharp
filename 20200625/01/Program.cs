using System;
using System.Security.AccessControl;

namespace _01
{
    class Program
    {
        static void Main(string[] args)//Main 메:1개(args)
        {
            //Console.WriteLine("{0:C}", 100);
            //Console.WriteLine("{0:D}", 100);
            //Console.WriteLine("{0:E}", 100);
            //Console.WriteLine("{0:F}", 100);
            //Console.WriteLine("{0:G}", 100);
            //Console.WriteLine("{0:N}", 100);
            //Console.WriteLine("{0:X}", 100);

            Console.Write("이름을 입력하세요 : ");
            string inValue = Console.ReadLine();
            Console.WriteLine("안녕하세요 {0}님!", inValue);

        }
    }
}
