using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace Param1
//{
//    public class ParamValue
//    {
//        public void Increase(int n)
//        {
//            n++;
//        }
//        static void Main(string[] args)
//        {
//            int i = 10;
//            ParamValue pv = new ParamValue();
//            Console.WriteLine("호출 전 : {0}", i);
//            pv.Increase(i);
//            Console.WriteLine("호출 후 : {0}", i);
//        }
//    }
//}

//namespace Param2
//{
//    public class ParamRef
//    {
//        public int myVal = 10;
//    }

//    public class ParamTest
//    {
//        public static void Increase(ParamRef varRef)
//        {
//            varRef.myVal++;
//        }
//        public static void Main(string[] args)
//        {
//            ParamRef pr = new ParamRef(); //pr은 객체참조변수이자 지역변수->스택에 저장
//            Console.WriteLine("호출 전 : {0}", pr.myVal); //myVal은 힙에 저장 지역변수에서 할당
//            ParamTest.Increase(pr);
//            Console.WriteLine("호출 전 : {0}", pr.myVal);
//        }
//    }
//}

//namespace Param3
//{
//    public class ParamValue
//    {
//        public void Increase(ref int n)
//        {
//            n++;
//        }
//        public static void Main(string[] args)
//        {
//            int i = 10;
//            ParamValue pv = new ParamValue();
//            Console.WriteLine("호출 전 : {0}", i);
//            pv.Increase(ref i);
//            Console.WriteLine("호출 후 : {0}",i);
//        }
//    }
//}

namespace Param4
{
    public class ParamRef
    {
        public int myVal = 10;
    }

    public class ParamTest
    {
        public static void Increase(ref ParamRef varRef)
        {
            varRef.myVal++;
        }
        public static void Main(string[] args)
        {
            ParamRef pr = new ParamRef();
            Console.WriteLine("호출 전 : {0}", pr.myVal);
            ParamTest.Increase(ref pr);
            Console.WriteLine("호출 후 : {0}", pr.myVal);

        }
    }
}
