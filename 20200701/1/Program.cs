using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 출력인자 방식
/// </summary>
//namespace Param5
//{
//    public class ParamValue
//    {
//        public void Increase(out int n)
//        {
//            n = 11;
//        }
//        public static void Main(string[] args)
//        {
//            int i=6;//결과 : 11 ->레퍼런스
//            ParamValue pv = new ParamValue();
//            pv.Increase(out i);
//            Console.WriteLine("호출 후 값 : {0}", i);
//        }
//    }
//}

///<summary>
///가변인자
/// </summary>
/// C# Params 규칙
/// 1.params 키워드는 타입 왼쪽에 기입
/// 2.반드시 1차원 배열로 선언
//namespace Param6
//{
//    public class VariableLength
//    {
//        public int VarMethod(params int[] arr)
//        {
//            int sum = 0;
//            for(int i=0;i<arr.Length;i++)
//            {
//                sum = sum + arr[i];
//            }
//            return sum;
//        }
//        public static void Main(string[] args)
//        {
//            int result;
//            VariableLength vl = new VariableLength();
//            result = vl.VarMethod(10, 20);
//            Console.WriteLine(result);
//            result = vl.VarMethod(1, 2, 3, 4);
//            Console.WriteLine(result);
//        }
//  

//namespace Param6_1
//{
//    public class ParamValue
//    {
//        public static void VarMethod(params object[] arr)
//        {
//            Console.WriteLine("[가변 인자 개수] : " + arr.Length);

//            Console.WriteLine("[인자 전체]     : ");
//            foreach (object one in arr)
//            {
//                Console.WriteLine(one + " ");
//                one.ToString();
//            }
//            Console.WriteLine();

//            Console.WriteLine("[문자열 타입]     : ");
//            for (int i =0;i<arr.Length;++i)
//            {
//                Type t = arr[i].GetType();
//                if(t.Equals(typeof(System.String))) //typeof : 예약어
//                {
//                    Console.WriteLine(arr[i] + " ");
//                }
//            }
//            Console.WriteLine();

//            Console.WriteLine("[정수 타입]     : ");
//            foreach (object one in arr)
//            {
//                Type t = one.GetType();
//                if (t.Equals(typeof(System.Int32)))
//                {
//                    Console.WriteLine(one + " ");
//                }
//            }
//            Console.WriteLine();

//            Console.WriteLine("[실수 타입]     :");
//            foreach (object one in arr)
//            {
//                Type a = one.GetType();
//                if(a.Equals(typeof(System.Double)))
//                {
//                    Console.WriteLine(one + " ");
//                }
//                if(a.Equals(typeof(System.Single)))
//                {
//                    Console.WriteLine(one + " ");
//                }
//            }
//            Console.WriteLine();
//        }

//        static void Main(string[] args)
//        {
//            VarMethod(1000, 2000, "3000", "헬로", 3.1, 3.2f);
//        }
//    }
//}

//namespace ConsoleApp9
//{
//    class Program
//    {
//        static double Add(double Num1, double Num2)
//        {
//            double Num3 = Num1 + Num2;

//            return Num3;
//        }
//        static float Add(float Num1, float Num2)
//        {
//            float Num3 = Num1 + Num2;

//            return Num3;
//        }
//        static int Add(int iNum1, int iNum2)
//        {
//            int iNum3 = iNum1 + iNum2;

//            return iNum3;
//        }
//        /*
//        static float Add(int iNum1, int iNum2)
//        {
//            float iNum3 = iNum1 + iNum2;

//            return iNum3;
//        }*/
//        static double AddDouble(double Num1, double Num2)
//        {
//            double Num3 = Num1 + Num2;

//            return Num3;
//        }
//        static float AddFloat(float Num1, float Num2)
//        {
//            float Num3 = Num1 + Num2;

//            return Num3;
//        }
//        static int AddInt(int iNum1, int iNum2)
//        {
//            int iNum3 = iNum1 + iNum2;

//            return iNum3;
//        }
//        static void Main(string[] args)
//        {
//            int Num1 = 3;
//            int Num2 = 4;
//            int Num3 = Num1 + Num2;

//            Console.WriteLine("{0} = {1} + {2}", Num3, Num1, Num2);

//            int iNum4 = AddInt(5, 6);
//            Console.WriteLine("{0} = {1} + {2}", iNum4, 5, 6);

//            float fNum4 = AddFloat(5.1f, 6.1f);
//            Console.WriteLine("{0} = {1} + {2}", fNum4, 5.1f, 6.1f);

//            double dNum4 = AddDouble(5.1, 6.1);
//            Console.WriteLine("{0} = {1} + {2}", dNum4, 5.1, 6.1);



