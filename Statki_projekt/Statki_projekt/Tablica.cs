using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statki_projekt
{
    internal class Tablica
    {
        public Tablica() { }
        Statki s = new Statki();
        public int[,] Plansza = new int[5,5];

        public void Dodaj()
        {
           
            
            for (int i = 0; i < s.statek2wsp.Length - 1; i+=2)
            {

                Plansza[s.statek2wsp[i], s.statek2wsp[i+1]] = 1;

            }
            for (int i = 0; i < s.statek1wsp.Length - 1; i += 2)
            {

                Plansza[s.statek1wsp[i], s.statek1wsp[i + 1]] = 1;

            }
            for (int i = 0; i < s.statek3wsp.Length - 1; i += 2)
            {

                Plansza[s.statek3wsp[i], s.statek3wsp[i + 1]] = 1;

            }



        }
        public void pokaz(int[,] plansza)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {

                    
                    if(plansza[i, j] == 0)
                        Console.Write('-');
                    else
                        Console.Write('+');




                }
                Console.WriteLine();
            }
        }
    }
}
