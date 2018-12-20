using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class EpeeDebut : Equipement
    {
        public EpeeDebut(string nameEquip, string desciptEquip,int indiceEpeeDebut,int xx,int yy,player P) : base(nameEquip, desciptEquip,indiceEpeeDebut,xx,yy,P)
        {
        }
        public override void Pickup()
        {
            base.Pickup();
            Console.WriteLine("vous avez une nouvelle potion");
        }

        public override bool Use(player P)
        {
           Console.WriteLine(" !!!!!!!!!!!!   tu as une nouvelle épée   !!!!!!!!!!!!");
           return base.Use(P);
            
        }
        

    }
}