//            int iNum5 = Add(5, 6);
//            //int iNum6 = Add("5", "6");

//        }
//    }
//}

///<summary>
///메소드 오버로딩
///1.메소드의 이름이 동일할 것
///2.메소드의 매개변수가 서로 다를 것(갯수, 순서 등)
/// </summary>
//namespace Overroading
//{
//    class ArrayClass
//    {
//        static void Main(string[] arg)
//        {
//            Console.WriteLine("행의 갯수를 입력 하세요.");
//            string s1 = Console.ReadLine();

//            Console.WriteLine("열의 갯수를 입력 하세요.");
//            string s2 = Console.ReadLine();

//            int rows = int.Parse(s1);
//            int cols = int.Parse(s2);

//            int[,] myArray = new int[rows, cols];
//            Console.WriteLine(rows + " * " + cols + "배열이 생성되었습니다.");
//        }
//    }
//}
//namespace A
//{
//    class CopyArray
//    {
//        static void Main(string[] args)
//        {
//            long[] Original = new long[4] { 3, 1, 2, 0 };
//            long[] Copy = Original;
//            Console.WriteLine("1 : " + Copy[3]);
//            Original[3] = Original[1] + Original[2];

//            long CopyValue = Copy[3];
//            Console.WriteLine("2 : " + Copy[3]);
//        }
//    }
//}

//class ArrayLength
//{
//    static void Main(string[] args)
//    {
//        int[] Array1 = new int[4];
//        int[,] Array2 = new int[2, 3];
//        int[,,] Array3 = new int[2, 4, 3];

//        Console.WriteLine("Array1의 크기 : " + Array1.Length);
//        Console.WriteLine("Array2의 크기 : " + Array2.Length);
//        Console.WriteLine("Array3의 크기 : " + Array3.Length);

//    }
//}

//class ArraySort
//{
//    static void Main(string[] args)
//    {
//        int i = 0;

//        int[] SortArray = new int[5] { 15, 32, 11, 20, 43 };

//        Console.WriteLine("현재 배열 출력 : ");
//        for (i = 0; i < SortArray.Length; i++)
//        {
//            Console.WriteLine(SortArray[i]);
//        }

//        Array.Sort(SortArray);

//        Console.WriteLine("정렬된 배열 출력 : ");
//        for (i = 0; i < SortArray.Length; i++)
//        {
//            Console.WriteLine(SortArray[i]);
//        }
//    }
//}

//class ArrayClear1
//{
//    static void Main(string[] args)
//    {
//        int[] ClearArray = { 5, 4, 2, 6, 7, 1 };

//        Console.WriteLine("******************클리어전*********************");
//        foreach(int iNum in ClearArray)
//        {
//            Console.WriteLine(iNum);
//        }

//        Array.Clear(ClearArray, 0, ClearArray.Length);
//        Console.WriteLine("******************클리어전*********************");
//        foreach(int iNum in ClearArray)
//        {
//            Console.WriteLine(iNum);
//        }
//    }
//}

//class ArrayClear2
//{
//    static void Main(string[] args)
//    {
//        int i = 0;
//        int[] ClearArray = { 5, 4, 2, 6, 7, 1 };
//        Array.Clear(ClearArray, 1, 2);

//        for(i=0;i<ClearArray.Length;i++)
//        {
//            Console.WriteLine(ClearArray[i]);
//        }
//    }
//}

//class ArrayClone
//{
//    static void Main(string[] args)
//    {
//        int i = 0;
//        int[] Original = { 5, 4, 2, 6, 7, 1 };
//        int[] Clone = (int[])Original.Clone();

//        for(i=0;i<Clone.Length;i++)
//        {
//            Console.WriteLine(Clone[i]);
//        }

//        Original[3] = 20;
//        Console.WriteLine("복제배열[3] : " + Clone[3]);
//    }
//}

class Array
{
    static void Main(string[] args)
    {
        int i = 0;
        int[] Original = { 5, 4, 2, 6, 7, 1 };
        int[] Clone = (int[])Original.Clone();

        Console.WriteLine("Original : ");
        foreach (int one in Original)
            Console.WriteLine(one + " ");
        Console.WriteLine();

        Console.Write("Clone : ");
        foreach (int one in Clone)
            Console.Write(one + " ");
        Console.WriteLine();

        Console.WriteLine("*********************************");
        System.Array.Sort(Clone);

        Console.Write("Original : ");
        foreach (int one in Original)
            Console.Write(one + " ");
        Console.WriteLine();

        Console.Write("Clone : ");
        foreach (int one in Clone)
            Console.Write(one + " ");
        Console.WriteLine();

        

    }
}