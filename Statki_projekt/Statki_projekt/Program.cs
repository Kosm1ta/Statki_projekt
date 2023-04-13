using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Statki_projekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tablica t = new Tablica();
            Uzytkownicy u = new Uzytkownicy();

            t.Dodaj(u.plansza, new Statki());
            t.pokaz(u.plansza);
            Console.ReadKey();

        }
        
    }
}
