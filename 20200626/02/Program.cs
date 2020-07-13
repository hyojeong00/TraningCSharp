using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            ///<summary>
            ///다중 if문
            ///</summary>
            int point = int.Parse(Console.ReadLine());
            string result;
            if (point >= 0 && point <= 100)
            {
                if (point > 50)
                    result = "Pass";
                else
                    result = "Fail";
                Console.WriteLine("결과 : " + result);
                
            }
            else
            {
                Console.WriteLine("에러 : 범위를 벗어났습니다.");
            }
        }
    }
}
