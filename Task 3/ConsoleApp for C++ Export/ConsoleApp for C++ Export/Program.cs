using System;
using System.Runtime.InteropServices;

class Program
{
    [DllImport("CppMath.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern int Multiple(int a, int b);

    static void Main()
    {
        int result = Multiple(5, 7);
        Console.WriteLine("5 * 7 = " + result);
    }
}