using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tableaux_Exo_03
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = 'a';
            char[] alphabet = new char[26];
            string phrase;

            Console.WriteLine("\nsaisissez une phrase d'au moins 120 caracteres." + Environment.NewLine);
            phrase = Console.ReadLine();

            while (phrase.Length < 120)
            {
                Console.WriteLine("\nVeuillez saisir une phrase d'au moins 120 caracteres. " + Environment.NewLine);
                phrase = Console.ReadLine();
                
            }

            phrase = phrase.ToLower();
            for (int i = 0; i < alphabet.Length; i++)
            {
                alphabet[i] = a++;
            }

            int[] caractere = new int[26];

            for (int i = 0; i < phrase.Length; i++)
            {
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (phrase[i] == alphabet[j])
                    {
                        caractere[j]++;
                    }
                }
            }
            for (int k = 0; k < alphabet.Length; k++)
            {
                if (caractere[k] != 0)
                {
                    Console.Write("\nRésultat pour la lettre " + alphabet[k] );
                    Console.WriteLine(" = " + caractere[k] + "");
                }
            }
            Console.ReadKey();
        }
    }
}
