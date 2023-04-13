using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Statki_projekt
{
    internal class Statki
    {
        public int[,] statekwsp = new int[3,6];
        int pionpoziom;
        public Statki()
        {
            bool prawidlowo = true;
            do
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("Podaj współrzędne statku o 1 polu: ");
                    statekwsp[0, 0] = int.Parse(Console.ReadLine());
                    statekwsp[0, 1] = int.Parse(Console.ReadLine());

                    for (int i = 0; i < 2; i++)
                    {
                        if (statekwsp[0, i] > 5 || statekwsp[0, i] < 1)
                        {
                            throw new Blad("Podałeś złe liczby! Twoje statki wychodzą poza planszę");
                        }
                    }

                    Console.WriteLine("Jak położony ma być statek o 2 polach? \n1. Pion; \n2. Poziom;");
                    pionpoziom = int.Parse(Console.ReadLine());
                    if (pionpoziom == 1 || pionpoziom == 2) { }
                    else
                        throw new Blad("Co mam zrobić?! Podałeś złą liczbę! Zdecyduj: Pion czy Poziom???");

                    Console.WriteLine("Podaj współrzędne tego statku: ");
                    statekwsp[1, 0] = int.Parse(Console.ReadLine());
                    statekwsp[1, 1] = int.Parse(Console.ReadLine());

                    if (pionpoziom == 1)
                    {
                        statekwsp[1, 2] = statekwsp[1, 0] + 1;
                        statekwsp[1, 3] = statekwsp[1, 1];
                    }
                    else
                    {
                        statekwsp[1, 2] = statekwsp[1, 0];
                        statekwsp[1, 3] = statekwsp[1, 1] + 1;
                    }
                    for (int i = 0; i < 4; i++)
                    {
                        if (statekwsp[1, i] > 5 || statekwsp[1, i] < 1)
                        {
                            throw new Blad("Podałeś złe liczby! Twoje statki wychodzą poza planszę");
                        }
                    }

                    Console.WriteLine("Jak położony ma być statek o 3 polach? \n1. Pion; \n2. Poziom;");
                    pionpoziom = int.Parse(Console.ReadLine());
                    if (pionpoziom == 1 || pionpoziom == 2) { }
                    else
                        throw new Blad("Co mam zrobić?! Podałeś złą liczbę! Zdecyduj: Pion czy Poziom???");

                    Console.WriteLine("Podaj współrzędne tego statku: ");
                    statekwsp[2, 0] = int.Parse(Console.ReadLine());
                    statekwsp[2, 1] = int.Parse(Console.ReadLine());

                    if (pionpoziom == 1)
                    {
                        statekwsp[2, 2] = statekwsp[2, 0] + 1;
                        statekwsp[2, 3] = statekwsp[2, 1];
                        statekwsp[2, 4] = statekwsp[2, 2] + 1;
                        statekwsp[2, 5] = statekwsp[2, 3];
                    }
                    else
                    {
                        statekwsp[2, 2] = statekwsp[2, 0];
                        statekwsp[2, 3] = statekwsp[2, 1];
                        statekwsp[2, 4] = statekwsp[2, 2];
                        statekwsp[2, 5] = statekwsp[2, 3];
                    }
                    for (int i = 0; i < 6; i++)
                    {
                        if (statekwsp[2, i] > 5 || statekwsp[2, i] < 1)
                        {
                            throw new Blad("Podałeś złe liczby! Twoje statki wychodzą poza planszę");
                        }
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    prawidlowo = false;
                    Console.ReadKey();
                }

            } while (!prawidlowo);
        }
    }
    class Blad : Exception 
    {
        public Blad(string msg) : base(msg) { }
    }
}
