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

        public int X;
        public int Y;
        public int Kierunek;
        public Statki(int x, int y, int kierunek) {
            try
            {
                X = x;
                Y = y;
                Kierunek = kierunek;
            }catch (Exception e) 
            {
                Console.WriteLine(e.Message);
            }
        }       
    }
}
