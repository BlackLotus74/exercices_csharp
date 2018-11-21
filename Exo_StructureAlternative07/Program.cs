using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_StructureAlternative07
{
    class Program
    {
        static void Main(string[] args)
        {
            int jour;
            int mois;
            int annee;
            int resultat4;
            int reste7;
            string jourSemaine;
            int valeurMois;
            bool testj, testm, testa;

            do
            {
               Console.WriteLine("Veuillez saisir un jour : ");
               testj = int.TryParse(Console.ReadLine(), out jour);
               if (testj == false || jour < 1 || jour > 31)
               {
                   Console.WriteLine("Erreur ! Vous devez écrire un jour de 1 à 31");
               }
            } while (jour < 1 || jour > 31);

            do
            {
                 Console.WriteLine("Veuillez saisir un mois : ");
                 testm = int.TryParse(Console.ReadLine(), out mois);
                 if (testm == false || mois < 1 || mois > 12)
                 {
                     Console.WriteLine("Erreur ! Vous devez écrire un mois de 1 à 12");
                 }
            } while (mois < 1 || mois > 12);

            do
            {
                Console.WriteLine("Veuillez saisir une année : ");
                 testa = int.TryParse(Console.ReadLine(), out annee);
                 if (testa == false || annee < 00 || annee > 99)
                 {
                     Console.WriteLine("Erreur ! Vous devez écrire les deux derniers chiffre de l'année");
                 }
            } while (annee < 0 || annee > 99);

            resultat4 = annee / 4;
            int bis = annee % 4;

            switch (mois)
            {
                case 1:
                    if (bis == 0)
                    {
                        valeurMois = 0;
                    }
                    else
                    {
                        valeurMois = 1;
                    }
                    break;

                case 2:
                    if (bis == 0)
                    {
                        valeurMois = 3;
                    }
                    else
                    {
                        valeurMois = 2;
                    }
                    break;

                case 3:
                    valeurMois = 4;
                    break;

                case 4:
                    valeurMois = 0;
                    break;

                case 5:
                     valeurMois = 2;
                    break;

                case 6:
                     valeurMois = 5;
                    break;

                case 7:
                    valeurMois = 0;
                    break;

                case 8:
                    valeurMois = 3;
                    break;

                case 9:
                    valeurMois = 6;
                    break;

                case 10:
                    valeurMois = 1;
                    break;

                case 11:
                    valeurMois = 4;
                    break;

                case 12:
                    valeurMois = 6;
                    break;

                default:
                    valeurMois = 999;
                    Console.WriteLine("couille dans le potage");
                    break;
            }
                    reste7 = (annee + resultat4 + valeurMois + jour) % 7;

            switch (reste7)
                    {
                        case 0:
                            jourSemaine = "samedi";
                            break;
                        case 1:
                            jourSemaine = "dimanche";
                            break;
                        case 2:
                            jourSemaine = "lundi";
                            break;
                        case 3:
                            jourSemaine = "mardi";
                            break;
                        case 4:
                            jourSemaine = "mercredi";
                            break;
                        case 5:
                            jourSemaine = "jeudi";
                            break;
                        case 6:
                            jourSemaine = "vendredi";
                            break;
                        default:
                            jourSemaine = "ERREUR";
                            Console.WriteLine("couille dans le pâté ... Hihihi");
                            break;
                    }
            Console.WriteLine("Le {0}/{1}/19{2:00} était un {3}", jour, mois, annee, jourSemaine);
                    Console.ReadKey();
        }
    }
}
