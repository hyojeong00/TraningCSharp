using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LinqBasic_control
{
    class Program
    {
        static void Print(List<int> aList)
        {
            foreach (var Temp in aList)
            {
                Console.Write($"{Temp} ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            List<int> aList1 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> aList2 = new List<int>();

            //var Fact = from Temp in aList1 select Temp;
            //aList2 = Fact.ToList<int>();
            aList2 = (from Temp in aList1 select Temp).ToList<int>();

            Print(aList2);
        }
        static void Main1(string[] args)
        {
            List<int> aList1 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> aList2 = new List<int>();

            foreach (var Temp in aList1)
            {
                aList2.Add(Temp);
            }
            Console.WriteLine();

            Print(aList1);
            Print(aList2);
        }
    }
}
