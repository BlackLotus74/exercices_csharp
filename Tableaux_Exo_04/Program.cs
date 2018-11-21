using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tableaux_Exo_04
{
    class Program
    {
        static void Main(string[] args)
        {
            char resultat;
            char maLettre = 'a';
            char [] tableau = new char [10];
            for (int i = 0; i < tableau.Length; i++)
            {
                tableau[i] = maLettre++;
            }
           
            //for (int i = 0; i < tableau.Length; i++)
            //{
            //    Console.WriteLine(i + " = " + tableau[i]);
            //}

            foreach (char Lettre in tableau)
            {
                Console.WriteLine(Lettre);
                Console.ReadKey();
            }

            resultat = tableau.Min();
            Console.WriteLine(" la valeur mini est : " + resultat);
            Console.ReadKey();


        }
    }
}
