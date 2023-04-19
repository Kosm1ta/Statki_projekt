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
        
        public void Dodaj(int[,] plansza, int x, int y, int statek, int kierunek,Uzytkownicy u)
        {
            
            if(kierunek == 0)
            {
                if (x - 1 >= 0 && y - 1 >= 0 && x-1 <= 4 && y - 1 <= 4 && x+statek-2 <= 4)
                {
                    for (int i = 0; i < statek; i++)
                    {
                        plansza[y - 1, x - 1+i] = statek;
                    }
                    for (int i = -1; i <= statek; i++)
                    {
                        for (int j = -1; j < 2; j++)
                        {
                            if(y-1+j >= 0 && y-1+j <= 4 && x-1+i >= 0 && x-1+i <= 4)
                            {
                                if (plansza[y - 1 + j, x - 1 + i] == 0)
                                    plansza[y - 1 + j, x - 1 + i] = -1;
                            }
                        }
                    }
                    u.Statki.Add(new Statki(x, y, kierunek));
                }
               
            }
            else
            {
                if (x - 1 >= 0 && y - 1 >= 0 && x-1 <= 4 && y-1 <= 4 && y + statek - 2 <= 4)
                {
                    for (int i = 0; i < statek; i++)
                    {
                        plansza[y - 1 + i, x - 1] = statek;
                    }
                    for (int i = -1; i <= statek; i++)
                    {
                        for (int j = -1; j < 2; j++)
                        {
                            if (y - 1 + i >= 0 && y - 1 + i <= 4 && x - 1 + j >= 0 && x - 1 + j <= 4)
                            {
                                if (plansza[y - 1 + i, x - 1 + j] == 0)
                                    plansza[y - 1 + i, x - 1 + j] = -1;
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
        public void strzal(int[,] strzal, int[,] plansza)
        {
            Console.WriteLine("Strzał: ");
            Console.WriteLine("\nPodaj X:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj Y:");
            int y = int.Parse(Console.ReadLine());
            if (strzal[y-1, x-1] == 0)
            {
                if (plansza[y-1, x - 1] != 0 && plansza[y - 1, x - 1] != -1)
                {
                    strzal[y-1,x - 1] = 1;
                    Console.WriteLine("trafiony");
                }
                else
                    Console.WriteLine("Pudło");
            }
        }
        
    }
}
