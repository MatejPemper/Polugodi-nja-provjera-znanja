using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Definirajte klasu KlasaX sa sljedećim članicama:
a. niz tipa int veličine 100 elemenata arr
b. indeks koji će vraćati i postavljati vrijednost svakog pojedinog člana niza arr.
Definirajte objekt x tipa KlasaX, te koristeći indekse dodijelite nizu arr prvih 100
brojeva i ispišite 50. član niza.
*/

namespace ConsoleApp3
{
    internal class Program
    {
        class KlasaX
        {
            public int arr(int[] niz)
            {
                int arr = 0;
                for (int brojac = 0; brojac < niz.Length; brojac++)
                {
                    arr += niz[brojac];
                }
                return arr;
            }



            static void Main(string[] args)
            {
                int[] niz = new int[100];

                KlasaX objekt = new KlasaX();
                Console.WriteLine(" 50 clan niza je: " + niz[49]);

                Console.ReadKey();

            }
        }
    }
}
