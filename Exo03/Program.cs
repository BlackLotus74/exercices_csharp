using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo03
{
    class Program
    {
        static void Main(string[] args)
        {
            double coteA, coteB, coteC;           
            double P;
            double Aire;

            Console.WriteLine("Définissez les valeures de coteA");
            coteA = float.Parse(Console.ReadLine());
            Console.WriteLine("Définissez les valeures de coteB");
            coteB = float.Parse(Console.ReadLine());
            Console.WriteLine("Définissez les valeures de coteC");
            coteC = float.Parse(Console.ReadLine());

            P = coteA + coteB + coteC;
            Console.WriteLine("Le périmètre du triangle est de "+P);

            Aire = Math.Pow((P / 2 * (P - coteA) * (P - coteB) * (P - coteC)), 0.5);
            Console.WriteLine("calcule de l'aire du triangle "+Aire);
            Console.ReadKey();          
    }
  }
}
