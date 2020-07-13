using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int iNum;
            //for(iNum=1;iNum<=10;iNum++)
            //{
            //    Console.WriteLine(iNum);
            //}

            int i = 0;
            for(; ; )
            {
                if(i>10)
                {
                    break;
                }
                Console.WriteLine("{0}", ++i);
            }
            Console.WriteLine();
        }
    }
}
