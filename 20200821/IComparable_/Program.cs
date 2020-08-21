using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparable_
{
    class Program
    {
        class Fact : IComparable
        {
            public string Name;
            public int Age;
            public string Gender;

            public int CompareTo(object obj)
            {
                return Age.CompareTo(((Fact)obj).Age);
            }

            public override string ToString()
            {
                return string.Format($"[{Name},{Age},{Gender}]");
            }
        }

        static void Main(string[] args)
        {
            List<Fact> aList = new List<Fact>();
            Fact Temp = new Fact();
            Temp.Name = "그놈";
            Temp.Gender = "남";
            Temp.Age = 19;
            aList.Add(Temp);
            //Console.WriteLine(Temp);

            Temp = new Fact();
            Temp.Name = "그년";
            Temp.Gender = "여";
            Temp.Age = 19;
            aList.Add(Temp);
            //Console.WriteLine(Temp);

            foreach(var vTemp in aList)
            {
                Console.WriteLine(vTemp);
            }
            aList.Sort();
        }
    }
}
