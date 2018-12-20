using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Anubis : Monstre
    {
        public int tailleanubis;
        public Anubis(string Nom, string Description, map M, int xx, int yy) : base(Nom, Description, M, xx, yy)
        {
            PVMonstre = 60;
            tailleanubis = 3;
        }
        public override void attack(player P)
        {
            base.attack(P);
            coup(P);
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
            Console.WriteLine(@"
             /\ /l
            ((.Y(!
             \ |/
             /  6~6,
             \ _    +-.
              \`-=--^-'
               \ \
              _/  \
             (  .  Y
            /'\ `--^ --v--.
           / _ `--'T~\/~\/
          / ' ~\.  !
    _    Y      Y./ '
   Y ^|   |      | ~~7
   | l |     / ./ '
   | `L | Y.^/ ~T
   | l  ! | |/| | -Row
   | .`\/ ' | Y | !
   l  '~   j l j_L______
    \, ____{ __'~ __ ,\_,\_
 ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            base.trouve();
            Console.WriteLine("               spider cochon c'est Le plus foooort !! woow viens te battre !!!!!!!!!!!!!!!!");
            Console.WriteLine("==================================================================");
            Console.WriteLine(" PV:" + PVMonstre);
            Console.WriteLine(" Taille :" + tailleanubis);
            Console.WriteLine("==================================================================");


        }
        public void coup(player P)
        {
            // int PVHero = P.Hero.Pv;

            Console.WriteLine(nom + " lance coud de poing ardant et vous enleve 20 points de vie");
            P.Hero.Pv = P.Hero.Pv - 10;
            Console.WriteLine("  VOS POINTS DE VIE SONT A :" + P.Hero.Pv);
        }
    }
}
