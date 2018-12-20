using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class player
    {
        public string nom;
        public Herorpg Hero;
        public int x;
        public int y;

    public player(string n, Herorpg H,int X,int Y)
        {
            nom = n;
            Hero = H;
            x = X;
            y = Y;
        }

        
    }
}
