using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statki_projekt
{
    internal class Statki
    {
        public int[] statek1wsp = new int[2];
        public int[] statek2wsp = new int[4];
        public int[] statek3wsp = new int[6];
        int pionpoziom = 0;

        
        public Statki()
        {
            Console.Write("Podaj współrzędne 1 statku o 1 polu: ");
            statek1wsp[0] = int.Parse(Console.ReadLine());
            statek1wsp[1] = int.Parse(Console.ReadLine());

            Console.WriteLine("Czy statek 2 o 2 polach ma być w pionie czy w poziomie? \n1. Pion; \n2.Poziom;");
            pionpoziom = int.Parse(Console.ReadLine());

            Console.Write("Podaj współrzędne statku 2: ");
            statek2wsp[0] = int.Parse(Console.ReadLine());
            statek2wsp[1] = int.Parse(Console.ReadLine());
            
            if(pionpoziom == 1)
            {
                statek2wsp[2] = statek2wsp[0] + 1;
                statek2wsp[3] = statek2wsp[1];
            }
            else
            {
                statek2wsp[2] = statek2wsp[0];
                statek2wsp[3] = statek2wsp[1] + 1;
            }
            Console.WriteLine("Czy statek 3 o 3 polach ma być w pionie czy w poziomie? \n1. Pion; \n2.Poziom;");
            pionpoziom = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj współrzędne 3 statku o 3 polach: ");
            statek3wsp[0] = int.Parse(Console.ReadLine());
            statek3wsp[1] = int.Parse(Console.ReadLine());

            if (pionpoziom == 1)
            {
                statek3wsp[2] = statek3wsp[0] + 1;
                statek3wsp[3] = statek3wsp[1];
                statek3wsp[4] = statek3wsp[2] + 1;
                statek3wsp[5] = statek3wsp[3];
            }
            else
            {
                statek3wsp[2] = statek3wsp[0];
                statek3wsp[3] = statek3wsp[1] + 1;
                statek3wsp[4] = statek3wsp[2];
                statek3wsp[5] = statek3wsp[3] + 1;
            }
        }
    }
}
