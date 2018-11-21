using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_Emprunt
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 1) Afficher l'annuité et la mensualité constante à rembourser d'après la formule de calcul financière
            //qui vous est communiqué par la  maitrise d'ouvrage.

            double tauxAnnuel = 0;
            int nbrAnneeRbmt = 0;
            double capitalEmprunte = 0;
            double annuite;
            int mois = 0;                                  //nombre de mois de remboursement
            double interetMois;
            double Tm, tmensuel;
            double Q, a;
            double K = 0;                            //capital restant dû
            double mensualite;
            bool saisieUtilisateur1 = false;
            bool saisieUtilisateur2 = false;
            bool saisieUtilisateur3 = false;

            do
            {
                try
                {
                    Console.Write("Veuillez saisir le taux annuel : ");
                    tauxAnnuel = double.Parse(Console.ReadLine());
                    saisieUtilisateur1 = true;
                }
                catch (Exception ex)
                {
                    Console.Write(ex.Message + "\nVeuillez recommencer");
                }
            } while (!saisieUtilisateur1);

            do
            {
                try
                {
                    Console.Write("Veuillez saisir le capital emprunté : ");
                    capitalEmprunte = double.Parse(Console.ReadLine());
                    saisieUtilisateur2 = true;
                }
                catch (Exception ex)
                {
                    Console.Write(ex.Message + "\nVeuillez recommencer");
                }
            } while (!saisieUtilisateur2);

            do
            {
                try
                {
                    Console.Write("Veuillez saisir le nombre d'années de remboursement : ");
                    nbrAnneeRbmt = int.Parse(Console.ReadLine());
                    saisieUtilisateur3 = true;
                }
                catch (Exception ex)
                {
                    Console.Write(ex.Message + "\nVeuillez recommencer");
                }
            } while (!saisieUtilisateur3);

            Console.Clear();
            Console.WriteLine("\nRécapitulatif : \nvotre taux annuel est de : {0} % \nvous souhaitez emprunter : {1}euros \nannées de remboursement : {2}", tauxAnnuel, capitalEmprunte, nbrAnneeRbmt);
            Console.ReadKey();


            mois = nbrAnneeRbmt * 12;                    //soit n nombre mois de remboursement
            Tm = tmensuel = tauxAnnuel / 12;             //inutile d'apres seb !!! karaï !!!!
            Tm = Tm / 100;
            Q = (1 - Math.Pow((1 + Tm), -mois));
            K =
            a = K * Tm / Q;

            //calcul de l'annuité
            Console.Clear();
            interetMois = (capitalEmprunte * Tm) / Q;

            //calcul mensualite constante
            annuite = interetMois * 12;
            Console.WriteLine("la mensualité constante à rembourser est de  : {0:0.00} euros. \nL'annuité est de {1:0.00} euros", interetMois, annuite);
            Console.ReadKey();


            ////////////////////Afficher le tableau d'amortissement mensuel (sur 4 colonnes)///////////////////////////
            //Console.Clear();
            double[,] tabAmortissement = new double[mois, 5];

            for (double i = 0; i < mois; i++)
            {

                double Part_Interet = capitalEmprunte * Tm;
                double Part_Capital = interetMois - Part_Interet;
                capitalEmprunte -= Part_Capital;
                mensualite = interetMois;

                Console.WriteLine(" \naffichage :" + Environment.NewLine + " \npart intérêt : {0:0.0}\npart capital {1:0.0} \ncapital restant {2:0} \nmensualités {3:0}\n", Part_Interet, Part_Capital, capitalEmprunte, mensualite);
            }

            //AffichageTab(ref tabAmortissement, mois, K, );
            Console.ReadKey();
        }

        //private static void AffichageTab(ref double[,] tabAmortissement)
        //{
        //    Console.ReadKey();
        //}

    







        //private static void AffichageTab(ref double[,] _tabAmortissement, double _mois, double _capitalEmprunte, double _Part_Interet, double _Tm, double _interetMois, double _Part_Capital, double _mensualite, double _restantDu)                 //capital restant dû par interet
        //{
        //    _restantDu = _capitalEmprunte;

        //    for (int i = 0; i < _tabAmortissement.GetLength(0); i++)
        //    {

        //        int mois = 0;
        //        double[,] tabAmortissement = new double[mois, 5];

        //        tabAmortissement[i, 0] = _Part_Interet = _capitalEmprunte * _Tm;
        //        tabAmortissement[i, 1] = _Part_Capital = _interetMois - _Part_Interet;
        //        tabAmortissement[i, 2] = _restantDu -= _Part_Capital;
        //        tabAmortissement[i, 3] = _mensualite = _interetMois;
        //    }
            
        //}
    }
}
