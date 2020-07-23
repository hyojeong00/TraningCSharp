using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        delegate int NewType(int iNum);
        static int OnePlus(int iNum) //호출할때마다 1씩 증가
        {
            return iNum + 1;
        }
        static int TenPlus(int iNum) //호출할때마다 10씩 증가
        {
            return iNum + 10;
        }
        static void Main(string[] args)
        {
            int TestNum = OnePlus(100);
            Console.WriteLine(TestNum);

            NewType aNewType = new NewType(OnePlus);
            TestNum = aNewType(1000);
            Console.WriteLine(TestNum);

            aNewType = new NewType(TenPlus);
            TestNum = aNewType(1000);
            Console.WriteLine(TestNum);

        }

    }
}
