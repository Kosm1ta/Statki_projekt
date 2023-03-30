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

        public void Dodaj(int[,] plansza, int x, int y, int kierunek, int statek)
        {
            for(int i = 0; i < statek; i++)
            {
                if(kierunek == 0)
                {
                    if(y-1+i < 3+i)
                        plansza[y-1 + i, x-1] = statek;
                    for(int j = -1;  j <= statek; j++)
                    {
                        for(int p = -1; p < 2; p++)
                        {
                            if (y-1 + j > 0 || y-1 + j < 5 || x-1 + p > 0 || x-1 + p < 5)
                            {
                                if (plansza[y-1 + j, x-1 + p] == 0)
                                {

                                    plansza[y-1 + j, x-1 + p] = -1;
                                }
                            }
                               
                        }
                        
                        
                    }
                    
                }
            }
        }
        public void pokaz(int[,] plansza)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {

                    if (plansza[i, j] == -1)
                        Console.Write('l');
                    if(plansza[i, j] == 0)
                        Console.Write('-');
                    if (plansza[i, j] == 3)
                        Console.Write('+');




                }
                Console.WriteLine();
            }
        }
    }
}
