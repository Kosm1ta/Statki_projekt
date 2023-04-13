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
        
        public int[,] Plansza = new int[5,5];

        public void uzytkownik(List<int[,]> uzytk)
        {
            uzytk.Add(Plansza);
        }

        public void Dodaj(int[,] plansza, Statki s)
        {
            
            for (int i = 0; i < 1; i++)
            {
                plansza[s.statekwsp[0, i] - 1, s.statekwsp[0, i+1] - 1] = 1;
                
            }
            for (int i = 0; i < 4; i+=2)
            {
                plansza[s.statekwsp[1, i] - 1, s.statekwsp[1, i + 1] - 1] = 1;

            }
            for (int i = 0; i < 6; i += 2)
            {
                plansza[s.statekwsp[2, i] - 1, s.statekwsp[2, i + 1] - 1] = 1;

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
