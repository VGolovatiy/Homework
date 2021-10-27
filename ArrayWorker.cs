using System;

namespace ClassLibrary
{
    public class ArrayWorker

    {
        public void InvMass(int[] arr)
        {
            Array.Reverse(arr);
        }
        
        public void InvMass2(ref int[] arr, int newValue, int index)
        {
            int[] newArray = new int[arr.Length + 1];
            newArray[index] = newValue;
            for (int i = 0; i < index; i++)
                newArray[i] = arr[i];
            for (int i = index; i < arr.Length; i++)
                newArray[i+1] = arr[i];
            arr = newArray;


        }
        
    }
    public class Cone
    {
        double radius;
        double height;
        double pi = Math.PI;
        double result;
        public Cone(int r, int h)
        {
            radius = r;
            height = h;
        }
        public double PlPovOsn(int r, int h)
        {
            result = 2 + pi + r * h;
            return result;
        }
        public double PolnPl(int r, int h)
        {
            result = 2 * pi * r * (r + h);
            return result;
        }
    }
}
