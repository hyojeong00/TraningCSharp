using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    struct Book
    {
        public string Name;
        public int Price;

        public void test()
        {
            Console.WriteLine("구조체안에 메소드 실행됨? 실화??");
        }

        static Book()
        {
            Console.WriteLine("이건 한번만 호출됩니당 스태틱생성자");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Book aBook;
            aBook.Name = "test";
            aBook.Price = 100;
            aBook.test();
        }   
    }
}
