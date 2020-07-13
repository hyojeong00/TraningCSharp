using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace 배열
{
    public class A
    {
        public static void MethodA()
        {
            System.Console.WriteLine("메소드 A입니다.");
        }
        public static void MethodB()
        {
            MethodA();
            System.Console.WriteLine("메소드 B입니다.");
            MethodA();
        }
    
        public static void Main(string [] args)
        {
            MethodB();
            MethodA();
        }
    }
    //class Program
    //{
    //    static void MethodTest()
    //    {
    //        Console.WriteLine("여기는 MethodTest 입니다.");
    //    }

    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("여기는 Main 메소드입니다.");
    //        MethodTest();
    //        System.Console.WriteLine("MethodTest 메소드를 호출하였습니다.");
    //    }

        //static void Main(string[] args)
        //{
            //int[] iArray = new int[5];
            //iArray = {0,1,2,3,4};


            //int[] iArray = new int[5] {0,1,2,3,4};
            //int[] iArray;
            //iArray = new int[5] { 0, 1, 2, 3, 4 };


            /*int[] iArray = new int[50] {
                0,1,2,3,4,
                0,1,2,3,4,
                0,1,2,3,4,
                0,1,2,3,4,
                0,1,2,3,4,
                0,1,2,3,4,
                0,1,2,3,4,
                0,1,2,3,4,
                0,1,2,3,4,
                0,1,2,3,4
            };*/

            //int[] iArray = new int[5] { 0, 1, 2, 3, 4 };

            //for (int i = 0; i < iArray.Length; ++i)
            //{
            //    Console.WriteLine(iArray[i]);
            //}

            //foreach (int i in iArray)
            //{
            //    Console.WriteLine(iArray[i]);
            //}

            //for (int i=0;i<10;i++)
            //{
            //    if (i % 2 == 1)
            //        continue;
            //    Console.Write("{0", i);
            //}
            //Console.WriteLine();

            //for(int i=0;i<10;i++)
            //{
            //    if (i % 2 == 1)
            //        break;
            //    Console.Write("{0", i);
            //}
            //Console.WriteLine();

            //int a, b;
            //float c = 0;
            

            //try
            //{
            //    Console.WriteLine("두 수를 입력하세요");
            //    Console.Write(" 첫번째 수 : ");
            //    a = int.Parse(Console.ReadLine());
            //    Console.Write(" 두번째 수 : ");
            //    b = int.Parse(Console.ReadLine());
            //    c = a / b;
            //}

            //catch (FormatException eObj)
            //{
            //    Console.WriteLine(eObj);
            //    Console.WriteLine("숫자의 입력이 아닙니다.");
            //    continue;
            //}

            //catch (Exception eObj) //runtime error을  객체지향언어에서는 exception (예외) 라고 함 ->에러발생
            //{
                
            //    Console.WriteLine(eObj);
            //    Console.WriteLine("0으로 나눌 수 없습니다.");
            //    continue;
                
            //}
                      
            //finally
            //{
            //    Console.WriteLine("프로그램이 실행되었습니다.");
            //}
            //Console.WriteLine("A/B값은 {0}입니다.", c);
            //break;

        //}
    
}
