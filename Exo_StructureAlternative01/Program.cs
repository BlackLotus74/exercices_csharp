using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_StructureAlternative01
{
    class Program
    {
        static void Main(string[] args)
        {
            float A;
            float B;
            float C;

            Console.WriteLine("Définissez le nombre A");
            A = float.Parse(Console.ReadLine());

            Console.WriteLine("Définissez le nombre B");
            B = float.Parse(Console.ReadLine());

            if (A < B)
            {
                Console.WriteLine(A + " plus  petit que " + B);
                Console.ReadKey();
            }
            else
            {
                C = B;
                B = A;
                A = C;

                Console.WriteLine(A + " plus petit que " + B);
                Console.ReadKey();
            }
        }
    }
}
