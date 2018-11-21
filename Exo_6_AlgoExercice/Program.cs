using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_6_AlgoExercice
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int Ordi = rnd.Next(0, 3);
            int Joueur;
            int compteurJ = 0;
            int compteurO = 0;

            do
            {
                Console.Write("\tSaisi joueur : " + Environment.NewLine);
                Joueur = int.Parse(Console.ReadLine());

                if (Joueur >= 0)

                {
                    Ordi = rnd.Next(0, 3);
                    Console.Write("L'ordinateur à choisi :  " + Ordi + Environment.NewLine);

                    if (Joueur - Ordi == 2)
                    {

                        Console.WriteLine("Le joueur gagne ! " + Environment.NewLine);
                        compteurJ++;
                        Console.WriteLine("Score du joueur : " + compteurJ + "\n______________________________" + Environment.NewLine);
                    }
                    if (Ordi - Joueur == 2)
                    {

                        Console.WriteLine("L'ordinateur gagne ! " + Environment.NewLine);
                        compteurO++;
                        Console.WriteLine("Score de l'ordinateur : " + compteurO + "\n______________________________" + Environment.NewLine);
                    }
                    if (Joueur - Ordi == 1)
                    {

                        Console.WriteLine("L'ordinateur gagne ! " + Environment.NewLine);
                        compteurO++;
                        Console.WriteLine("Score de l'ordinateur : " + compteurO + "\n______________________________" + Environment.NewLine);
                    }
                    if (Ordi - Joueur == 1)
                    {

                        Console.WriteLine("Le joueur gagne ! " + Environment.NewLine);
                        compteurJ++;
                        Console.WriteLine("Score du joueur : " + compteurJ + "\n______________________________" + Environment.NewLine);
                    }
                    if (Ordi == Joueur)
                    {

                        Console.WriteLine("Aucun points n'est marqué" + "\n___________________________" + Environment.NewLine);
                    }
                }
            }
            while (compteurJ < 10 && compteurO < 10 && Joueur >= 0);


            Console.WriteLine("Fin de la partie !! ");
            Console.ReadKey();
        }
    }
}
