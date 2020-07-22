using System;

class Car
{
    public string name;
}

class TestCar
{
    private Car[] _array = new Car[5];

    public Car this[int Index]
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
        TestCar aTestCar = new TestCar();
        aTestCar[0] = new Car();
        aTestCar[1] = new Car();
        aTestCar[0].name = "비오는 날에는 소시지빵";
        aTestCar[1].name = "게임은 폭력적이다";
        Console.WriteLine(aTestCar[0].name);
    }
}