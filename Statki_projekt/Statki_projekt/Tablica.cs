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
        
        public void Dodaj(int[,] plansza, int x, int y, int statek, int kierunek)
        {
            
            if(kierunek == 0)
            {
                if (x - 1 >= 0 && y - 1 >= 0 && x <= 4 && y <= 4 && x+statek-1 <= 4)
                {
                    for (int i = 0; i < statek; i++)
                    {
                        plansza[y - 1, x - 1+i] = statek;
                    }
                }
               
            }
            else
            {

            }

            //for (int i = 0; i < 6; i += 2)
            //{
            //    if(plansza[s.statekwsp[2, i] - 1, s.statekwsp[2, i + 1] - 1] != -1)
            //         plansza[s.statekwsp[2, i] - 1, s.statekwsp[2, i + 1] - 1] = 1;

            //}
            //if (s.statekwsp[2, 1] != s.statekwsp[2, 3])
            //{
            //    for (int i = 0; i < 4; i += 2)
            //    {
            //        for (int a = -1; a <= 2; a++)
            //        {
            //            for (int j = -1; j < 2; j++)
            //            {
            //                if (plansza[s.statekwsp[2, i] - 1 + j, s.statekwsp[2, i] - 1 + a] == 0)
            //                    plansza[s.statekwsp[2, i] - 1 + j, s.statekwsp[2, i] - 1 + a] = -1;
            //            }
            //        }

            //    }

            //}
        }
            public void pokaz(int[,] plansza)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {

                    
                    if(plansza[i, j] == 0)
                        Console.Write('-');
                    else if (plansza[i, j] == -1)
                        Console.Write('o');
                    else
                    {
                        Console.Write('+');
                    }




                }
                Console.WriteLine();
            }
        }
        public void strzal(int[,] strzal, int[,] plansza,int x, int y)
        {
            if (strzal[x, y] == 0)
            {
                if (plansza[x, y] != 0)
                {
                    strzal[x, y] = 1;
                    Console.WriteLine("trafiony");
                }
                
            }
        }
    }
}
