using System;


class Car
{
    //속성(attribute) - 변수 등으로 표현
    public int Speed; //속도:숫자 =>int
    private const int SpeedValue = 10;
    private const int SpeedLimit = 200;

    //행위(behavior) - 메소드로 표현
    public void Run()
    {
        Console.WriteLine("달립니다.");
    }
    
    public void Accel()
    {
        Speed = Speed + SpeedValue;
        if(Speed>SpeedLimit)
        {
            Speed = SpeedLimit;
        }
        Console.WriteLine("현재 속도는 {0}입니다.", Speed);
    }

    public void Break()
    {
        Speed = Speed - SpeedValue;
        if(Speed<0)
        {
            Speed = 0;
        }
        Console.WriteLine("현재 속도는 {0}입니다.", Speed);
    }
}
class Auto
{
    static void Main(string[] args)
    {
        Car aCar=new Car();
        aCar.Run();
        aCar.Accel();
        aCar.Accel();
        aCar.Accel();

    }
    static void Main1(string[] args)
    {
        //Car aCar;
        //aCar = new Car(); //객체생성
        //aCar.Run();
        //aCar.Speed = 0;
        //Console.WriteLine("aCar의 속도는 {0}입니다.", aCar.Speed);
        //Console.WriteLine("aCar의 속도는 " + aCar.Speed + "입니다.");
    }

}
