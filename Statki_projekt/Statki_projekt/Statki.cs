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
        public int[,] statekwsp = new int[3,2];
        
        public Statki(int x, int y, int statek)
        {
            statekwsp[statek,0] = x;
            statekwsp[statek,1] = y;
        }
    }
    
}
