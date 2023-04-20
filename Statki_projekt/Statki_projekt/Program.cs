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
            try
            {
                Tablica t = new Tablica();
            
                List<Uzytkownicy> gracze = new List<Uzytkownicy>() { new Uzytkownicy(new int[5, 5], new int[5, 5], new List<Statki>(), new int[] {0,0,0}), new Uzytkownicy(new int[5, 5], new int[5, 5], new List<Statki>(), new int[] { 0, 0, 0 }) };

                int i = 1;
                int j = 0;
                bool wygrana = false;

            
                t.Start(gracze);
                while (!wygrana)
                {
                    t.strzal(gracze[i], gracze[j]);
                }


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
            }catch (Exception e) 
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();

        }
        
    }
}
