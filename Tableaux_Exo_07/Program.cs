using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tableaux_Exo_07
{
    class Program
    {
        static void Main(string[] args)
        {

            string prenom;
            int borneSup = 6;
            int borneInf = 0;
            int milieuDuTableau;
            int compare;
            bool test = true;


            string[] tableau = new string[7] { "agathe", "berthe", "chloé", "cunégonde", "olga", "raymonde", "sidonie" };

            Console.WriteLine("Veuillez choisir un prenom dans la liste.");
            prenom = Console.ReadLine();

            milieuDuTableau = (borneInf + tableau.Length - 1) / 2;                  // on cherche le milieu du tableau

            Console.WriteLine("(Le milieu du tableau est au numéro : " + milieuDuTableau + ")");          //verif
            Console.ReadKey();
            do
            {
                compare = prenom.CompareTo(tableau[milieuDuTableau]);

                if (compare == -1)             /* nombre à gauche */
                {
                    borneSup = milieuDuTableau;
                    Console.WriteLine("le nombre est entre " + borneInf + " et " + borneSup);

                    milieuDuTableau = (borneInf + borneSup) / 2;

                    Console.WriteLine("(le milieu du tableau est au numero : " + milieuDuTableau + ") ");
                    Console.ReadKey();
                }
                if (compare == 1)             // nombre à droite
                {
                    borneInf = milieuDuTableau;
                    Console.WriteLine("le nombre est entre " + borneInf + " et " + borneSup);

                    milieuDuTableau = ((borneInf + borneSup) / 2) + 1;
                    Console.WriteLine("(le milieu du tableau est au numero : " + milieuDuTableau + ") ");
                    Console.ReadKey();
                }
            } while (compare != 0);

            Console.WriteLine("le nom a été trouvé à l'index {0:0}", milieuDuTableau);
            Console.ReadKey();
        }
    }
}