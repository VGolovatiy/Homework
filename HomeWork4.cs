using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
           int Chislo = int.Parse(Console.ReadLine());
            if (Chislo >= 0 && Chislo <= 30)
                Console.WriteLine("Chislo v diapazone ot 0 do 30");
            else if (Chislo > 30 && Chislo <= 60)
                Console.WriteLine("Chislo v diapazone ot 31 do 60");
            else if (Chislo > 60 && Chislo <= 100)
                Console.WriteLine("Chislo v diapazone ot 61 do 100");
            else 
                Console.WriteLine("Ya takogo chisla ne znajy");

            int a = 201;
            while (a < 500)
            {
                if (a % 17 ==0)
                    Console.Write($"{a},");
                a++;
            }


        }
    }
}
