using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo4
{
    class Program
    {
        static void Main(string[] args)
        {
            double R;
            float angleA;   
         

            Console.WriteLine("Définissez le rayon R d'un cercle");
            R = double.Parse(Console.ReadLine());

            Console.WriteLine("Définissez un angle A en degré(s)");
            angleA = float.Parse(Console.ReadLine());

            double Aire = Math.PI * (Math.Sqrt(R)) * angleA / 360;
            Console.WriteLine("Aire du secteur circulaire est égal à : "+Aire);
            Console.ReadKey();
            }
    }
}
