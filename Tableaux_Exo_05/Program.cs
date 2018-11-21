using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tableaux_Exo_05
{
    class Program
    {
        static void Main(string[] args)
        {
            string phrase;
            bool test = true;

            Console.WriteLine("veuillez saisir votre phrase.");
            phrase = Console.ReadLine();

            for (int k = 0; k < phrase.Length; k++)   // on regarde la longueur de la phrase
            {
                if (phrase[k] == ' ' || phrase[k] == '.')  // on cherche si il y a des espaces et points pour qu'ils soient enlevés
                {
                    phrase = phrase.Remove(k, 1);
                    k--;
                }
            }
            phrase = phrase.ToLower();

            Console.WriteLine("la phrase sans espace et point et : " + phrase);

            int i = 0;
            int j = phrase.Length - 1;

            while (i < j && test == true)
            {
                if (phrase[i] != phrase[j])
                {
                    test = false;
                }
                else
                {
                    test = true;
                    i++;
                    j--;
                }
            }
            if (test == true)
            {
                Console.WriteLine("c'est un palindrome");
            }
            else
            {
                Console.WriteLine("ce n'est pas un palindrome");
            }
            Console.ReadKey();
        }
    }
}
