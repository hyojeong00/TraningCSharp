using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            int point;
            string result;

            point = 82; //형일치, =의 왼쪽은 변수여야함

            if (point > 90)  //조건타입에 들어가는 것은   bool형
            {
                result = "A";  //'A'는 문자, "A"문자열
                                //'A'는 아스키코드 호출
                                //"A"는 아스키코드 + null
            }

            else if (point > 80) //else if는 if문에 의존적
            {
                result = "B";
            }

            else if (point > 70) 
            {
                result = "c";
            }

            else if(point>60)
            {
                result = "D";
            }

            else
            {
                result = "F";
            }

            Console.WriteLine("당신의 점수는 {0}입니다.", point);
            Console.WriteLine("그리고 학점은 {0}입니다.", result);
        }
    }
}
