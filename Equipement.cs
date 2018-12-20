using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
   abstract class Equipement
    {

        public string nom;
        public string Description;
        public map Plateau;
        public int indiceEqupement;
        public int x;
        public int y;
        public player Player;
        List<Equipement> List = new List<Equipement>();


        public Equipement(string nameEquip, string desciptEquip,int Indice,int X,int Y,player player)
        {
            Player = player;
            x = X;
            y = Y;
            indiceEqupement = Indice;
            nom = nameEquip;
            Description = desciptEquip;
           
            
            
        }
        public void Print(Equipement E)
        {
            Console.WriteLine("vous avez trouvé :" + nom+" voulez vous l'utiliser ? tapez 1 pour oui et tapez 2 pour mettre dans l'inventaire :");
            
            int choiceEquipement = menu.AskChoice(1, 1);
            switch (choiceEquipement)
            {
                case 1:
                    Use(E.Player);
                    break;
                case 2:
                   inventaire(E.Player,E);
                    break;
            }

        }
        public virtual void Pickup()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("vous avez trouvé l'objet :" + nom+" et vous le ramasser");
        }
        public virtual bool Use(player P)
        {
            Console.WriteLine("!!!!!! !! Vous avez utilisé : " + nom+"  !!!!!!!!");
            return true;
        }
        public void printEquip()
        {
            Console.WriteLine( " cet objet se nomme: "+nom + " ( " + Description+")");
        }
        public void inventaire(player Per, Equipement po)
        {
            List.Add(po);
            Console.WriteLine("l'objet :" + po.nom + " est dans votre inventaire");
            Console.WriteLine("================voici votre inventaire===========");
            for (int i = 0; i < List.Count; i++)
            {
                Console.WriteLine(po.nom);
            }


        }


    }
}
