using System;

class Program
{
    /*제너릭 프로그램
     타입만 빼고 코드가 중복될 때
    하나만 만들고 여러 타입을 쓸 수 있음*/
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
        int[] Numbers1 = { 1, 3, 5, 7, 9 };

        double[] Numbers2 = { 1.1, 3.1, 5.1, 7.1, 9.1 };

        string[] Numbers3 = { "일", "삼", "오", "칠", "구" };
        ArrayPrint<int>(Numbers1);
        ArrayPrint<double>(Numbers2);
        ArrayPrint<string>(Numbers3);
    }   
}