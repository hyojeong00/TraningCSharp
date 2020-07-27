using System;
using System.Runtime.InteropServices;

class Params
{
    // [DllImport("user32.dll")]
    [DllImport("KERNEL32.dll")]
    // static public extern void MessageBeep(int a, int b);
    static public extern void Beep(int a, int b);

    static int Add(params int[] values)
    {
        int result = 0;

        for (int i = 0; i < values.Length; i++)
        {
            result += values[i];
        }
        return result;
    }



    static void Main(string[] args)
    {
        Console.WriteLine(Add(1, 2, 3, 4, 5));
        Console.WriteLine(Add(1, 2, 3, 4, 5, 6, 7, 8, 9, 10));

        Beep(512, 200);
        Beep(640, 200);
        Beep(768, 200);
    }
}