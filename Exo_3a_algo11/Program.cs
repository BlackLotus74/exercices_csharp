using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_3a_algo11
{
    class Program
    {
        static void Main(string[] args)
        {
            int A;                      // A = age
            int compteur = 0;
            int nombrePersonnes = 0;

            do
            {               
                Console.Write("Veuillez saisir votre age : ");
                A = int.Parse(Console.ReadLine());

            if (A < 20)
                {
                compteur++;
                }
                nombrePersonnes++;

            }            
            while (nombrePersonnes < 20);

            Console.WriteLine(" le nombre de personnes de moins de 20 ans est : " + compteur);
            Console.ReadKey();
        }
    }
}
