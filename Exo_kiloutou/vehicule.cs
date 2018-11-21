using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_kiloutou
{
    class Voiture
    {
        //-------- les attributs--------------
        string s_Marque;
        int i_NumeroDeSerie;
        string s_Modele;

        //--------Constructeur----------------
        //constructeur par default
        public Voiture() { }

        //constructeur d'initialisation
        public Voiture(string marque, int numeroDeSerie, string modele)
        {
            this.s_Marque = marque;
            this.i_NumeroDeSerie = numeroDeSerie;
            this.s_Modele = modele;
        }
        //------------- propriete--------------
        public string Marque
        {
            get { return this.s_Marque; }
            set { this.s_Marque = value; }
        }

        public int NumeroDeSerie
        {
            get { return i_NumeroDeSerie; }
            set { this.i_NumeroDeSerie = value; }
        }

        public string Modele
        {
            get { return this.s_Modele; }
            set { this.s_Marque = value; }
        }
        //--------------Affichage (ToString())-----------------
        public override string ToString()
        {
            return "Marque : " + this.s_Marque + "NumeroDeSerie :" + this.i_NumeroDeSerie + "Modele : " + this.s_Modele;
        }
    }
}
