using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class menu
    {
        public menu()
        {
            PrintMenu();
            int choix = AskChoice(1, 4);
            switch (choix)
            {
                case 1:
                    Load();
                    break;
                case 2:
                    Apropos();
                    break;
                case 3:
                    Quit();
                    break;
                case 4:
                    startgame();
                    break;


            }
        }
        public void PrintMenu()
        {
            Console.WriteLine(" Tapez  1: Load  " +
                "2: Apropos  " +
                "3: Quit  " +
                "4: Start game  ");
            int choix = AskChoice(1, 4);
            switch (choix)
            {
                case 1:
                    Load();
                    break;
                case 2:
                    Apropos();
                    break;
                case 3:
                    Quit();
                    break;
                case 4:
                    startgame();
                    
                   /* Console.WriteLine("trés bien trés bien ! je me présente je suis ta voix c'est moi qui me chargerai de te guider au fur et  a mesur de ton avancement dans le jeu");
                    Console.WriteLine("il est temp de sélectionner votre classe maintenant sachant que si tu prend salim tu vas etre moin embéter par les monstres que tu vas rencontrés tellement il est puissant, Tapez:   1 : Eskanort (Guérrier)     2  : Shanks (Guérrier)   3 : salim (Mage le plus puissant)  4 : malphite (Tank)");
                    int choiceHero = AskChoice(1, 3);
                    switch (choiceHero)
                    {
                        case 1:
                            //TODO création eskanort
                            break;
                        case 2:
                            //TODO shanks
                            break;
                        case 3:
                            Console.WriteLine("Hé Hé Héééé ... Vous avez fait le meilleure choix je vous félicite,à présant je vous invite à donner un nom a votre personnage :");
                            string NomPersonnageMage = Console.ReadLine();

                            Salim personnage = new Salim(NomPersonnageMage);
                            player playerone = new player(NomPersonnageMage, personnage, 0, 0);
                            map ynovia = new map(7, 10);
                            Game game = new Game(ynovia, playerone);
                            game.startgame();
                            break;
                            //TODO fAIRE L'affichage du menu

                           }*/
                    break;
            }
        }
        public static int AskChoice(int min, int max)
        {
            
            int result = int.Parse(Console.ReadLine());
            
            
                while (result > max && result < min)
                {
                    result = int.Parse(Console.ReadLine());

                }
            
            return result;
        }
        public void startgame()
        {

             Console.WriteLine("trés bien trés bien ! je me présente je suis ta voix c'est moi qui me chargerai de te guider au fur et  a mesur de ton avancement dans le jeu");
            Console.WriteLine("avant de commencer je te le laisse entré le nom que tu veux avoir pendant ton aventure");
            string NomPersonnage = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("super "+NomPersonnage+" allons y");
            Console.WriteLine("il est temp de sélectionner votre classe maintenant sachant que si tu prend salim tu vas etre moin embéter par les monstres que tu vas rencontrés tellement il est puissant, Tapez:   1 : Eskanort (Guérrier)     2  : Shanks (Guérrier)   3 : salim (Mage le plus puissant)  4 : malphite (Tank)");
             int choiceHero = AskChoice(1,4);
            switch (choiceHero)
            {
                case 1:
                    //TODO création eskanort
                    break;
                case 2:
                    //TODO shanks
                    break;
                case 3:
                    startgameSalim(NomPersonnage);
                   /* Console.WriteLine("Hé Hé Héééé ... Vous avez fait le meilleure choix je vous félicite,à présant je vous invite à donner un nom a votre personnage :");
                    string NomPersonnageMage = Console.ReadLine();

                    Salim personnage = new Salim(NomPersonnageMage);
                    player playerone = new player(NomPersonnageMage, personnage, 0, 0);


                    Console.WriteLine(" Trés bien " + NomPersonnageMage + " j'ai hate qu'on commence l'aventure ensemble afin de trouver le trésors que nombreux héros n'ont pu s'en emparrer ... voici donc ta premiere arme,c'est une épée qu'on a trouvé par terre! voici tiens prend la surtout ne nous la rend jamais ! ");
                    EpeeDebut EpéeD = new EpeeDebut("couteau suisse", "on a trouvé cette épée par terre");
                    Console.ReadLine();
                    EpéeD.printEquip();
                    Console.WriteLine("Maintenant que tu l'as bien vu equipe toi avec et allonsy découvrir d'autre chose");

                    EpéeD.Use();
                    Console.ReadLine();
                    Console.WriteLine(" à présent il est temp que je te montre un peu la carte d'ynovia histoire que tu te répére un peu");
                    Console.ReadLine();
                    map ynovia = new map(7, 10);
                    ynovia.print();*/
                    //TODO salim
                    break;
                case 4:
                    StartGameMalphite(NomPersonnage);
                    break;
            }


        }


        public void Load()
        {

        }
        public void Apropos()
        {
            Console.WriteLine("bienvenue dans le monde d'Ynovia! dans ce jeux le but et d'essayer de vous emparer du légendaire trésor caché au fin fond d'ynovia mais pour cela vous devez prendre votre courage a deux mains et aller relever tout les défits que propose le jeu et montrer a tout le monde qui vous etes");
            Console.WriteLine("etes vous pret a commencer le jeu ? :" +
                " 1 :  oui" +
                " 2  :  non");
            int choiceapropo = AskChoice(1, 2);
            while (choiceapropo == 1)
            {
                startgame();
            }





        }
        public void Quit()
        {
            Console.WriteLine(" à bientot");



        }
        public void startgameSalim(string Nom)
        {
            Console.Clear();
            Console.WriteLine("Hé Hé Héééé ... Vous avez fait le meilleure choix je vous félicite");
           // string NomPersonnageMage = Console.ReadLine();

            Salim personnage = new Salim(Nom,3);
            player playerone = new player(Nom, personnage, 0,0);
            startgamesuite(personnage, playerone);
            


           /* Console.WriteLine(" Trés bien " + Nom + " j'ai hate qu'on commence l'aventure ensemble afin de trouver le trésors que nombreux héros n'ont pu s'en emparrer ... voici donc ta premiere arme,c'est une épée qu'on a trouvé par terre! voici tiens prend la surtout ne nous la rend jamais ! ");
            EpeeDebut EpéeD = new EpeeDebut("couteau suisse", "on a trouvé cette épée par terre");
            Console.ReadLine();
            EpéeD.printEquip();
            Console.WriteLine("Maintenant que tu l'as bien vu equipe toi avec et allonsy découvrir d'autre chose");

            EpéeD.Use();
            Console.ReadLine();
            Console.WriteLine(" à présent il est temp que je te montre un peu la carte d'ynovia histoire que tu te répére un peu");
            Console.ReadLine();
            map ynovia = new map(7, 10);
            Game gameon = new Game(ynovia, playerone);
            ynovia.print(playerone);
            Console.ReadLine();

            Console.WriteLine("Tu vois bien ton nom en rouge ... il indique éffectivement ta position dans la map et comme tu peux le voir en ce moment nous sommes dans la foret d'ynovia");
            Console.WriteLine("Maintenant il faut que je t'éxplique la maniée d'avancer dans les cases pour qu'enfin tu puisse commencer ta prémiére quete");
            gameon.Deplacement(playerone,ynovia);*/
        }
        public void StartGameMalphite( String Nom)
        {
            Console.Clear();
            Console.WriteLine("  je comprend pas pourquoi t'as pas choisi Salim ... mais bon  malphite est un Top Héro (super le jeu de mots) héhéyy");
            Malphite personnageMalphite = new Malphite(Nom,4);
            player playerone = new player(Nom, personnageMalphite, 0, 0);
            startgamesuite(personnageMalphite, playerone);
        }

        public void startgamesuite(Herorpg H,player P)
        {
            Console.WriteLine("  Trés bien " +P.nom  + " j'ai hate qu'on commence l'aventure ensemble afin de trouver le trésors que nombreux héros n'ont pu s'en emparrer ... voici donc ta premiere arme,c'est une épée qu'on a trouvé par terre! voici tiens prend la surtout ne nous la rend jamais ! ");
            EpeeDebut EpéeD = new EpeeDebut("couteau suisse", "on a trouvé cette épée par terre",0,0,0,P);
            Console.ReadLine();
            Console.Clear();
            EpéeD.printEquip();
            Console.WriteLine("  Maintenant que tu l'as bien vu equipe toi avec et allonsy découvrir d'autre chose");

            EpéeD.Use(P);
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("  à présent il est temp que je te montre un peu la carte d'ynovia histoire que tu te répére un peu");
            Console.ReadLine();
            map ynovia = new map(7, 10);
            Game gameon = new Game(ynovia, P);
            ynovia.print(P);
            Console.ReadLine();
            
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("  Tu vois bien ton nom en rouge ... il indique éffectivement ta position dans la map et comme tu peux le voir en ce moment nous sommes dans la foret d'ynovia");
            Console.WriteLine("  Maintenant je crois que c'est le moment d'aller a la recherche du one piéce le trésor caché par un ancien grand Mage nomé Giroud , avant sa disparition il laissé un méssage disant <<Le ONE piéce ??!!! je vous le laisses trouvez le !!!>> ");
            Console.WriteLine("  cependant pour qu'on ait une idée d'ou il peut se caché on doit aller a la recherche du premier indice   ! et ce sera ta premiére quete ");
            Console.WriteLine("  ahh oui j'avais oublié de te dire ou tu dois aller chercher l'indice ... il se trouve au finfond des déserts d'ynovia la légende dit qu'il se trouve à l'extreme nord-est comme à l'extreme sud_ouest ");

            gameon.Deplacement(P, ynovia);
        }

    } 
}
