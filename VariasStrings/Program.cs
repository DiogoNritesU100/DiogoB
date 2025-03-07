using System;
using System.Xml.Schema;

internal class Program
{
    private static void Main(string[] args)
    {
        int x = 123;
        int y = -123;
        double z = 0.44;
        double xx = 1.23456;
        int ii = 19;

        Console.WriteLine("Hello, World!");
        Console.WriteLine(@"\nHello, World!\n");
        Console.WriteLine("\u07F7\u08F2");
        Console.WriteLine(@"\u07F7\u08F2");
        Console.WriteLine("\" This is in double quotes\"");
        Console.WriteLine(@"""This is in double quotes""");
        
        Console.WriteLine("a" + 2);
        Console.WriteLine("abc" + x);
        
        string myStr = $"valor de x e {x}";
        Console.WriteLine(myStr);
        myStr  = $"{x} mais {y} e igual a {x + y}";
        Console.WriteLine(myStr);

        myStr = string.Format("Y é {1}, X é {0}", x , y);
        Console.WriteLine(myStr);
        Console.WriteLine("Y é {1}, X é {0}", x , y);

        Console.WriteLine("Valor é {0,-10:f3}!!", 1.3453453453);
        
        Console.WriteLine($"x em hex = {x:X}");
        Console.WriteLine($"x em hex = {x:x}");

        Console.WriteLine($"z = {z}");
        Console.WriteLine($"z = {z:p}");
        Console.WriteLine($"z = {z:c}");

        Console.WriteLine("Valor é {0:f2}!!", 1.23456);
        Console.WriteLine($"xx = {xx:p}");
        
        Console.WriteLine($"ii em hex = {ii:X}");
        Console.WriteLine($"ii = {ii:c}");
        
    }
}