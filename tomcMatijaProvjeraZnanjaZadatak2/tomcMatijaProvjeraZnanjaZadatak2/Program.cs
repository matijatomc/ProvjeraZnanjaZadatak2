using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tomcMatijaProvjeraZnanjaZadatak2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite 3 broja odvojena zarezom bez razlomka: ");
            string unos = Console.ReadLine();

            int prviBroj = Convert.ToInt32(unos.Substring(0, 2));
            string unos1 = unos.Remove(0, 3);
            int drugiBroj = Convert.ToInt32(unos1.Substring(0, 2));
            string unos2 = unos1.Remove(0, 3);
            int treciBroj = Convert.ToInt32(unos2.Substring(0, 2));

            if(prviBroj > drugiBroj && prviBroj > treciBroj)
            {
                Console.WriteLine("Najveći broj je: " + prviBroj);
            }
            else if (drugiBroj > prviBroj && drugiBroj > treciBroj)
            {
                Console.WriteLine("Najveći broj je: " + drugiBroj);
            }
            else if (treciBroj > prviBroj && treciBroj > drugiBroj)
            {
                Console.WriteLine("Najveći broj je: " + treciBroj);
            }
            else
            {
                Console.WriteLine("Svi brojevi su isti");
            }
            
            Console.ReadKey();
        }
    }
}
