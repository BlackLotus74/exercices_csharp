using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_5_AlgoExercice
{
    class Program
    {
        static void Main(string[] args)
        {
            double S;                     // somme de départ
            int compteurMagasins = 1;


            Console.WriteLine("Combien à Barnabé en poche dans le premier magasin");
            S = double.Parse(Console.ReadLine());

            do
            {
                S = (S / 2) - 1;
                compteurMagasins++;
            }
            while (S > 1);

            Console.WriteLine("Il est allé dans : " + compteurMagasins + " magasins.");
            Console.ReadKey();
        }
    }
}
