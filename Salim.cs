using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Salim : Herorpg
    {
        //public Monstre monstre;
        

        public Salim(string n,int indicehero) : base(n,indicehero)
        {
            
            Energie = 60;
            Force = 50;
            Pv = 80;
            Endurance = 30;
            Taille = 2;
        }
        public void HurlementDuDragon(Monstre Monstre)
        {
            
            Energie= Energie-5;
        
        if (Energie <= 0)
            {
                Console.WriteLine(" vous n'avez pas assez d'énergie");
            }
            else
            {
                Monstre.PVMonstre = Monstre.PVMonstre - 20;
                Console.WriteLine("vous avez lancer Hurlement du dragon et vous avez inflligé 20 point de dégats");
                Console.WriteLine("maintenant ses point de vie sont à :" + Monstre.PVMonstre);
            }
         }

        public void AvadaCadavra(Monstre Mon)
        {
            Energie = Energie - 10; 
            if (Energie <= 0)
            {
                Console.WriteLine("vous ne pouvez lancer ce sort votre énergie est insufisante");
            }
            else
            {
                Mon.PVMonstre = Mon.PVMonstre - 40;
                Console.WriteLine("vous avez lancer le sort Avada Cadavra comme dans harry potter contre Vol De mort et vous infligez 40 points de dégats");
                Console.WriteLine(" niveau de vie " + Mon.nom + " est de " + Mon.PVMonstre);
            }
        }

        public override void attackhero(Monstre M)
        {
            Console.WriteLine("Tapez le numéro de votre sort");
            Console.WriteLine(" 1- Avada Cadavra (retire 10 points d'énergie)");
            Console.WriteLine(" 2- Hurlement du dragon (retire 5 points d'energie");
            int choicesort = menu.AskChoice(1, 2);
            switch (choicesort)
            {
                case 1:
                    AvadaCadavra(M);
                    break;
                case 2:
                    HurlementDuDragon(M);
                    break;
            }
            base.attackhero(M);

        }
    }

    
}
