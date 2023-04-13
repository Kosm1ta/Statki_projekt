using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statki_projekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tablica tablica = new Tablica();
            Statki s;
            
            tablica.Dodaj();
            tablica.pokaz(tablica.Plansza);

            Console.ReadKey();

        }
        
    }
}
