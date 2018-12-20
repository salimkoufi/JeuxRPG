using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Malphite : Herorpg
    {
        public Malphite(string n,int ind) : base(n,ind)
        {
            Energie = 20;
            Force = 20;
            Pv = 80;
            Endurance = 30;
            Taille = 3;
        }

        public int EclatSismique()
        {
            Energie = Energie - 4;
            if(Energie <= 0)
            {
                return 0;
            }
            else
            {
                return 15;
            }
            

        }

        public int Forceindomptable()
        {
            Energie = Energie -10;
            if(Energie <= 0)
            {
                return 0;
            }
            else
            {
                return 30;
            }
        }
    }
}
