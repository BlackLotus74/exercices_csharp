using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_2_algo11
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;                 // nombre entier
            int D =2;              /* diviseurs */
            double r, F;          
            bool test1 = false;


            do
            {
                Console.WriteLine(" choisissez un nombre entier supérieur à 2 ");
                test1 = int.TryParse(Console.ReadLine(), out n);
            } 
            while (test1 == false || n <2);

            r = Math.Sqrt(n);
            do
            {
                F = n % D;
                Console.WriteLine(D);
                D++;

            } 
             while ( D <= r && F != 0);

                if (F != 0 || n == 2)
                {
                    Console.WriteLine("Est un nombre premier");
                    Console.ReadLine();
                }

                else
	            {
                    Console.WriteLine("N'est pas un nombre premier ");
                    Console.ReadLine();
	            }

        }
    }
}

// 

//
//
//
//
//
//
//
//
//
//