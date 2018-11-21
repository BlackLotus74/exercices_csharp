using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_kiloutou
{
    class Program
    {
        static void Main(string[] args)
        {
            Voiture voiture;
            voiture.numeroDeSerie = 2098;
            voiture.marque = "Peugeot";
            voiture.modele = "307";
            Console.WriteLine("fiche descriptive : \n{0}, {1}, {2}", voiture.numeroDeSerie, voiture.marque, voiture.modele);
            voiture.numeroDeSerie = 1987;
            voiture.marque = "Renault";
            voiture.modele = "Espace";
            Console.WriteLine("\nfiche descriptive : \n{0}, {1}, {2}", voiture.numeroDeSerie, voiture.marque, voiture.modele);
            voiture.numeroDeSerie = 1203;
            voiture.marque = "Lancia";
            voiture.modele = "Dedra";
            Console.WriteLine("\nfiche descriptive : \n{0}, {1}, {2}", voiture.numeroDeSerie, voiture.marque, voiture.modele);
            voiture.numeroDeSerie = 3049;
            voiture.marque = "Bmw";
            voiture.modele = "324d";
            Console.WriteLine("\nfiche descriptive : \n{0}, {1}, {2}", voiture.numeroDeSerie, voiture.marque, voiture.modele);
            voiture.numeroDeSerie = 1500;
            voiture.marque = "Peugeot";
            voiture.modele = "406";
            Console.WriteLine("\nfiche descriptive : \n{0}, {1}, {2}", voiture.numeroDeSerie, voiture.marque, voiture.modele);
            voiture.numeroDeSerie = 2500;
            voiture.marque = "Ford";
            voiture.modele = "Mondeo";
            Console.WriteLine("\nfiche descriptive : \n{0}, {1}, {2}", voiture.numeroDeSerie, voiture.marque, voiture.modele);
            Console.ReadKey();
        }
    
    class kiloutou
    { 


        }
        public struct Voiture
        {
            public int numeroDeSerie;
            public string marque;
            public string modele;
        }
    }
}

//1) Créer la classe voiture avec
//Constructeur véhicule
//Accesseurs,
//Modifieurs,
//méthode :
//Afficher véhicule,
//Comparer par marque, implémenter la méthode Abstraite nécessaire
