using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Game
    {
        public player player;
        public map plateau;

      //  List<Equipement> List = new List<Equipement>();

        public Game(map P, player Pl)
        {
            player = Pl;
            plateau = P;


        }
        public void startgame()
        {
            /*Console.WriteLine(" Trés bien " + player.nom + " j'ai hate qu'on commence l'aventure ensemble afin de trouver le trésors que nombreux héros n'ont pu s'en emparrer ... voici donc ta premiere arme,c'est une épée qu'on a trouvé par terre! voici tiens prend la surtout ne nous la rend jamais ! ");
            EpeeDebut EpéeD = new EpeeDebut("couteau suisse", "on a trouvé cette épée par terre");
            Console.ReadLine();
            EpéeD.printEquip();
            Console.WriteLine("Maintenant que tu l'as bien vu equipe toi avec et allonsy découvrir d'autre chose");

            EpéeD.Use();
            Console.ReadLine();
            Console.WriteLine(" à présent il est temp que je te montre un peu la carte d'ynovia histoire que tu te répére un peu");
            Console.ReadLine();*/


        }

        public void Deplacement(player player,map plateau)
        {

            
            printchoixdirrection();
            int choisedirrection = menu.AskChoice(1,4);
            switch (choisedirrection)
            {
                case 1:
                    gonorth(player, plateau);
                    testcase();
                    break;
                case 2:
                    gosouth(player, plateau);
                    testcase();
                    break;
                case 3:
                    adroite(player, plateau);
                    testcase();
                    break;
                case 4:
                    agauche(player,plateau);
                    testcase();
                    break;

            }
            
            // Printchoix();
            //int choix = menu.AskChoice(0, 4);
            //TODO Récupérer la case
            //TODO Téster le contenu de la case
            //TODO peut etre lancer un combat
        }


       
        public void  printchoixdirrection()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Pour monter vers le nord Tapez 1 ,pour déscendre tapez 2 ,pour aller a droite tapez 3 ,pour aller à gauche tapez 4");
           
            
        }
        public void gonorth(player player , map plateau)
        {
            if (player.y > 0)
            {
            
                player.y--;
                
                plateau.print(player);
                testcase();

            }
            else
            {
               
                Console.WriteLine("vous ne pouvez pas encore sortir d'ynovia dans cette version du jeu");
                Deplacement(player,plateau);
            }
        }
        public void gosouth(player player, map plateau)
        {
            if (player.y < plateau.Largeur-1)
            {
                player.y++;
                plateau.print(player);
                testcase();
            }
            else
            {
                Console.WriteLine("vous ne pouvez pas encore sortir d'ynovia dans cette version du jeu");
                Deplacement(player, plateau);

            }

        }

        public void adroite(player player, map plateau)
        {
            if (player.x < plateau.Longeur-1)
            {
                player.x++;
                plateau.print(player);
                testcase();
            }
            else
            {
                Console.WriteLine("vous ne pouvez pas encore sortir d'ynovia dans cette version du jeu");
                Deplacement(player, plateau);
            }
        }
        
        public void agauche(player player ,map plateau)
        {
            if (player.x > 0)
            {
                player.x--;
                plateau.print(player);
                testcase();
            }
            else
            {
                Console.WriteLine("vous ne pouvez pas encore sortir d'ynovia dans cette version du jeu");
                Deplacement(player, plateau);
            }
        }
        public void testcase()
        {
            potion potion1 = new potion("Potion de vie 1", "l'utiliser te rajoute 20 PV",plateau ,/*potion.potiontype.Heal,*/0,1,player,1);
            potion potion2 = new potion("Potion de vie 2", "l'utiliser te rajoute 20 PV", plateau,/* potion.potiontype.Heal, */1, 0, player,1);
            potion potion3 = new potion("Potion de vie", "l'utiliser te rajoute 20 PV", plateau,/* potion.potiontype.Heal,*/ 9, 3, player, 1);
            potion potion4 = new potion("Potion de vie", "l'utiliser te rajoute 20 PV", plateau, /*potion.potiontype.Heal*/ 6, 6, player, 1);
            PotionNRJ potion5 = new PotionNRJ("Potion d'énérgie", "l'utiliser te rajoute 10 en énérgie", plateau, PotionNRJ.potioNRJtype.NRJ, 5, 0, player, 2);
            PotionNRJ potion6 = new PotionNRJ("Potion d'énérgie", "l'utiliser te rajoute 10 en énérgie", plateau, PotionNRJ.potioNRJtype.NRJ, 5, 6, player, 2);
            Leviator Leviator1 = new Leviator("Leviator", "un montre venu tout droit de pokémon", plateau,9,4);
            Leviator Leviator2= new Leviator("Leviator", "un montre venu tout droit de pokémon", plateau, 8, 6);
            Onepiece onepiece = new Onepiece("one piece", "trésor",3,9, 6, player);
            Anubis anubis1 = new Anubis("Anubis", "je suis fou", plateau, 0, 5);
            Anubis anubis2 = new Anubis("Anubis", "je suis fou", plateau, 8, 0);
            
            IndiceTresor Indice1 = new IndiceTresor("indice", "cela te permetteras de trouver le trésors", 4, 9, 0, player);
            IndiceTresor Indice2 = new IndiceTresor("indice", "cela te permetteras de trouver le trésors", 4, 0, 6, player);
            if (player.x == potion1.x && player.y == potion1.y)
            {
               
                potion1.Pickup();
                potion1.Print(potion1);
                Deplacement(player, plateau);
                
            }
            else if (player.x == potion2.x && player.y == potion2.y)
            {
                potion2.Pickup();
                potion2.Print(potion2);
                Deplacement(player, plateau);
            }
            else if (player.x == potion3.x && player.y == potion3.y)
            {
                potion3.Pickup();
                potion3.Print(potion3);
                Deplacement(player, plateau);

            }
            else if(player.x == potion4.x && player.y == potion4.y)
            {
                potion4.Pickup();
                potion4.Print(potion4);
                Deplacement(player, plateau);

            }
            else if(player.x == potion5.x && player.y == potion5.y)
            {
                potion5.Pickup();
                potion5.Print(potion5);
                Deplacement(player, plateau);
            }
            else if(player.x == potion6.x && player.y == potion6.y)
            {
                potion6.Pickup();
                potion6.Print(potion6);
                Deplacement(player, plateau);

            }
            else if (player.x == Leviator1.x && player.y == Leviator1.y)
            {
                
                combat(player,Leviator1);
                Deplacement(player, plateau);

            }
            else if (player.x == Leviator2.x && player.y == Leviator2.y)
            {
                
                combat(player, Leviator2);
                Deplacement(player, plateau);

            }
            else if(player.x == onepiece.x && player.y == onepiece.y)
                {
                onepiece.affichertresor();

            }
            else if(player.x == Indice1.x && player.y == Indice1.y)
            {
                Indice1.Afficherindice(player);
                Deplacement(player, plateau);
            }
            else if (player.x == Indice2.x && player.y == Indice2.y)
            {
                Indice2.Afficherindice(player);
                Deplacement(player, plateau);

            }
            else if (player.x == anubis1.x && player.y == anubis1.y)
            {
                combat(player, anubis1);
                Deplacement(player, plateau);
            }
            else if (player.x == anubis2.x && player.y == anubis2.y)
            {
                combat(player, anubis2);
                Deplacement(player, plateau);
            }
            else
            {
                
                Deplacement(player, plateau);
            }

        }

        /* public void inventaire(player Per,Equipement po)
         {
             List.Add(po);
             Console.WriteLine("l'objet :"+po.nom+ " est dans votre inventaire");
             Console.WriteLine("================voici votre inventaire===========");
             for (int i = 0; i < List.Count; i++)
             {
                 Console.WriteLine(po.nom);
             }


         }*/

        public void combat(player p, Monstre M)

        {
            M.trouve();
            Console.WriteLine("voulez vous :");
            Console.WriteLine("1- lancer le combat ");
            Console.WriteLine("2- fuir");
            int choicefuir = menu.AskChoice(1, 2);
            if (choicefuir == 1)
            {
                while (p.Hero.Pv > 0 && M.PVMonstre > 0)
                {

                    
                    if ((M.nom == "Leviator")|| (M.nom == "Anubis"))
                    {
                        M.attack(p);
                        Console.WriteLine();
                        Console.WriteLine("c'est a votre tour d'attaquer");
                        if (p.Hero.indiceH == 3)
                        {
                            p.Hero.attackhero(M);

                        }
                        Console.WriteLine("==========================");
                        Console.WriteLine("    "+p.nom + "   " + M.nom);
                        Console.WriteLine("   --------      --------");
                        Console.WriteLine("PV:  " + p.Hero.Pv + "        " + M.PVMonstre);
                        Console.WriteLine("==========================");
                        Console.ReadLine();
                        

                    }
                   

                }

                if (p.Hero.Pv <= 0)
                {
                    Console.WriteLine("GAME OVER !! vous etes mort");
                    Console.ReadLine();
                }
                else if (M.PVMonstre <= 0)
                {
                    Console.WriteLine("vous avez tué :" + M.nom);
                    Console.WriteLine();
                    

                }
            }
            else 
            {
                Deplacement(p, plateau);
            }
            
            
        

        }
            

        


    }



    }
    
