using System;
public class PropertyTest
{
    private string _name;           // RW
    public string GetName()
    {
        return _name;
    }
    public void SetName(string value)
    {
        _name = value;
    }
    public string Name        // 프로퍼티 Property
    {
        get
        {
            return _name;
        }
        set
        {
            _name = value;
        }
    }

    private int _ReadOnly;          // R
    public int ReadOnly
    {
        get
        {
            return _ReadOnly;
        }
    }


    private int _WriteOnly;         // W
    public int WriteOnly
    {
        set
        {
            _WriteOnly = value;
        }
    }

    private static int _Static;     // Static
    static public int Static
    {
        get
        {
            return _Static;
        }
        set
        {
            _Static = value;
        }
    }








}

public class Test
{
    public static void Main(string[] args)
    {
        PropertyTest pt = new PropertyTest();
        pt.Name = "헬로 키티";      // Property의 set 기능 테스트 : write
        Console.WriteLine(pt.Name); // Property의 get 기능 테스트 : read
        Console.WriteLine(pt.ReadOnly);
        //pt.ReadOnly = 100;
        pt.WriteOnly = 100;
        //Console.WriteLine(pt.WriteOnly);
        PropertyTest.Static = 200;
        Console.WriteLine(PropertyTest.Static);
    }

}