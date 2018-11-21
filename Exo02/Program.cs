using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo02
{
    class Program
    {
        static void Main(string[] args)
        {
            double RayonR;

            Console.WriteLine("Définissez le rayon R d'une sphère");
            RayonR = double.Parse(Console.ReadLine());
            

            double aire = 4 * Math.PI * Math.Pow(RayonR,2);
            double vol = (double) 4 / 3 * Math.PI * Math.Pow(RayonR, 3); 

            Console.WriteLine("L'aire de la sphère de rayon R {0:##,###} est {1:##,###.00}km² et son volume est {2:#,###.###}",aire,1,vol);
            Console.ReadKey();           
        }
    }
}
