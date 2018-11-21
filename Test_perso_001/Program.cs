using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_perso_001
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.SetCursorPosition(50, 4);
            CentrerLeTexte("BONJOUR à VOUS et BIENVENU !!");

            Console.SetCursorPosition(50, 5);
            CentrerLeTexte("______________________________" );

            
            Console.SetCursorPosition(30, 7);
            CentrerLeTexte("Etes-vous prêt pour jouer ? ");
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.White;

            Console.SetCursorPosition(50, 4);
            CentrerLeTexte("Commençons le jeu ....");            
            Console.Clear();

            Console.SetCursorPosition(50, 4);
            CentrerLeTexte("Première question : ");
            Console.ReadKey();
        }


        private static void CentrerLeTexte(string texte)
        {

            int nbEspaces = (Console.WindowWidth - texte.Length) / 2;
            Console.SetCursorPosition(nbEspaces, Console.CursorTop);
            Console.WriteLine(texte);
            Console.ReadKey();
        }

        }
    }
