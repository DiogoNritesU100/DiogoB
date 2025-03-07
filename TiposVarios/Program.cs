// See https://aka.ms/new-console-template for more information
using System;
using System.Text;

namespace TiposVarios;
internal class Program
{
    private static void Main(string[] args)
    {
        {
            Console.OutputEncoding = Encoding.UTF8;

            int a = 5;
            uint b = 5u;
            long c = 5;
            byte d = 3;


            Console.Write(a);
            Console.Write(b);
            Console.Write(c);
            Console.Write(d);

            char copySym = '\u00A9';
            char weird = '\u07D0';

            Console.WriteLine(copySym);
            Console.WriteLine(weird);

            float f = 3.455f;
            double g = 1.2e2; // 1.2 x 10^2 = 120
            double h = 444.4;
            decimal i = 4981.33m;

            Console.WriteLine(f);
            Console.WriteLine(g);
            Console.WriteLine(h);
            Console.WriteLine(i);

            bool b1 = true;
            bool b2 = f > g;

            Console.WriteLine(b1);
            Console.WriteLine(b2);
            

        }
    }
}