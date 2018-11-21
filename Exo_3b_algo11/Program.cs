using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_3b_algo11
{
    class Program
    {
        static void Main(string[] args)
        {
            int A;                      // A = age
            int compteur = 0;
            int nombrePersonnes = 0;
            bool test1 = true;

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

                 if (compteur == 20)
                     {
                     Console.WriteLine("Toutes les personnes ont moins de 20 ans ");
                     Console.ReadKey();
                     }
                 else
                     {
                         if (compteur == 0)
                         {
                         Console.WriteLine("Toutes les personnes ont plus de 20 ans ");
                         }
                         else
                         {
                             Console.WriteLine("le nombre de personnes de moins de 20 ans est : " + compteur); 
                         }

                     Console.ReadKey();
                     }         
	        }
      }
}
