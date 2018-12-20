using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{

    class PotionNRJ : Equipement
    {
        public enum potioNRJtype { Heal, NRJ };
        public potioNRJtype Type;
        private object heal;
        public map Plateau;
        public int x;
        public int y;
        player player;
        int Energiemax = 40;
        public PotionNRJ(string name, string descipt, map P,potioNRJtype t, int xx, int yy, player Play, int indicePV) : base(name, descipt, indicePV, xx, yy, Play)
        {
            //indicePV = 1;

            Plateau = P;
            x = xx;
            y = yy;
            Type = t;
        }
        public override void Pickup()
        {
            base.Pickup();

        }

        public override bool Use(player P)
        {

            UsePotionEnergie(Player);
            return base.Use(P);


        }
        public void UsePotionEnergie(player player)
        {

            if (player.Hero.Energie < Energiemax)
            {
                Console.WriteLine();
                player.Hero.Energie = player.Hero.Energie + 10;
                Console.WriteLine(" ahh !! je me sens mieux mon Energie est de   " + player.Hero.Energie);
            }
            else
            {
                Console.WriteLine("vous ne pouvez pas utiliser cette potion pour le moment car votre Energie est de " + player.Hero.Energie + "  vous la trouverai dans votre inventaire");
            }
        }
    }
}
