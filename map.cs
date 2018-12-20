using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class map
    {
        public Case[,] plateau;
        public int NBCases;
        public string Nom;
        public int Largeur;
        public int Longeur;
        public map(int largeur, int longeur)
        {
            Largeur = largeur;
            Longeur = longeur;
            plateau = new Case[largeur, longeur];

            for (int i = 0; i <= 3; i++)
            {
                for (int j = 4; j <= 9; j++)
                {
                    plateau[i, j] = new Case(i, j, Case.CaseType.Desert, "Desert");
                    //plateau[i, j] = new Case (i, j);
                }
            }
            for (int i = 0; i <= 2; i++)
            {
                for (int j = 0; j <= 3; j++)
                {
                    plateau[i, j] = new Case(i, j, Case.CaseType.Foret, "Foret");
                    //plateau[i, j] = new Case ();
                }
            }
            for (int i = 3; i <=6 ; i++)
            {
                for (int j = 0; j <= 3; j++)
                {
                    plateau[i, j] = new Case(i, j, Case.CaseType.Desert, "Desert");
                    //plateau[i, j] = new Case (i, j);
                }
            }
            for (int i = 3; i <= 6; i++)
            {
                for (int j = 4; j <= 9; j++)
                {
                    plateau[i, j] = new Case(i, j, Case.CaseType.Ocean, "Ocean");
                    //plateau[i, j] = new Case (i, j);
                }
            }

        }

        public void print(player P)
        {
            
            for (int i = 0; i < Largeur; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < Longeur; j++)
                {
                    /*if (P.x == i && P.x == j)
                    {
                        Console.Write(P.nom);

                    }*/
                    if ((plateau[i, j].Type == Case.CaseType.Desert && (P.y == i && P.x == j)) ||(plateau[i, j].Type == Case.CaseType.Foret && (P.y == i && P.x == j))||(plateau[i, j].Type == Case.CaseType.Ocean && (P.y == i && P.x == j)))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(P.nom);
                    }
                    else if (plateau[i, j].Type == Case.CaseType.Desert)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(" [D] ");

                    }
                   
                    else if(plateau[i, j].Type == Case.CaseType.Foret)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(" [F] ");
                    }
                    
                    else if (plateau[i, j].Type == Case.CaseType.Ocean)
                    {
                       Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(" [O] ");
                    }

                    
                }
            }

        }


        public string GetDescription(int x, int y)
        {
            string s = plateau[x, y].Description;
            return s;
        }
    }
}
