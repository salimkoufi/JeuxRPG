using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Case
    {
        public enum CaseType { Desert, Ocean, Foret };
        public int x;
        public int y;
        public CaseType Type;
        public string Description;
        //public Mosnter m;
        //public Equipement Item;
        //public Herorpg Hero;

        public Case(int X, int Y, CaseType t, string D)
        {
            x = X;
            y = Y;
            Type = t;
            Description = D;
           // Hero = null;
            Random r = new Random(DateTime.Now.Millisecond);
            //if (r.Next() % 100 > 50)
           // {
              //  Item = new potion("Soin", "Potion de soin", 1, 2, potion.potiontype.Heal);
            //}
            //else
                //Item = null;
        }
    }
}
