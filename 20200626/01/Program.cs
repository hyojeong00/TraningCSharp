
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    /// <summary>
    /// 더블형, 스트링형, 비교 변환 등
    /// </summary>
    //class ObjectMethod
    //{
    //    static void Main(string[] args)
    //    {
    //        double radius = 3.14;

    //        Console.WriteLine("radius의 형 : {0}", radius.GetType());
    //        Console.WriteLine("radius의 값 : {0}", radius.ToString());
    //        Console.WriteLine(); //한줄 넣는것(엔터와 같음) WriteLine에 \n을 넣어주는 것과 같다

    //        string name = "이효리";
    //        Console.WriteLine("name 형 : {0}", name.GetType());
    //        Console.WriteLine("name 형 : {0}", name.ToString());
    //        Console.WriteLine();

    //        Console.WriteLine("radius == name : {0}", name.Equals(radius));
    //    }

    //}


    ///<summary>
    ///암시적 형변환
    ///직접 캐스팅하지 않고도 형의 변화가 일어남
    ///데이터형의 호환성, 사이즈 등이 적절할 때 가능
    ///</summary>
    //class Conversion
    //{
    //    static void Main(string[] args)
    //    {
    //        int intValue = 127;
    //        long longValue = intValue;

    //        Console.WriteLine("longValue = {0}", longValue);           
    //    }
    //}



    ///<summary>
    ///명시적으로 직접 캐스팅하여 형의 변화가 일어남
    ///</summary>
    class ExplictConversion
    {
        static void Main(string[] args)
        {
            //long longValue = 32767;
            //int intValue = (int)longValue;

            //Console.WriteLine("intValue = {0}", intValue);

            bool abool = true;
            //Console.WriteLine(abool);

            //int aint = 0xFFFF;
            //Console.WriteLine("{0:X8}", aint);
            ////aint = ~aint;
            ////Console.WriteLine("{0:X8}", aint);
            //aint = aint >> 4;
            //Console.WriteLine("{0:X8}", aint);
            //aint = aint << 4;
            //Console.WriteLine("{0:X8}", aint);

            byte abyte1 = 0x3F;
            byte abyte2 = 0xC1;

            Console.WriteLine("AND {0:X2}", abyte1 & abyte2);
            Console.WriteLine("OR {0:X2}", abyte1 | abyte2);
            Console.WriteLine("XOR {0:X2}", abyte1 ^ abyte2);
            //X다음 숫자는 출력하는 자릿수

            Console.WriteLine("abool의 상태는 " + (abool ? "참" : "거짓") + "일껄요?");

            int iNum = 100;
            if(iNum<500)
            {
                Console.WriteLine("iNum은 500보다 작습니다");
            }
            else
            {
                Console.WriteLine("iNum은 500보다 큽니다");
            }
        }
    }
}

