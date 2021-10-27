using System;
using ClassLibrary;

namespace ConsoleApp5_libl
{
    class Program
    {
        static void Main(string[] args)
        {
            int index = 1;
            int newValue = 5;
            ArrayWorker aw = new ArrayWorker();
            int[] myArray = new int[] { 4, 8, 15, 16, 23, 42 };
            aw.InvMass(myArray);
            aw.InvMass2(ref myArray, newValue, index);









        }
    }
}
