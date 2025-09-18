using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Adj meg egy számot: ");
            int szam = int.Parse(Console.ReadLine());

            if (szam % 2 == 0)
            {
                Console.WriteLine("A szám páros.");
            }
            else
            {
                Console.WriteLine("A szám páratlan.");
            }

            Console.WriteLine("Adj meg egy számot: ");
            int szam2 = int.Parse(Console.ReadLine());

            if (szam2 > 0)
            {
                Console.WriteLine("A szám pozitív.");
            }
            else if (szam2 < 0)
            {
                Console.WriteLine("A szám negatív.");
            }
            else
            {
                Console.WriteLine("A szám nulla.");
            }
            {
                
            }
        }
    }
}
