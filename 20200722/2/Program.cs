using System;

class TestInt // 6개짜리 인덱서로 작성
{
    private int[] _array = new int[5];

    public int this[int Index]
    {
        get
        {
            return _array[Index];
        }
        set
        {
            _array[Index] = value;
        }

    }
}
class Test
{
    private string[] _array = new string[5];

    public string this[int Index]      // 인덱서 Indexer
    {
        get
        {
            return _array[Index];
        }
        set
        {
            _array[Index] = value;
        }

    }
}


class Program
{
    static void Main(string[] args)
    {
        int[] array = new int[5];
        array[0] = 100;

        Test aTest = new Test();
        aTest[0] = "할룽a";
        aTest[1] = "할룽b";
        aTest[2] = "할룽c";
        aTest[3] = "할룽d";
        aTest[4] = "할룽e";
        Console.WriteLine(aTest[2]);

        TestInt aTestInt = new TestInt();
        aTestInt[0] = 100;
        aTestInt[1] = 200;
        aTestInt[2] = 300;
        aTestInt[3] = 400;
        aTestInt[4] = 500;
        Console.WriteLine(aTestInt[2]);
    }
}