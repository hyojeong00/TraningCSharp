using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{

    class Program
    {
        static void ArrayIntCopy(int[] Dst,int[] Src)
        {
            for(int Temp=0; Temp<Dst.Length; ++Temp)
            {
                Dst[Temp] = Src[Temp];
            }
        }
        static void ArrayDoubleCopy(double[] Dst, double[] Src)
        {
            for (int Temp = 0; Temp < Dst.Length; ++Temp)
            {
                Dst[Temp] = Src[Temp];
            }
        }
        static void ArrayPrint<T>(T[] Num) //제너릭 프로그램:일반화시킨 프로그램
        {
            for (int Temp = 0; Temp < Num.Length; ++Temp)
            {
                Console.Write("{0} ", Num[Temp]);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[] ArrayInt1 = { 2, 4, 6, 8 };
            int[] ArrayInt2 = new int[4];
            ArrayIntCopy(ArrayInt2, ArrayInt1);
            ArrayPrint<int>(ArrayInt2);

            double[] ArrayDouble1 = { 2.1, 4.1, 6.1, 8.1 };
            double[] ArrayDouble2 = new double[4];
            ArrayDoubleCopy(ArrayDouble2, ArrayDouble1);
            ArrayPrint<int>(ArrayInt2);
        }
    }
}
