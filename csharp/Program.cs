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

            Console.WriteLine("Adj meg egy hónap számát [1-12]: ");
            int honap = int.Parse(Console.ReadLine());
            if (honap >= 3 && honap <= 5)
            {
                Console.WriteLine("Tavasz van.");
            }
            else if (honap >= 6 && honap <= 8)
            {
                Console.WriteLine("Nyár van.");
            }
            else if (honap >= 9 && honap <= 11)
            {
                Console.WriteLine("Ősz van.");
            }
            else if (honap == 12 || honap == 1 || honap == 2)
            {
                Console.WriteLine("Tél van.");
            }
            else
            {
                Console.WriteLine("Hibás hónap szám.");
            }
            {
                
            }
        }
    }
}
