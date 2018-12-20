using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class potion : Equipement
    {
       /* public enum potiontype { Heal, NRJ }
        public potiontype Type;
        private object heal;
        public map Plateau;
        public int x;
        public int y;
        //public player player;*/
        int pvmax = 100;
        int Energiemax = 30;

        //public enum potiontype { Heal, NRJ};
       // public potiontype Type;
        private object heal;
        public map Plateau;
        public int x;
        public int y;
        player player;

        public potion(string name, string descipt,map P,/*potiontype t*/int xx,int yy,player Play,int indicePV) : base(name, descipt,indicePV,xx,yy,Play)
        {
            //indicePV = 1;
           
            Plateau = P;
            x = xx;
            y = yy;
            //Type = t;
        }

        

        public override void Pickup()
        {

        base.Pickup();
            
         
        
        }

        public override bool Use(player P)
        {
            if (P.Hero.Pv < pvmax)
            {

                P.Hero.Pv = P.Hero.Pv + 10;
                Console.WriteLine(" ahh !! je me sens mieux mon niveau de vie est de  " + P.Hero.Pv);
                return base.Use(P);
            }
            else
            {
                Console.WriteLine("vous ne pouvez pas utiliser cette potion pour le moment car votre niveau de vie est de" + player.Hero.Pv + "  vous la trouverai dans votre inventaire");
                return false;
            }

            //UsePotionVie(Player);
           
            
            
        }
        public void UsePotionVie(player player)
        {
            
            if (player.Hero.Pv < pvmax)
            {

                player.Hero.Pv = player.Hero.Pv + 10;
                Console.WriteLine(" ahh !! je me sens mieux mon niveau de vie est de  " + player.Hero.Pv);
            }
            else
            {
                Console.WriteLine("vous ne pouvez pas utiliser cette potion pour le moment car votre niveau de vie est de" + player.Hero.Pv + "  vous la trouverai dans votre inventaire");
            }
        }

        /*public void UsePotionEnergie(player player)
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
        }*/



    }
}
