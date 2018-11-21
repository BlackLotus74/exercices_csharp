using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compte_Bancaires_UML
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool testSaisie = false;
            //double _montant = 0;

            //Compte LeCompte = new Compte();
            //LeCompte.Afficher();

            //Compte LeCompte2 = new Compte(12345, "toto", 1000, -500);            
            //LeCompte2.Afficher();
            //Console.ReadKey();


            //Console.Clear();
            //Compte c1 = new Compte(12345, "toto", 1000, -500);
            //c1.Crediter(2000);
            //c1.Debiter(5300);
            //c1.Afficher();
            //int n = Console.Read();


            //Compte c1 = new Compte(12345, "toto", 1000, -500);
            //Compte c2 = new Compte(45657, "titi", 2000, -1000);
            //c1.Transferer(1300, c2);
            //c1.Afficher();
            //c2.Afficher();


            //Compte c1 = new Compte(12345, "toto", 1000, -500);
            //Compte c2 = new Compte(45657, "titi", 2000, -1000);
            //c1.Transferer(3300, c2);
            //c1.Afficher();
            //c2.Afficher();


            Compte c1 = new Compte(12345, "toto", 1000, -500);
            Compte c2 = new Compte(45657, "titi", 2000, -1000);

            if (c1.Superieur(c2))
            {
                Console.WriteLine("superieur");
            }
            else
            {
                Console.WriteLine("inférieur");

            }
            Console.ReadKey();
        }
    }
}


