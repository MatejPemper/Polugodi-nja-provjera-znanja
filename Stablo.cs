/*
 * Definirajte klasu Stablo sa sljedećim članicama:
a. varijabla tipa bool otpadajuListovi
b. varijabla tipa string vrstaStabla
c. svojstvo OtpadajuListovi (get() i set())
d. konstruktor Stablo(bool) koji će dodijeliti vrijednost proslijeđenog argumenta
varijabli otpadajuListovi
e. override metode ToString()
Definirajte objekt stablo1 tipa Stablo pomoću konstruktora te proslijedite vrijednost
false. Definirajte objekt stablo2 tipa Stablo pomoću konstruktora te proslijedite
vrijednost true.
Ispišite podatke o objektima koristeći ToString() metodu, na način da ukoliko je
vrijednost varijable otpadajuListovi true, vrijednost varijable vrstaStabla je
bijelogorično, a ukoliko je vrijednost varijable otpadajuListovi false, vrijednost
varijable vrstaStabla je crnogorično.
*/

namespace ConsoleApp2
{
    internal partial class Program
    {
        class Stablo {
            public bool OtpdajuListovi;
            public string vrstaStabla;

            public Stablo{
              public bool OtpadajuListovi = true;
        }
        }

    }
}
