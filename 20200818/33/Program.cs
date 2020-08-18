using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33
{
    class FACT<T>
    {
        public T value;

        public void Print()
        {
            Console.WriteLine("FACT value={0}", value);
        }
    }
    class FACT2<T1,T2>
    {
        public T1 value;
        public T2 value2;

        public void Print()
        {
            Console.WriteLine("FACT value={0} : {1}", value, value2);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            FACT<int> obj = new FACT<int>();
            obj.value = 100;
            obj.Print();

            FACT2<string, string> obj2 = new FACT2<string, string>();
            obj2.value = "하이";
            obj2.value2 = "바이";
            obj2.Print();
        }
    }
}
