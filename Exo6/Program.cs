using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo6
{
    class Program
    {
        static void Main(string[] args)
        {
            double A;
            double B;
            double Temp;
            bool testA = false;
            bool testB;

            do
            {
                Console.WriteLine("Définissez le nombre A");
                testA = double.TryParse(Console.ReadLine(),out A);
            }
            while (testA == false);

            do
            {
                Console.WriteLine("Définissez le nombre B");
                testB = double.TryParse(Console.ReadLine(), out B);
            }
            while (testB == false);


            Console.WriteLine("la valeur de A avant inversion {0:n}", A);
            Console.WriteLine("la valeur de B avant inversion {0:n}", B);
          
            Temp = A;
            A = B;
            B = Temp;

            Console.WriteLine("la valeur de A après inversion {0:n}", A);
            Console.WriteLine("la valeur de B après inversion {0:n}", B);

            Console.ReadKey();           
        }
    }
}
