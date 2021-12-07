using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//bodova) Napišite program koji će zatražiti od korisnika da unese tri
//dvoznamenkasta broja te će izračunati i ispisati najveći od tri broja (npr. 12,17,15 ->
//17).

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int y, x, z;
            Console.WriteLine("Upisite 3 dvoznamenkasta broja.");
            y= Convert.ToInt32  (Console.ReadLine());
            x= Convert.ToInt32(Console.ReadLine());
            z= Convert.ToInt32(Console.ReadLine());

            if (x > z && x > y)
            {
                Console.WriteLine(x + " je najveći broj");
            }
            if (z > x && z > y)
            {
                Console.WriteLine(z + " je najveći broj");
            }
            if (y > z && y > z)
            {
                Console.WriteLine(y + " je najveći broj!!!");
            }
            Console.ReadKey();

        }
    }
}
