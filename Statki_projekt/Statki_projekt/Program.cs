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
            
            List<Uzytkownicy> gracze = new List<Uzytkownicy>() { new Uzytkownicy(new int[5, 5], new int[5, 5], new List<Statki>()), new Uzytkownicy(new int[5, 5], new int[5, 5], new List<Statki>())};
            
            
            for(int j = 1; j <= 2; j++) { 
                for (int i = 1; i <= 3; i++) {
                    Console.WriteLine("Gracz: " + j);
                    Console.WriteLine("\nStatek: " + i);
                    Console.WriteLine("Podaj x:");
                    int x = int.Parse(Console.ReadLine());
                    Console.WriteLine("Podaj y:");
                    int y = int.Parse(Console.ReadLine());

                    if (i == 1)
                        t.Dodaj(gracze[j-1].Plansza, x, y, i, 0, gracze[j-1]);
                    else{
                        Console.WriteLine("Podaj kierunek:");
                        int kierunek = int.Parse(Console.ReadLine());
                        t.Dodaj(gracze[j - 1].Plansza, x, y, i, kierunek, gracze[j - 1]);
                    }
                    

                 Console.Clear();
                    Console.WriteLine("Plansza gracza: " + j);
                t.pokaz(gracze[j-1].Plansza);
                }
                Console.ReadKey();
                Console.Clear();

            }

            
           
            t.strzal(gracze[1].Strzaly, gracze[0].Plansza);

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
