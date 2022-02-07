using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1Sesiune
{
    public class Recursivitate
    {
        public static int Suma(int[] a, int n)
        {
            if (n == 0)
                return a[n];
            else
                return a[n] + Suma(a, n - 1);
        }
        
    }
}
