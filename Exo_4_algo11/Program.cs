using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_4_algo11
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();                    //int choix = aleatoire.Next(0, 100)    
            int valeurATrouver = rnd.Next(0, 101);        // choix ordi  
            int nombreMini = 0;
            int nombreMaxi = 100;
            int nombreDeCoups = 0;
            int valeurSaisi;
            int saisi;

            do
            {
                Console.WriteLine("Veuillez choisir un nombre compris entre " + nombreMini + " et " + nombreMaxi);
                saisi = int.Parse(Console.ReadLine());

                {
                    if (saisi == valeurATrouver)
                    {
                        Console.WriteLine("Félicitation !!!");
                    }
                    else
                    {
                        if (saisi < valeurATrouver)
                        {
                            nombreMini = saisi;
                            Console.WriteLine("Veuillez recommencer");
                        }
                        else
                        {
                            nombreMaxi = saisi;
                            Console.WriteLine("Veuillez recommencer");
                        }
                    }
                }
                nombreDeCoups++;

            }
            while (saisi != valeurATrouver);
            {
                    Console.WriteLine("Vous avez trouvé en " + nombreDeCoups + " coups");
            }
           
            Console.ReadKey();
        }
    }
}
