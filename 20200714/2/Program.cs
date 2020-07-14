using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        class Car //이너클래스
        {
            string color;
            string vender;
            string name;

            /*생성자 만들기
             * 1.메소드다
             * 2.클래스와 이름이 동일
             * 3.반환 타입이 존재하지 않는다
             */

            public Car(string name)  //생성자 오버로딩
            {
                Console.WriteLine("Car 생성자 호출");
            }

            public Car() //디폴트 생성자
            {
                Console.WriteLine("Car 디폴트 생성자 호출");
            }

            ~Car()
            {
                Console.WriteLine("Car 소멸자 호출");
                //종료할때, 메모리가 모자랄때, 할일없을때 
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("1========================");
            Car aCar = new Car("비앰다블유");
            //aCar.Car();
            new Car();
            Console.WriteLine("2========================");

        }
    }
}
