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
            
        }
    }
}