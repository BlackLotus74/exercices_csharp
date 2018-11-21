using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tableaux_Exo_06
{
    class Program
    {
        static void Main(string[] args)
        {
            string motChoisi;   
            char saisiJoueur;
            int compteur = 6;
            int compteur2 = 0;
            bool lettretrouve = false;

            //joueur 1 :

            do
            {
                Console.WriteLine("\nJoueur 1, veuillez choisir un mot d'au moins 5 caractères : \n");
                motChoisi = Console.ReadLine();
            }
            while (motChoisi.Length < 5);

            motChoisi = motChoisi.ToLower();


            //Console.WriteLine("mot choisi :"+motChoisi);
            //Console.WriteLine("mot caché :"+motCache);
            Console.ReadKey();

            char[] motsecret = motChoisi.ToCharArray();      // chaine de caractere transformé en tableau de caracteres (ToCharArray)
            char[] motTrouve = motChoisi.ToCharArray();

            for (int i = 1; i < motChoisi.Length - 1; i++)
            {
                motsecret[i] = '_' + (Environment.NewLine) ;
                
            }

            //for (int i = 0; i < motsecret.Length; i++)
            //{
            //    Console.Write(motsecret[i]);
            //}
            //Console.ReadKey();

            //joueur 2
            do
            {
                Console.Clear();
                for (int i = 0; i < motsecret.Length; i++)
                {
                    Console.Write(motsecret[i]);
                }
                Console.WriteLine(" ");
                Console.WriteLine("\n\tVeuillez saisir une lettre.");
                saisiJoueur = char.Parse(Console.ReadLine());

                for (int i = 0; i < motChoisi.Length; i++)
                {
                    if (saisiJoueur == motChoisi[i])
                    {
                        motsecret[i] = saisiJoueur;
                        lettretrouve = true;
                    }
                }
                if (lettretrouve == false)
                {                   
                    compteur--;                   
                }

                compteur2 = 0;

                for (int i = 0; i < motTrouve.Length; i++)
                {
                    if (motTrouve[i] == motsecret[i])
                    {
                        compteur2++;
                    }
                }
            }
            while (compteur > 0 && compteur2 < motsecret.Length);

            if (compteur2 == motsecret.Length)
            {
                Console.Clear();
                Console.WriteLine(" \n\tBravo vous avez trouvé le mot secret : " + motChoisi );              
            }
            else
            {
                Console.Clear();
                Console.WriteLine(" \n\tVous avez perdu !!!! ");
            }
            Console.ReadKey();
        }
    }
}
