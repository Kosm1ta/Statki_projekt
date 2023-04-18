using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statki_projekt
{
    internal class Uzytkownicy
    {
        public int[,] Plansza;
        

        public int[,] Strzaly;
        
       
        public Uzytkownicy(int[,] plansza, int[,] strzaly) {
            Plansza = plansza;
            Strzaly = strzaly;

        }
        
    }
}
