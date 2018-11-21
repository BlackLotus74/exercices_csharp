using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enonce01
{
    class Program
    {
        static void Main(string[] args)
        {
            string reponse;

            Console.WriteLine("lecture de l'énoncé");
            Console.WriteLine("Avez-vous compris l'énoncé ?o/n");

            reponse = Console.ReadLine();
            if (reponse == "n")
            {
                Console.WriteLine("relecture de l'énoncé");
                Console.WriteLine("Avez-vous compris l'énoncé ?o/n");
                reponse = Console.ReadLine();

                if (reponse == "n")
                {
                    Console.WriteLine("appel du formateur !");
                    Console.WriteLine("passer à l'enoncé suivant !");

                    Console.ReadKey();

                }
                else
                {

                    Console.WriteLine("Passer à l'enoncé suivant ! Sortie 2 relecture");

                    Console.ReadKey();
                }

            }
        }
    }
}

       
