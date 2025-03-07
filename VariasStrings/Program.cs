using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int x = 123;
        int y = -123;

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

    }
}