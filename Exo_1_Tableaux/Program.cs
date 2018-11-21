using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_1_Tableaux
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int chiffre;
            bool test1 = false;
            bool test2 = false;
            int[] tableau = new int[5] { 5, 2, 3, 4, 1 };

            Array.Sort(tableau);

            do
            {
                Console.WriteLine("chercher si un nombre x figure parmis les elements : ");
                test1 = int.TryParse(Console.ReadLine(), out chiffre);
            }
            while (test1 == false);

            foreach (int nombre in tableau)
            {
                if (nombre == chiffre)
                {
                    Console.WriteLine("le nombre {0} est a l'indice {1}", chiffre, i);
                    test2 = true;
                }
                i++;
            }
            if (test2 == false)
            {
                Console.WriteLine("Le chiffre n'a pas été trouvé dans le tableau");
            }
            Console.ReadKey();
        }
    }
}
