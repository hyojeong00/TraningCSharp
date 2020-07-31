using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace thread
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread = Thread.CurrentThread;
            Console.WriteLine(thread.ThreadState);

            Console.WriteLine(DateTime.Now);
            Thread.Sleep(1000);
            Console.WriteLine(DateTime.Now);

            Thread t1 = new Thread(threadFunc1);
            Thread t2 = new Thread(threadFunc2);
            Thread t3 = new Thread(threadFunc3);
            t1.Start();
            t2.Start();
            t3.Start();
            Console.WriteLine("메인스레드 종료");
        }
        static void threadFunc1()
        {
            Console.WriteLine("5초 후에 프로그램 종료!");
            Thread.Sleep(1000 * 5);
            Console.WriteLine("5스레드 종료!");
        }
        static void threadFunc2()
        {
            Console.WriteLine("10초 후에 프로그램 종료!");
            Thread.Sleep(1000 * 10);
            Console.WriteLine("10스레드 종료!");
        }
        static void threadFunc3()
        {
            Console.WriteLine("15초 후에 프로그램 종료!");
            Thread.Sleep(1000 * 15);
            Console.WriteLine("15스레드 종료!");
        }
    }
}
