using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enonce_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string reponse;
            string etat;
            string reparation;
            string bibliotheque1;
            string bibliotheque2;

            Console.WriteLine("il fait beau o/n");

            reponse = Console.ReadLine();

            if (reponse == "o")
            {
                Console.WriteLine("le vélo fonctionne o/n");

                etat = Console.ReadLine();

                if (etat == "o")
                {
                    Console.WriteLine("Je fais une balade à vélo.");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Je vais chez le garagiste.");
                    Console.WriteLine("réparations immédiates ? o/n");
                    reparation = Console.ReadLine();
                    if (reparation == "o")
                    {
                        Console.WriteLine("Je fais une balade à vélo.");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("balade à pied");
                        Console.ReadKey();
                    }

                }

            }
            else
            {
                Console.WriteLine("il ne fait pas beau");
                Console.WriteLine("Le livre est-il dans la bibliothèque du salon ? o/n");
                bibliotheque1 = Console.ReadLine();

                if (bibliotheque1 == "o")
                {
                    Console.WriteLine("Je vais lire");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Je vais trouver madame Bovary à la bibliotheque o/n");
                    bibliotheque2 = Console.ReadLine();
                    if (bibliotheque2 == "o")
                    {
                        Console.WriteLine("je vais m'installer dans un fauteuil et je lirai");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Je choisirai un roman policier et j'irai m'installer dans un fauteuil et lire");
                        Console.ReadKey();
                    }
                }
            }
        }
    }
}