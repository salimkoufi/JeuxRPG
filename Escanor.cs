using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Escanor : Herorpg
    {
        public Escanor(string n,int ind) : base(n,ind)
        {
            Energie = 20;
            Force = 50;
            Pv = 40;
            Endurance = 30;
            Taille = 2;
        }
    }

}
