using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_pseudo_code_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //////////////Declaration////////////

            string login;
            string motDePasse;          
            bool motDePasseEstValide = false;

            string[,] tabLogins = new string[3, 3];

            /////////////Definition des logins valides/////////

            tabLogins[0, 0] = "user";                   ////nom
            tabLogins[0, 1] = "";                       ////mdp
            tabLogins[1, 0] = "adelon";                 ////nom
            tabLogins[1, 1] = "leclandessiciliens";     ////mdp
            tabLogins[2, 0] = "jbelmondo";              ////nom
            tabLogins[2, 1] = "leprofessionnel";        ////mdp

            /////////////demande à l'utilisateur login + mdp//////////

            Console.WriteLine("Entrez votre login svp : ");
            login = Console.ReadLine();
            Console.WriteLine("Entrez votre mot de passe svp : ");
            motDePasse = Console.ReadLine();
            //Console.ReadKey();

            ////////////verification couple login + mdp///////////////

            for (int i = 0; i < 3; i++)
            {
                if (tabLogins[i, 0] == login && tabLogins[i, 1] == motDePasse)
                {
                    motDePasseEstValide = true;
                }
            }

            ///////////informer l'utilisateur sur etat connexion////////

            if (motDePasseEstValide == true)
            {
                Console.WriteLine("La connexion est réussie");               
            }
            else
            {
                Console.WriteLine("Vous n'êtes pas autorisé à vous connecter");
                Console.WriteLine("Contactez votre administrateur système");               
            }
            Console.ReadKey();
        }
    }
}
