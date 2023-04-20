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
        public List<Statki> Statki;
        public int[,] Strzaly;
        public int[] StatkiTrafione;
        public int ID;
       

        public Uzytkownicy(int id, int[,] plansza, int[,] strzaly, List<Statki> statki, int[] statkitrafiione) {
            try
            {
                ID = id;
                Plansza = plansza;
                Strzaly = strzaly;
                Statki = statki;
                StatkiTrafione = statkitrafiione;
            }
            catch (Exception e) 
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
