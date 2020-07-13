using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    //public class A
    //{
        //    public static ulong Factorial(ulong number)
        //    {
        //        if (number <= 1)
        //            return 1;
        //        else
        //            return number * Factorial(number - 1);
        //    }

        //    public static void Main(string[] args)
        //    {
        //        ulong nfact = Factorial(5);
        //        Console.WriteLine("5*4*3*2*1 = " + nfact);
        //    }

    //    public static void Main(string[] args)
    //    {
    //        int localVar = 10;
    //        int unInitVar;
    //        Console.WriteLine(localVar);
    //        Console.WriteLine(unInitVar);
    //    }
    //}

    public class Example
    {
        public static int classvari = 10;
        public int classvari2 = 10;

        public Example()
        {
            classvari++;
            classvari2++;
        }

        public void Print()
        {
            Console.WriteLine("classvari : " + classvari);
            Console.WriteLine("classvari2 : " + classvari2);
        }

        public static void Main(string[] args)
        {
            Example e1;
            Example e2;
            e1 = new Example();
            e1.Print();

            e2 = new Example();
            e2.Print();

            e1.Print();
        }
    }
}
