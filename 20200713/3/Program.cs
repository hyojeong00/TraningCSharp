using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        //static int[] Test()
        //{
        //    int[] Array = new int[5];

        //    return Array;
        //}
        //static void Main(string[] args)
        //{
        //    int[] Ret = Test();
        //    Console.WriteLine(Ret.Length);
        //}

        //static void Test(int[] Var)
        //{
        //    Console.WriteLine(Var.Length);
        //}

        //static void Main(string[] args)
        //{
        //    int[] Array = new int[5];
        //    Test(Array);
        //}

        static int[] Test(int[] Var)
        {
            Var[0] = 99;
            return Var;
        }
        static void Main(string[] args)
        {
            int[] Array1 = new int[100];
            int[] Array2 = Test(Array1);
            Console.WriteLine(Array1[0]);
            Console.WriteLine(Array2[0]);
        }
    }
}
