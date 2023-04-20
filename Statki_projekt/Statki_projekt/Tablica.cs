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
                    if (plansza[y-1,x-1] == 0 && plansza[y-1,x+statek-2] == 0)
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
                                    plansza[y - 1 + j, x - 1 + i] = -2;
                            }
                        }
                    }
                    }
                    u.Statki.Add(new Statki(x, y, kierunek));
                }
               
            }
            else
            {
                if (x - 1 >= 0 && y - 1 >= 0 && x - 1 <= 4 && y - 1 <= 4 && y + statek - 2 <= 4)
                {
                    if (plansza[y - 1, x - 1] == 0 && plansza[y + statek - 2, x - 1] == 0)
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
                                    plansza[y - 1 + i, x - 1 + j] = -2;
                            }
                        }
                    }
                    }
                    u.Statki.Add(new Statki(x, y, kierunek));
                }
            }

            
        }
        public void Start(List<Uzytkownicy> gracze)
        {
            for (int j = 1; j <= 2; j++)
            {
                for (int i = 1; i <= 3; i++)
                {
                    if(i == 1)
                        Console.WriteLine("\nGracz: " + j);
                    Console.WriteLine("\nStatek: " + i);
                    Console.WriteLine("Podaj x:");
                    int x = int.Parse(Console.ReadLine());
                    Console.WriteLine("Podaj y:");
                    int y = int.Parse(Console.ReadLine());

                    if (i == 1)
                        Dodaj(gracze[j - 1].Plansza, x, y, i, 0, gracze[j - 1]);
                    else
                    {
                        Console.WriteLine("Podaj kierunek:");
                        int kierunek = int.Parse(Console.ReadLine());
                        Dodaj(gracze[j - 1].Plansza, x, y, i, kierunek, gracze[j - 1]);
                    }


                    Console.Clear();
                    Console.WriteLine("Plansza gracza: " + j);
                    pokaz(gracze[j - 1].Plansza);
                }
                Console.ReadKey();
                Console.Clear();

            }
        }
            public void pokaz(int[,] plansza)
            {
            Console.WriteLine("\n  1 2 3 4 5");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(i + 1 + " ");
                for (int j = 0; j < 5; j++)
                {
                    

                    if (plansza[i, j] == 1 || plansza[i, j] == 2 || plansza[i, j] == 3)
                        Console.Write("+ ");
                    else if (plansza[i, j] == -1)
                        Console.Write("o ");
                    else if(plansza[i, j] == 5)
                        Console.Write("x ");
                    else
                    {
                        Console.Write("- ");
                    }




                }
                Console.WriteLine();
            }
        }
        public void strzal(Uzytkownicy strzal, Uzytkownicy plansza)
        {
            bool trafiony = false;
            do
            {
                
                trafiony = false;
                Console.WriteLine("\nStrzał gracza " + strzal.ID + ":");
                Console.WriteLine("\nPodaj X:");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("Podaj Y:");
                int y = int.Parse(Console.ReadLine());
                if (strzal.Strzaly[y - 1, x - 1] == 0)
                {
                    if (plansza.Plansza[y - 1, x - 1] != 0 && plansza.Plansza[y - 1, x - 1] != -2)
                    {
                        strzal.Strzaly[y - 1, x - 1] = 1;
                        strzal.StatkiTrafione[plansza.Plansza[y - 1, x - 1] - 1]++;
                        Console.WriteLine("trafiony");
                        trafiony = true;

                    }
                    else
                        Console.WriteLine("Pudło");
                }
                if (strzal.StatkiTrafione[0] == 1)
                {
                    Console.WriteLine("Zatopiony!");
                    strzal.StatkiTrafione[0]++;
                    Oznaczenie(1, plansza, strzal);
                }
                if (strzal.StatkiTrafione[1] == 2)
                {
                    Console.WriteLine("Zatopiony!");
                    strzal.StatkiTrafione[1]++;
                    Oznaczenie(2, plansza, strzal);
                }
                if (strzal.StatkiTrafione[2] == 3)
                {
                    Console.WriteLine("Zatopiony!");
                    strzal.StatkiTrafione[2]++;
                    Oznaczenie(3, plansza, strzal);
                }

                pokaz(strzal.Strzaly);
            } while (trafiony && !Wygrana(strzal));
            
        }
        public void Oznaczenie(int statek, Uzytkownicy plansza, Uzytkownicy gracz)
        {
            
            int x = plansza.Statki[statek - 1].X;
            int y = plansza.Statki[statek - 1].Y;
            
            int kierunek = plansza.Statki[statek - 1].Kierunek;
             if(kierunek == 0) { 
                for (int i = -1; i <= statek; i++)
                {
                    for (int j = -1; j < 2; j++)
                    {
                        if (y - 1 + j >= 0 && y - 1 + j <= 4 && x - 1 + i >= 0 && x - 1 + i <= 4)
                        {
                            if (gracz.Strzaly[y - 1 + j, x - 1 + i] == 0)
                                gracz.Strzaly[y - 1 + j, x - 1 + i] = -1;
                        }
                    }
                }
                for (int i = 0; i < statek; i++)
                    gracz.Strzaly[y - 1, x - 1+i] = 5;
             }
            else
            {
                for (int i = -1; i <= statek; i++)
                {
                    for (int j = -1; j < 2; j++)
                    {
                        if (y - 1 + i >= 0 && y - 1 + i <= 4 && x - 1 + j >= 0 && x - 1 + j <= 4)
                        {
                            if (gracz.Strzaly[y - 1 + i, x - 1 + j] == 0)
                                gracz.Strzaly[y - 1 + i, x - 1 + j] = -1;
                        }
                    }
                }
                for (int i = 0; i < statek; i++)
                    gracz.Strzaly[y - 1 + i, x - 1] = 5;
            }
        }
        public bool Wygrana(Uzytkownicy gracz)
        {
            if (gracz.StatkiTrafione[0] + gracz.StatkiTrafione[1] + gracz.StatkiTrafione[2] == 9)
                return true;
            else
                return false;
        }
    }
}
