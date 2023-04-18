using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

using System.Linq.Expressions;

using System.Text;
using System.Threading.Tasks;

namespace Statki_projekt
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Tablica t = new Tablica();
            Uzytkownicy u = new Uzytkownicy(new int[5,5], new int[5,5]);
            Uzytkownicy u2 = new Uzytkownicy(new int[5, 5], new int[5, 5]);
            for (int i = 1; i <= 3; i++) {
                Console.WriteLine("Statek: " + i);
                Console.WriteLine("Podaj x:");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("Podaj y:");
                int y = int.Parse(Console.ReadLine());
                
                Console.WriteLine("Podaj kierunek:");
                int kierunek = int.Parse(Console.ReadLine());
                t.Dodaj(u.Plansza, x, y, i, kierunek);
                Console.Clear();
                t.pokaz(u.Plansza);
            }
            Console.Clear();
            t.pokaz(u.Plansza);
            //t.strzal(u.strzaly, u.plansza, 0, 0);
            Console.ReadKey();


           

            //for (int i = 0; i < 2; i++) 
            //{
            //    Console.Write(statki.statekwsp[0,i] + ", ");
            //}
            //Console.WriteLine();
            //for (int i = 0; i < 4; i++)
            //{
            //    Console.Write(statki.statekwsp[1, i] + ", ");
            //}
            //Console.WriteLine();
            //for (int i = 0; i < 6; i++)
            //{
            //    Console.Write(statki.statekwsp[2, i] + ", ");
            //}
            Console.WriteLine();

            Console.ReadKey();

        }
        
    }
}
