using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_1_algo11
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;              //nombre entier dont on cherche à chercher la primalité            
            int diviseur;
            double rac;         // racine carré
            int I = 1;

            Console.WriteLine("Veuillez saisir un nombre entier : ");
            N = int.Parse(Console.ReadLine());

            rac = Math.Sqrt(N);
            diviseur = 2;
            do
            {
               diviseur++;      //incrémente de 1 le diviseur
       
               if (diviseur > rac)
               {
                   Console.WriteLine("Le nombre est premier");
               }
               else
               {
                    Console.WriteLine("Le nombre n'est pas premier");
                    Console.ReadKey();
               }
            }

            while ( N % diviseur != 0 && diviseur <= rac);

            Console.ReadKey();
        }
    }
}

// int a;
// bool diviseur = false; bool test = false;
//
// do
// {
// console.WriteLine("valeur a");
// test = int.TryParse(console.ReadLine(), out a);
// }
// while(test==false);
// if (a > 1)
// {
// do
// { reste = a%n; 
// if (reste == 0)
// {
// diviseur = true;
// break;
// }
// n++;
// } while (diviseur == false && n<a);
// if (diviseur == true)
// {
// console.WriteLine("Le nombre n'est pas premier, il a pour diviseur {0:##,###}", n);
// }
// else
// {
// console.WriteLine("C'est un nombre premier !");
// }
// }
// else
// {
// console.WriteLine("le nombre 1 n'est pas premier");
// }
// console.ReadKey();

