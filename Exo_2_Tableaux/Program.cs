using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_2_Tableaux
{
    class Program
    {
        static void Main(string[] args)
        {
            string chaine;
            string point = ".";
            char maLettre;
            int compteurLettre = 0;
            bool test = false;

            Console.WriteLine("saisissez une phrase ");

            chaine = Console.ReadLine();

            while (chaine == point)
            {
                Console.WriteLine("La chaine est vide ");
                Console.WriteLine("saisissez une phrase ");
                Console.ReadLine();
            }

            Console.WriteLine("Veillez indiquer quelle lettre vous recherchez. ");
            test = char.TryParse(Console.ReadLine(), out maLettre);

            foreach (char L in chaine)
            {
                if (L == maLettre)
                {
                    compteurLettre++;
                }
            }

            if (compteurLettre > 0)
            {
                Console.WriteLine("la lettre " + maLettre + "est présente : " + compteurLettre + " fois");
            }
            else
            {
                Console.WriteLine("La lettre n'est pas présente ");

            }
            Console.ReadKey();
        }
    }
}
