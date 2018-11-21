using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateDeNaissance_Exo_5_majorité
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime DateNaiss;
            bool test = false;

            DateTime auj = DateTime.Today;

            do
            {
                Console.WriteLine("\nVeuillez renseigner votre date de naissance.\n");
                test = DateTime.TryParse(Console.ReadLine(), out DateNaiss);
            } while (!test);

            int Compare = auj.CompareTo(DateNaiss.AddYears(18));

            if (Compare == -1)
            {
                Console.WriteLine("\nVous êtes mineur\n");
            }
            if (Compare == 1)
            {
                Console.WriteLine("\nVous êtes majeur\n");
            }
            if (Compare == 0)
            {
                Console.WriteLine("\nbon anniversaire !\n");
            }

            Console.WriteLine(" \nVotre date de naissance est le : " + DateNaiss.ToString("D"));           // "D" car on veut que la date sans l'heure

            DateTime today = DateTime.Today;
            Console.WriteLine("\nla date du jour est : " + today.ToString("D"));
            Console.ReadKey();

            TimeSpan recherche = today - DateNaiss;
            Console.WriteLine("\nvotre age est  : {0} ans", (recherche.Days / 365));

            Console.ReadKey();
        }
    }
}

