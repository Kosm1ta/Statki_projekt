using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statki_projekt
{
    internal class Statki
    {
        int[] statek1wsp = new int[2];
        int[] statek2wsp = new int[4];
        int[] statek3wsp = new int[6];

        public Statki() { }
        public Statki(int[] statek1wsp, int[] statek2wsp, int[] statek3wsp)
        { 
            this.statek1wsp = statek1wsp;
            this.statek2wsp = statek2wsp;
            this.statek3wsp = statek3wsp;
        }
    }
}
