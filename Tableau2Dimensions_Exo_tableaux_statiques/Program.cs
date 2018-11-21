using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tableau2Dimensions_Exo_tableaux_statiques
{
    class Program
    {
        private static int n;
        private static string formation2;

        static void Main(string[] args)
        {
            bool formatage = false;
            int n = 0;
            string formations;
            string nbStagiaires;

            do
            {
                Console.WriteLine("nombre de formations :");
                try
                {
                    n = int.Parse(Console.ReadLine());
                    formatage = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Votre saisie est erronée, veuillez recommencer. \n" + ex.Message);
                }
            } while (!formatage);

            string[,] tabF = new string[n, 2];  // création tableau 2D

            SaisieFormation(ref tabF);         //creation "fonction"

            Console.Clear();
            for (int i = 0; i < tabF.GetLength(0); i++)
            {
                Console.WriteLine("formation : " + tabF[i, 0] + "nombre de stagiaires : " + tabF[i, 1]);
            }

            Trier(ref tabF);
            Afficher(ref tabF);

            Console.ReadKey();
        }

        private static void Afficher(ref string[,] _tabF)
        {
            for (int i = 0; i < _tabF.GetLength(0); i++)
            {
                Console.WriteLine("");
            }
        }

        private static void Trier(ref string[,] _tabF)
        {
            string temp;
            bool test = false;
            do
            {
                test = false;
                for (int i = 0; i < _tabF.GetLength(0); i++)
                {
                    if (Convert.ToInt32(_tabF[i, 1])> Convert.ToInt32(_tabF[i + 1, 1]))
                    {
                        temp = _tabF[i, 1];
                        _tabF[i, 1] = _tabF[i + 1, 1];
                        _tabF[i + 1, 1] = temp;
                        temp = _tabF[i, 0];
                        _tabF[i, 0] = _tabF[i + 1, 0];
                        _tabF[i + 1, 1] = temp;
                        test = true;
                    }
                }
            } while (true);

        }

        private static void SaisieFormation(ref string[,] _tabF)
        {
            for (int i = 0; i < _tabF.GetLength(0); i++)
            {
                Console.WriteLine("Veuillez saisir le nom de la formation {0}", i + 1);
                _tabF[i, 0] = Console.ReadLine();
            }
            for (int i = 0; i < _tabF.GetLength(0); i++)
            {
                Console.WriteLine("Veuillez saisir le nombre de stagiaires pour la formation {0}", _tabF[i, 0]);
                _tabF[i, 1] = Console.ReadLine();
            }
        }
    }
}



/* prog principal
 * 
         * tableau tabF[n,2] de chaine  
         *
         * 
         * // saisir les formations
         * SaisieFormation(tabF)  // procédure de saisie
 * 
         * // saisir le nombre de stagiaire par formation
         * SaisieNbreStag(tabF)
 * 
         * // trier les formations par ordre croissant de nombre de stagiaires
         * Trier(tabF)
 * 
         * // afficher les formations triées par nombre
 *         Afficher(tabF)
 * fin prog principal */
