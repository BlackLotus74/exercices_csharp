using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_StructureAlternative03
{
    class Program
    {
        static void Main(string[] args)
        {
            int annee;

            Console.WriteLine(" Choisissez une année ");
            annee = int.Parse(Console.ReadLine());

            if (annee % 4 == 0 && annee % 100 != 0 || annee % 400 == 0)
            {
                Console.WriteLine(" l'année est une année bissextile", annee);
            }
            else
                Console.WriteLine(" l'année n'est pas bissextile");
                Console.ReadKey();

        }
    }
}
