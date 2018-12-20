using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class IndiceTresor : Equipement
    {
        public IndiceTresor(string nameEquip, string desciptEquip, int Indice, int X, int Y, player player) : base(nameEquip, desciptEquip, Indice, X, Y, player)
        {
        }
        public void Afficherindice(player P)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Je vois un objet bizarre par la-bas je me rapproche pour aller le chercher");
            Console.Read();
            
            Console.WriteLine("Vous avez trouvé une enveloppe pour l'ouvrir tapez sur entré");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("========================================================================================================================");
            Console.WriteLine("si tu lis cette lettre cela veut dire que tu seras le premier à vraiment savoir ou est situé le one piéce, sache maintenant que le one piéce se trouve au fin-fond de l'océan d'ynovia protégé par deux dragons ,il se situe dans la seule position de l'océan ou sauf deux route sont possibles mais faudrait que tu batte le dragon qui protége la route");
            Console.WriteLine("=====================================================signé grand mage GIROUD============================================");
            Console.ReadLine();
            Console.WriteLine("Bravo " + P.nom + " tu a réussi t'as premiere quette !! et maintenant il est temp d'aller trouver ce trésor");

        }
    }

    
    
}
