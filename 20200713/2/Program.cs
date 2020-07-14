using System;
using System.Linq;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Array = { 144, 123, 232, 324, 789 };

            int index = System.Array.IndexOf(Array, 324);

            Console.WriteLine(index);

            for (int Count = 0; Count < Array.Length; ++Count)
            {
                //324의 위치를 찾아라
                if(324==Array[Count])
                {
                    Console.WriteLine("찾았다!!!!!! : " + Count);
                    Console.WriteLine("찾았다!!!!!! : {0}", Count);
                    break;
                }
            }

            Console.WriteLine("찾았다!!!!!! : {0}", System.Array.IndexOf(Array, 324));
        }
    }
}
