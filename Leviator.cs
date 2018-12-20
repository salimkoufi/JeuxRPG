using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Leviator : Monstre
    {
        public int pvLeviator;
        public int tailleLeviator;
        public Leviator(string Nom, string Description, map M, int xx, int yy) : base(Nom, Description, M, xx, yy)
        {
            PVMonstre = 100;
            tailleLeviator = 3;

        }

        public override void attack(player P)
        {
            base.attack(P);
            ultralaser(P);
        }
       

        public override void trouve()
        {
            Console.Clear();
            Console.WriteLine("=============================================================================");
            Console.WriteLine("                           vous avez trouvé un monstre                       ");
            Console.WriteLine("=============================================================================");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine(@"                                                /===-_---~~~~~~~~~------____
                                                |===-~___                _,-'
                 -==\\                         `//~\\   ~~~~`---.___.-~~
             ______-==|                         | |  \\           _-~`
       __--~~~  ,-/-==\\                        | |   `\        ,'
    _-~       /'    |  \\                      / /      \      /
  .'        /       |   \\                   /' /        \   /'
 /  ____  /         |    \`\.__/-~~ ~ \ _ _/'  /          \/'
/-'~    ~~~~~---__  |     ~-/~         ( )   /'        _--~`
                  \_|      /        _)   ;  ),   __--~~
                    '~~--_/      _-~/-  / \   '-~ \
                   {\__--_/}    / \\_>- )<__\      \
                   /'   (_/  _-~  | |__>--<__|      |
                  |0  0 _/) )-~     | |__>--<__|     |
                  / /~ ,_/       / /__>---<__/      |
                 o o _//        /-~_>---<__-~      /
                 (^(~          /~_>---<__-      _-~
                ,/|           /__>--<__/     _-~
             ,//('(          |__>--<__|     /                  .----_
            ( ( '))          |__>--<__|    |                 /' _---_~\
         `-)) )) (           |__>--<__|    |               /'  /     ~\`\
        ,/,'//( (             \__>--<__\    \            /'  //        ||
      ,( ( ((, ))              ~-__>--<_~-_  ~--____---~' _/'/        /'
    `~/  )` ) ,/|                 ~-_~>--<_/-__       __-~ _/
  ._-~//( )/ )) `                    ~~-'_/_/ /~~~~~~~__--~
   ;'( ')/ ,)(                              ~~~~~~~~~~
  ' ') '( (/
    '   '  `");

            base.trouve();
            Console.WriteLine("                       je suis le gardien de ce trésor !!!!!!!!!!!!!!!!");
            Console.WriteLine("==================================================================");
            Console.WriteLine(" PV:" + PVMonstre);
            Console.WriteLine(" Taille :" + tailleLeviator);
            Console.WriteLine("==================================================================");


        }
        public void ultralaser(player P)
        {
           // int PVHero = P.Hero.Pv;

            Console.WriteLine(nom + " lance Ultra Laser et vous enleve 20 points de vie");
            P.Hero.Pv = P.Hero.Pv - 20;
            Console.WriteLine("  VOS POINTS DE VIE SONT A :" + P.Hero.Pv);
        }
        
    

   


    }
}
