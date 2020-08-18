using System;

class Program
{
    static void ArrayIntPrint(int[] Num)
    {
        for (int Temp = 0; Temp < Num.Length; ++Temp)
        {
            Console.Write("{0} ", Num[Temp]);
        }
        Console.WriteLine();
    }
    static void ArrayDoublePrint(double[] Num)
    {
        for (int Temp = 0; Temp < Num.Length; ++Temp)
        {
            Console.Write("{0} ", Num[Temp]);
        }
        Console.WriteLine();
    }
    static void ArrayStringPrint(string[] Num)
    {
        for (int Temp = 0; Temp < Num.Length; ++Temp)
        {
            Console.Write("{0} ", Num[Temp]);
        }
        Console.WriteLine();
    }
    static void Main(string[] args)
    {
        int[] Numbers1 = { 1, 3, 5, 7, 9 };
        ArrayIntPrint(Numbers1);

        double[] Numbers2 = { 1.1 , 3.1, 5.1, 7.1, 9.1 };
        ArrayDoublePrint(Numbers2);

        string[] Numbers3 = { "일", "삼", "오", "칠", "구" };
        ArrayStringPrint(Numbers3);
    }
}