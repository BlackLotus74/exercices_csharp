using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_StructureAlternative02
{
    class Program
    {
        static void Main(string[] args)
        {
            double A;
            double B;
            double C;

            Console.WriteLine("écrivez le nombre A");
            A = float.Parse(Console.ReadLine());

            Console.WriteLine("écrivez le nombre B");
            B = float.Parse(Console.ReadLine());

            Console.WriteLine("écrivez le nombre C");
            C = float.Parse(Console.ReadLine());

            if (A < B && B < C)
            {
                Console.WriteLine("{0} est plus petit que {1} et que {2} ", A, B, C);
                Console.ReadKey();
            }
            else if (A < C && C < B)
            {

                Console.WriteLine("{0} est plus petit que {1} et que {2} ", A, C, B);
                Console.ReadKey();
            }
            else if (B < A && A < C)
            {

                Console.WriteLine("{0} est plus petit que {1} et que {2} ", B, A, C);
                Console.ReadKey();

            }
            else if (B < C && C < A)
            {

                Console.WriteLine("{0} est plus petit que {1} et que {2} ", B, C, A);
                Console.ReadKey();

            }
            else if (C < A && A < B)
            {

                Console.WriteLine("{0} est plus petit que {1} et que {2} ", C, A, B);
                Console.ReadKey();

            }
            else if (C < B && B < A)
            {

                Console.WriteLine("{0} est plus petit que {1} et que {2} ", C, B, A);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine(" les nombres sont égaux {0} = {1} = {2}", A, B, C);
                Console.ReadKey();
            }
        }
    }
}
