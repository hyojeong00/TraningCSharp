using System;

class Coordinate
{
    public int x;
    public int y;
}

class ConsoleApplication
{
    static void Main(string[] args)
    {
        Coordinate c1 = new Coordinate();
        Coordinate c2 = new Coordinate();

        c1.x = 1;
        c1.x = 2;
        c2.x = 1;
        c2.x = 2;

        Console.WriteLine("c1 = {0}, {1}", c1.x, c1.y);
        Console.WriteLine("c2 = {0}, {1}", c2.x, c2.y);

        if (c1 == c2)
        {
            Console.WriteLine("같다");
        }
        else
        {
            Console.WriteLine("다르다");
        }

        c1 = c2;
        if (c1 == c2)
        {
            Console.WriteLine("같다");
        }
        else
        {
            Console.WriteLine("다르다");
        }

        Console.WriteLine("c1 = {0}, {1}", c1.x, c1.y);
        Console.WriteLine("c2 = {0}, {1}", c2.x, c2.y);

        c1.x = 100;

        Console.WriteLine("c1 = {0}, {1}", c1.x, c1.y);
        Console.WriteLine("c2 = {0}, {1}", c2.x, c2.y);

    }










    static Coordinate test()
    {
        Coordinate temp = new Coordinate();

        return temp;

    }
    static void Main1(string[] args)
    {
        Coordinate c = test();
        c.x = 1;
        c.y = 2;
        Console.WriteLine("c = {0}, {1}", c.x, c.y);
        c = null;

        if (null == c)
        {
            Console.WriteLine("c가 널을 가지고 있잖아. 확인하고 쓰셈!!!");
        }

        try
        {
            c.x = 1;
        }
        catch (NullReferenceException)
        {
            Console.WriteLine("c가 널을 가지고 있잖아. 확인하고 쓰셈");
        }
    }
}