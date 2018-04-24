using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            for (int i = 2; i < 50; ++i)
                Console.WriteLine(i + ": " + EsPrimo(i));
        }
        public static bool EsPrimo(int i)
        {
            int p = 2;
            if (i == 0 || i == 1 || i < 0)
                return false;
            while ((p * p <= i) && (i % p) != 0)
                ++p;
            return p * p > i;
        }
    }
}
