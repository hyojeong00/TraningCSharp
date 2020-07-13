using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int point;
            string result;

            Console.WriteLine("숫자를 입력하세요");

            point = int.Parse(Console.ReadLine());

            switch (point / 10)
            {
                case 10:
                    goto case 9;
                case 9:
                    result = "A";
                    break;
                case 8:
                    result = "B";
                    break;
                case 7:
                    result = "C";
                    break;
                case 6:
                    result = "D";
                    break;
                default:
                    result = "F";
                    break;
            }


            Console.WriteLine($" 당신의 점수는 {point} 입니다.");
            Console.WriteLine($" 당신의 점수는 {result} 입니다.");
        }
        
    }
}
