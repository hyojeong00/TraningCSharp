using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        delegate int Calculator(int Num1,int Num2);
        
        static int Add(int iNum1,int iNum2)
        {
            return iNum1 + iNum2;
        }
        static int Div(int iNum3,int iNum4)
        {
            return iNum3 / iNum4;
        }
        static int Sub(int iNum5,int iNum6)
        {
            return iNum5 - iNum6;
        }
        static int Mul(int iNum7, int iNum8)
        {
            return iNum7 * iNum8;
        }
        static void Main(string[] args)
        {
            int iResult;
            Calculator[] aCalculator = new Calculator[] { Add, Sub, Mul, Div };
            for(int i=0;i<aCalculator.Length;++i)
            {
                iResult = aCalculator[i](3, 4);
                Console.WriteLine(iResult);
            }
            foreach(Calculator Temp in aCalculator)
            {
                iResult = Temp(3, 4);
                Console.WriteLine(iResult);
            }

            iResult = Add(3, 4);
            Console.WriteLine(iResult);

            iResult = Sub(3, 4);
            Console.WriteLine(iResult);

            iResult = Mul(3, 4);
            Console.WriteLine(iResult);

            iResult = Div(3, 4);
            Console.WriteLine(iResult);
        }
    }
}
