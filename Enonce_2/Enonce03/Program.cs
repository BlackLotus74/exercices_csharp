using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enonce03
{
    class Program
    {
        static void Main(string[] args)
        {
            string reponse;

            Console.WriteLine("rangement de la bibliothèque");
            Console.WriteLine("Est-ce que se sont des livres scolaires? o/n");

            reponse = Console.ReadLine();

            if (reponse =="o")
            {
                Console.WriteLine("Est-ce que se sont des livres traitant de philosophie ou de littérature ou de langues étrangères? o/n");
                reponse = Console.ReadLine();
                if (reponse =="o")
	            {
                    Console.WriteLine("Est-ce que la date est postérieur à 1995 ? o/n");
                    reponse = Console.ReadLine();
                    if (reponse=="o")
                    {
                        Console.WriteLine("Livre à conserver");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Je le range dans la boite en carton BOITESCOL");
                        Console.ReadKey();
                    }
                    
	            }
                else
                {
                    Console.WriteLine("Ils ne concernent pas un de ces domaines");
                    Console.WriteLine("je le range dans la boite BOITESCOL");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("Ce ne sont pas des livres scolaires");
                Console.WriteLine("Est-ce que se sont des livres de poche ? o/n");

                reponse = Console.ReadLine();

                if (reponse=="o")
                {
                    Console.WriteLine("Est-ce que se sont des livres de poche non lus ? o/n");
                    reponse = Console.ReadLine();
                    if (reponse=="o")
                    {
                        Console.WriteLine("livres à conserver");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Est-ce que les livres sont des romans ? o/n");
                        reponse = Console.ReadLine();
                        if (reponse=="o")
                        {
                            Console.WriteLine("Ranger les livres dans la boite BOITEROM");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("je le range dans la boite BOITEDIV");
                            Console.ReadKey();
                        }
                    }
                    
                }
                else
                {
                    Console.WriteLine("Est-ce que les livres sont détériorés? o/n");
                    reponse = Console.ReadLine();

                    if (reponse=="o")
                    {
                        Console.WriteLine("Est-ce que les livres sont des romans ? o/n");
                        Console.ReadLine();
                        if (reponse=="o")
                        {
                           Console.WriteLine("Ranger les livres dans la boite BOITEROM");
                            Console.ReadKey(); 
                        }
                        else
                        {
                            Console.WriteLine("je le range dans la boite BOITEDIV");
                            Console.ReadKey();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Je conserve le livre");
                        Console.ReadKey();
                    }
                }
            }
        }
    }
}
