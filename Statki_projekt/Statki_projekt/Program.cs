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
            
            List<Uzytkownicy> gracze = new List<Uzytkownicy>() { new Uzytkownicy(1,new int[5, 5], new int[5, 5], new List<Statki>(), new int[] {0,0,0}), new Uzytkownicy(2,new int[5, 5], new int[5, 5], new List<Statki>(), new int[] { 0, 0, 0 }) };

            int i = 1;
            int j = 0;
            bool wygrana = false;

            
            t.Start(gracze);
            while (!wygrana)
            {
                if (i == 1)
                {
                    i = 0;
                    j = 1;
                }
                else
                {
                    i = 1;
                    j = 0;
                }
                t.strzal(gracze[i], gracze[j]);
                wygrana = t.Wygrana(gracze[i]);
                
            }
            Console.Clear();
            Console.WriteLine("Wygrał gracz: " + gracze[i].ID);
            Console.ReadKey();

        }
        
    }
}
