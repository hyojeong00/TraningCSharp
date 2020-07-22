using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020._07._17_003
{
    class Vehicle
    {
        public void test()
        {
            Console.WriteLine("비히클");
        }
    }
    class Car : Vehicle
    {
        public new void test()
        {
            Console.WriteLine("비히클");
        }
    }
    class Asia
    {

    }
    class America
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            Object[] aObject1 = new Object[] { new Vehicle(), new Vehicle(), new Car(), new Vehicle(), new Car() };
            Car aCar;

            for (int i = 0; i < aObject1.Length; ++i)
            {
                if ((aCar = aObject1[i] as Car) == null)
                {
                    Vehicle aVehicle = (Vehicle)aObject1[i];
                    Console.WriteLine("Vehicle 타입");
                }
                else
                {
                    Console.WriteLine("Car 타입");
                }

            }
        }






























        static void Main2(string[] args)
        {
            Vehicle aVehicle = new Car();
            Car aCar = new Car();

            /* as : aCar안에 aVehicle가 있는지 검사하는 연산자
             있으면 자동으로 형변환 해주고 없으면 null을 집어넣는다 
            명시적 casting 보다 as를 쓰는것이 더 낫다. */

            aCar = aVehicle as Car;

            if (aCar == null)
            {
                Console.WriteLine("aCar는 null이다.");
            }
            else
            {
                Console.WriteLine("aCar는 Car이다.");

            }

        }





















        static void Main5(string[] args)
        {

            Vehicle[] Array = new Vehicle[] { new Car(), new Car(), new Vehicle() };

            for (int i = 0; i < Array.Length; ++i)
            {
                Car aCar = (Car)Array[i];
                Console.WriteLine(Array[i]);
            }

        }






















        static void Main4(string[] args)
        {
            Object aHuman = new Vehicle();
            Object aHuman1 = new Asia();
            Asia aAsian;


            aAsian = (Asia)aHuman;

        }




















        static void Main6(string[] args)
        {
            Vehicle aVehicle = new Vehicle();
            Car aCar = new Car();


            // is : ~은 ~이다. 좌우를 비교 / 참과 거짓 나타냄.
            if (aVehicle is Car)
            {
                aCar = (Car)aVehicle;
            }
            else
            {
                Console.WriteLine("aVehicle은 Car가 아임다.");
            }



            /*try
            {
                aCar = (Car)aVehicle;
            }
            catch(InvalidCastException)
            {
                Console.WriteLine("잘못된 내용입니다.");
            }*/

        }






        static void Main1(string[] args)
        {
            Vehicle vehicle = new Vehicle();
            Car car = new Car();

            // casting(명시적 형변환) why? type이 다르기 때문에
            Vehicle a = car; // 묵시적/암시적/자동 형변환
            Car b = (Car)a;  // 명시적/강제적/수동 형변환
        }
    }
}