using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

//class Test
//{
//    private string[] _array = new string[5];

//    public string this[int Index]
//    {
//        get { return _array[Index]; }
//        set { _array[Index] = value; }
//    }

//    static void Main(string[] args)
//    {
//        Test aTest = new Test();

//        aTest[0] = "할룽a";
//        aTest[1] = "할룽b";
//        aTest[2] = "할룽c";
//        aTest[3] = "할룽d";
//        aTest[4] = "할룽e";
//        Console.WriteLine(aTest[3]); 
//    }
//}

class TestInt
{
    private int[] _array = new int[5];

    public int this[int Index]
    {
        get { return _array[Index]; }
        set { _array[Index] = value; }
    }

    static void Main(string[] args)
    {
        TestInt aTestInt = new TestInt();

        aTestInt[0] = 1;
        aTestInt[1] = 2;
        aTestInt[2] = 3;
        aTestInt[3] = 4;
        aTestInt[4] = 5;
        Console.WriteLine(aTestInt[3]);
    }
}

