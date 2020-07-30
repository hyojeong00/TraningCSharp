using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

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

        }
    }
}
