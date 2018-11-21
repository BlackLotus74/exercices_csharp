using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo5
{
    class Program
    {
        static void Main(string[] args)
        {
            float S;            // somme initiale placée sur un compte
            float I;            // intérêt offert par la banque
            int N;              // nombre d'années de placement de somme S
            double SS;          // somme simple
            double SC;          // somme composée

            Console.WriteLine("Quelle somme est placée sur le compte ?");
            S = float.Parse(Console.ReadLine());

            Console.WriteLine("Indiquez l'intérêt offert par la banque ");
            I = float.Parse(Console.ReadLine()) / 100;

            Console.WriteLine("Nombre d'année de placement ");
            N = int.Parse(Console.ReadLine());

            SS = S * (1 + N * I);
            SC = S * Math.Pow((1 + I), N);

            Console.WriteLine("La valeur acquise avec un intérêt simple est de : " + SS.ToString("##,###.00"));
            Console.WriteLine("La valeur acquise avec un intérêt composée est de : {0:##,###.00}",SC);
            
            Console.ReadKey();
        }
    }
}
