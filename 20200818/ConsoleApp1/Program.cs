using System;
class Program
{
    static void ArrayCopy<T>(T[] Dst, T[] Src)
    {
        for (int Temp = 0; Temp < Dst.Length; ++Temp)
        {
            Dst[Temp] = Src[Temp];
        }
    }
    static void ArrayPrint<T>(T[] Num)
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
        ArrayCopy<int>(ArrayInt2, ArrayInt1);
        ArrayPrint<int>(ArrayInt2);

        double[] ArrayDouble1 = { 2.1, 4.1, 6.1, 8.1 };
        double[] ArrayDouble2 = new double[4];
        ArrayCopy<double>(ArrayDouble2, ArrayDouble1);
        ArrayPrint<double>(ArrayDouble2);
    }
}