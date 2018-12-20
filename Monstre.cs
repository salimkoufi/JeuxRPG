using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    abstract class Monstre
    {
        public string nom;
        public string descriptionMonstre;
        public map PLateaumonstre;
        public player Pllayer;
        public int x;
        public int y;
        public int PVMonstre;
        public int TailleMonstre;
        

     public Monstre(string Nom,string Description,map M,int xx,int yy)
        {

            
            nom = Nom;
            descriptionMonstre = Description;
            PLateaumonstre = M;
            x = xx;
            y = yy;
        }
        public virtual void trouve()
        {
            Console.WriteLine("                       je suis " + nom + " et tu ne passeras pas !!!!!!!!!!!!");

            
        }
        public virtual void attack(player P)
        {
         
        }

    }
}
