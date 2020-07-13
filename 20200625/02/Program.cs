using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    enum Week
    {
        Mon = 100,
        Tue,
        Wed,
        Thu,
        Fri=400,
        Sat,
        Sun
    }
    class Program
    {
        static void Main(string[] args)
        {

            //int iNumber = 0x12345678;
            //float fNumber = 41.625f;

            Week GoodDay;
            Week Today;

            GoodDay = Week.Fri;
            Today = Week.Thu;

            Console.WriteLine("GoodDay = {0}", GoodDay);
            Console.WriteLine("Today = {0}", Today);

            Console.WriteLine("GoodDay = {0}", (int)GoodDay);
            Console.WriteLine("Today = {0}", (int)Today);

            Console.WriteLine("Index = {0}", (int)Week.Mon);
            Console.WriteLine("Index = {0}", (int)Week.Tue);
            Console.WriteLine("Index = {0}", (int)Week.Wed);
            Console.WriteLine("Index = {0}", (int)Week.Thu);
            Console.WriteLine("Index = {0}", (int)Week.Fri);
            Console.WriteLine("Index = {0}", (int)Week.Sat);
            Console.WriteLine("Index = {0}", (int)Week.Sun);

        }
    }
}
