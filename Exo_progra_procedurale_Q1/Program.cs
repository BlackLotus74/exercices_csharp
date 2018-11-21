using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_progra_procedurale_Q1
{
    class Program
    {
        struct personne
        {
            public string entrepot;
            public int productivité;
        }
        static void Main(string[] args)
        {
            bool fini = false;

            ArrayList Entrepot = new ArrayList();                    //tableau pour Entrepots
            Entrepot.Add("frais");
            Entrepot.Add("épicerie");
            Entrepot.Add("pondéreux\n");

            Console.WriteLine("le nom des entrepots sont : \n");

            for (int i = 0; i < Entrepot.Count; i++)
            {
                string value = Entrepot[i] as string;
                Console.WriteLine(value);
            }

            char fin = 'n';
            string entrep;
            int prod = 0;

            List<personne> ListPerson = new List<personne>();        ////creation liste typée

            //création list fixe
            //personne employe = new personne();      ////création de nouvelle personne(structure)
            //employe.entrepot = "frais";              ////assignation du nom de l'"entrepot"
            //employe.productivité = 18;
            //ListPerson.Add(employe);
            //employe.entrepot = "frais";              ////assignation du nom de l'"entrepot"
            //employe.productivité = 29;
            //ListPerson.Add(employe);
            //employe.entrepot = "frais";              ////assignation du nom de l'"entrepot"
            //employe.productivité = 79;
            //ListPerson.Add(employe);
            //employe.entrepot = "épicerie";              ////assignation du nom de l'"entrepot"
            //employe.productivité = 29;
            //ListPerson.Add(employe);
            //employe.entrepot = "épicerie";              ////assignation du nom de l'"entrepot"
            //employe.productivité = 48;
            //ListPerson.Add(employe);
            //employe.entrepot = "épicerie";              ////assignation du nom de l'"entrepot"
            //employe.productivité = 78;
            //ListPerson.Add(employe);
            //employe.entrepot = "pondéreux";              ////assignation du nom de l'"entrepot"
            //employe.productivité = 29;
            //ListPerson.Add(employe);
            //employe.entrepot = "pondéreux";              ////assignation du nom de l'"entrepot"
            //employe.productivité = 12;
            //ListPerson.Add(employe);
            //employe.entrepot = "pondéreux";              ////assignation du nom de l'"entrepot"
            //employe.productivité = 99;
            //ListPerson.Add(employe);
            //employe.entrepot = "pondéreux";              ////assignation du nom de l'"entrepot"
            //employe.productivité = 50;
            //ListPerson.Add(employe);

            //liste créé par utilisateur
            do
            {
                Console.Write("nom de l entrepot : ");
                entrep = Console.ReadLine();
                do
                {
                    try
                    {
                        Console.Write("productivité : ");
                        prod = int.Parse(Console.ReadLine());
                        fini = true;
                    }
                    catch (Exception)
                    {

                    }
                } while (fini == false);

                personne employe = new personne();      ////création de nouvelle personne(structure)
                employe.entrepot = entrep;              ////assignation du nom de l'"entrepot"
                employe.productivité = prod;
                ListPerson.Add(employe);                /////ajout structure à la liste typée

                fini = false;
                string recup;
                bool test;
                do
                {
                    Console.WriteLine("avez vous fini [o/n]");
                    recup = Console.ReadLine();
                    test = char.TryParse(recup, out fin);

                } while (fin != 'n' && fin != 'o' || !test);
                fini = false;

                if (fin == 'o')
                {
                    fini = true;
                }
            } while (fini == false);

            Console.Clear();
            Console.WriteLine("Entrepot\tproductivité\n ");
            foreach (personne emploi in ListPerson)
            {
                Console.WriteLine(emploi.entrepot + "    \t" + emploi.productivité);
            }
            Console.ReadKey();

            Console.Clear();
            int moyenne = 0;
            //int compteur = 0;
            int nbrePersonne = 0;
            string triEntrepot=null;
            int choix;

            Console.WriteLine("Productivité moyenne des entrepots : \n[1] pour frais\n[2] pour épicerie\n[3] pour pondéreux\n quel entrepots affiché :");
            choix = int.Parse(Console.ReadLine());
            switch (choix)
            {
                case 1: triEntrepot = "frais";
                    break;
                case 2:
                    triEntrepot = "épicerie";
                    break;
                case 3:
                    triEntrepot = "pondéreux";
                    break;
                default:
                    Console.WriteLine("gros débile!");
                    break;
            }
            foreach (personne perso in ListPerson)
            {
                if (perso.entrepot == triEntrepot)
                {
                    moyenne += perso.productivité;
                    nbrePersonne++;
                }
            }
            double moyenneFinale = moyenne / nbrePersonne;
            Console.WriteLine("moyenne pour l'entrepot frais : " + moyenneFinale);
            Console.ReadKey();
        }
    }
}

//Donner l’algorithme détaillé d’une fonction qui à partir d’un tableau de mesure de la productivité de chacun des préparateurs de commande 
//calcule  la productivité  moyenne des préparateurs pour un entrepôt déterminé par l’appelant
