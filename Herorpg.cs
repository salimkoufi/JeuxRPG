using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    abstract class Herorpg
    {
       
        public string Nom;
        public int Pv;
        protected int Force;
        protected int Endurance;
        protected int Taille;
        public int Energie;
        public int indiceH;
        public Monstre monstre;

        public Herorpg(string n, int indice)
        {
            indiceH = indice;
            Nom = n;
        }

        public virtual void attackhero(Monstre m)
        {
            

        }
    }
}
