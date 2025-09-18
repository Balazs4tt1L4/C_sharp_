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


            Console.WriteLine("Add meg az életkorod: ");
            int eletkor = int.Parse(Console.ReadLine());

            if (eletkor >= 18)
            {
                Console.WriteLine("Szavazhatsz.");
            }
            else
            {
                Console.WriteLine("Nem szavazhatsz.");
            }

            Console.WriteLine("Add meg a jegyed [1-5]: ");
            int jegy = int.Parse(Console.ReadLine());
            if (jegy == 1)
            {
                Console.WriteLine("Elégtelen");
            }
            else if (jegy == 2)
            {
                Console.WriteLine("Elégséges");
            }
            else if (jegy == 3)
            {
                Console.WriteLine("Közepes");
            }
            else if (jegy == 4)
            {
                Console.WriteLine("Jó");
            }
            else if (jegy == 5)
            {
                Console.WriteLine("Jeles");
            }
            else
            {
                Console.WriteLine("Hibás jegy.");
            }

            int kitalaltSzam = 50;
            Console.WriteLine("Találd ki a számot: ");
            int tipp = int.Parse(Console.ReadLine());
            if (tipp < kitalaltSzam)
            {
                Console.WriteLine("A szám nagyobb.");
            }
            else if (tipp > kitalaltSzam)
            {
                Console.WriteLine("A szám kisebb.");
            }
            else
            {
                Console.WriteLine("Eltaláltad a számot!");
            }
            Console.WriteLine("Adj meg egy számot: ");
            int szam3 = int.Parse(Console.ReadLine());
            if (szam3 > 0 && szam3 % 2 == 0)
            {
                Console.WriteLine("A szám pozitív és páros.");
            }
            else
            {
                Console.WriteLine("A szám nem pozitív és páros.");
            }
            Console.WriteLine("Adj meg egy karaktert: ");
            char karakter = Console.ReadLine()[0];
            if (char.IsLetter(karakter))
            {
                Console.WriteLine("Betű.");
            }
            else if (char.IsDigit(karakter))
            {
                Console.WriteLine("Szám.");
            }
            else
            {
                Console.WriteLine("Egyéb karakter.");
            }
            Console.WriteLine("Add meg a jelszót: ");
            string jelszo = Console.ReadLine();

            if (jelszo == "titok123")
            {
                Console.WriteLine("Helyes jelszó.");
            }
            else
            {
                Console.WriteLine("Helytelen jelszó.");
            }


            {
                
            }
        }
    }
}
