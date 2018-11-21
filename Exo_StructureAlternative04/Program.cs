using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_StructureAlternative04
{
    class Program
    {
        static void Main(string[] args)
        {
            int nombrereel;
            int x;

            Console.WriteLine(" calcul de la valeur absolue");
            Console.WriteLine(" introduisez un nombre entier  :");

            nombrereel = int.Parse(Console.ReadLine());

            
            x = Math.Abs(nombrereel);

            Console.WriteLine("la valeur absolue est : " + x);
            Console.ReadKey();
        }
    }
}
