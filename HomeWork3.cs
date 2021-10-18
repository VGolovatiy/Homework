using System;

namespace ConsoleApp3
{
    class Program
    { 
        static void Main(string[] args)
        {
            double pi = Math.PI;
            double r = double.Parse(Console.ReadLine());
            double l = double.Parse(Console.ReadLine());
            double s = pi * r *(r + l); 
            Console.WriteLine(s);

            int x = 14, y = 1,  z = 5;
            x += y - x++ * z;
            Console.WriteLine($"Result 1 operation: x={x}\ty={y}\tz={z}");
            z = --x - y * 5;
            Console.WriteLine($"Result 2 operation: x={x}\ty={y}\tz={z}");
            y /= x + 5 % z;
            Console.WriteLine($"Result 3 operation: x={x}\ty={y}\tz={z}");
            z = x++ + y * 5;
            Console.WriteLine($"Result 4 operation: x={x}\ty={y}\tz={z}");
            x = y - x++ * z;
            Console.WriteLine($"Result 5 operation: x={x}\ty={y}\tz={z}");
        }
    }
}
