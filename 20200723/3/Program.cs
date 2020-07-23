﻿using System;

public class Mathmatics
{
    delegate int CalcDelegate(int x, int y);

    static int Add(int x, int y)
    {
        return x + y;
    }
    static int Subtract(int x, int y)
    {
        return x - y;
    }
    static int Multiply(int x, int y)
    {
        return x * y;
    }
    static int Divide(int x, int y)
    {
        return x / y;
    }

    CalcDelegate[] methods;

    public Mathmatics()
    {
        //static 메서드를 가리키는 델리게이트 배열 초기화
        methods = new CalcDelegate[] { Mathmatics.Add, Mathmatics.Subtract, Mathmatics.Multiply, Mathmatics.Divide };
    }

    //methods 배열에 담긴 델리게이트를 opCode 인자에 따라 호출
    public void Calculate(char opCode, int operand1, int operand2)
    {
        switch(opCode)
        {
            case '+':
                Console.WriteLine("+: " + methods[0](operand1, operand2));
                break;
            case '-':
                Console.WriteLine("-: " + methods[1](operand1, operand2));
                break;
            case '*':
                Console.WriteLine("*: " + methods[2](operand1, operand2));
                break;
            case '/':
                Console.WriteLine("/: " + methods[3](operand1, operand2));
                break;
        }
    }
}

namespace ConsoleApp1
{
    class Program
    {
        //3개의 매개변수를 받고 void를 반환하는 델리게이트 정의
        //매개변수의 타입이 중요할 뿐 매개변수의 이름은 임의로 정할 수 있음
        delegate void WorkDelegate(char arg1, int arg2, int arg3);

        static void Main(string[] args)
        {
            Mathmatics math = new Mathmatics();
            WorkDelegate work = math.Calculate;

            work('+', 10, 5);
            work('-', 10, 5);
            work('*', 10, 5);
            work('/', 10, 5);
        }
    }
}