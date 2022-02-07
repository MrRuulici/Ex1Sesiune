using System;

namespace Ex1Sesiune
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[Convert.ToInt32(Console.ReadLine())];
            int i;
            for (i = 0; i < a.Length; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(Recursivitate.Suma(a, a.Length - 1));
        }
    }
}
