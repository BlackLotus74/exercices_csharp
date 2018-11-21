using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Compte_Bancaires_UML
{
    public class Compte
    {
        private int NumeroUnique;
        private double SoldeCompte;
        private string NomProprio;
        private double MontantDecouvertAutorise;

        public int NumeroUnique1
        {
            get
            {
                return NumeroUnique;
            }

            set
            {
                NumeroUnique = value;
            }
        }

        public double SoldeCompte1
        {
            get
            {
                return SoldeCompte;
            }

            set
            {
                SoldeCompte = value;
            }
        }

        public string NomProprio1
        {
            get
            {
                return NomProprio;
            }

            set
            {
                NomProprio = value;
            }
        }

        public double MontantDecouvertAutorise1
        {
            get
            {
                return MontantDecouvertAutorise;
            }

            set
            {
                MontantDecouvertAutorise = value;
            }
        }

        //constructeurs
        public Compte()
        {

        }

        //l'autre avec 4 paramètres, un pour chaque attribut
        public Compte(int _NumeroUnique, string _NomProprio, double _SoldeCompte, double _MontantDecouvertAutorise)
        {
            NumeroUnique1 = _NumeroUnique;
            NomProprio1 = _NomProprio;
            SoldeCompte1 = _SoldeCompte;
            MontantDecouvertAutorise1 = _MontantDecouvertAutorise;

        }

        public void Afficher()
        {
            Console.WriteLine("numéro :{0}   nom :{1}   solde :{2}   découvert autorisé :{3} ", NumeroUnique1, NomProprio1, SoldeCompte1, MontantDecouvertAutorise1);
        }

        public void Crediter(double _montant)
        {
            this.SoldeCompte += _montant;
        }

        public bool Debiter(double _montant)
        {
            this.SoldeCompte -= _montant;
            return true;
        }

        public bool Transferer(double _montant, Compte autreCompte)
        {
            SoldeCompte -= _montant;
            autreCompte.Crediter(_montant);

            if (MontantDecouvertAutorise > SoldeCompte)
            {
                Console.WriteLine("Transfert impossible. Decouvert autorisé dépassé.");

            }
            else
            {
                Console.WriteLine("Transfert possible.");
            }
            return false;
        }

        public bool Superieur(Compte autreCompte)
        {

            if (SoldeCompte > autreCompte.SoldeCompte)
            {
                return true;
            }
            else
            {
                return false;
            }


            //int compare = SoldeCompte.CompareTo(autreCompte.SoldeCompte);

            //if (SoldeCompte.CompareTo(autreCompte.SoldeCompte) == -1)
            //{
            //    Console.WriteLine("{0} est plus petit que {1}", SoldeCompte, autreCompte.SoldeCompte);

            //}
            //if (SoldeCompte.CompareTo(autreCompte.SoldeCompte) == 1)
            //{
            //    Console.WriteLine("{0} est plus grand que {1}", SoldeCompte, autreCompte.SoldeCompte);
            //}
            //if (SoldeCompte.CompareTo(autreCompte.SoldeCompte) == 0)
            //{
            //    Console.WriteLine("{0} est égal à {1}", SoldeCompte, autreCompte.SoldeCompte);
            //}
            //return true;
        }
    }
}