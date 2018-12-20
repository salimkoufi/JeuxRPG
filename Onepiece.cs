using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Onepiece : Equipement
    {
        public Onepiece(string nameEquip, string desciptEquip, int Indice, int X, int Y, player player) : base(nameEquip, desciptEquip, Indice, X, Y, player)
        {
        }

        public void affichertresor()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            
            
            Console.WriteLine("====================================================================================");
            Console.WriteLine("félicitation t'as réussi a relevé tout les défis et t'as trouvé le one piece tapez :");
            Console.WriteLine("1- pour l'ouvrir");
            int choiceouvrir = menu.AskChoice(1,1);
            switch (choiceouvrir)
            {
                case 1:
                    Console.WriteLine(@"
     ___        _____   _   _   _   _     _   _____    _____  
    /   |      /  ___/ | | | | | | | |   / / |  _  \  | ____| 
   / /| |      | |___  | | | | | | | |  / /  | |_| |  | |__   
  / / | |      \___  \ | | | | | | | | / /   |  _  /  |  __|  
 / /  | |       ___| | | |_| | | | | |/ /    | | \ \  | |___  
/_/   |_|      /_____/ \_____/ |_| |___/     |_|  \_\ |_____| ");
   
                    break;

            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("désolé mais faudra attendre la suite du jeu pour connaitre ce qu'est le one piece, sache que t'as été un grand champion et à trés bien tot pour de nouvelle aventure");
            Console.WriteLine("nous remercions toutes l'équipe technique ");
            Console.WriteLine("========================================================================================");
            Console.ReadLine();
            Environment.Exit(0);
            

        }
    }
}
