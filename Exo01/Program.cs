using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo01
{
    class Program
    {
        static void Main(string[] args)
        {
        float nombreA;
        float nombreB;
        float moyenne;

        Console.WriteLine("Définissez le nombre A");
        nombreA = float.Parse(Console.ReadLine());

        Console.WriteLine("Définissez le nombre B");
        nombreB = float.Parse(Console.ReadLine());

        moyenne = (nombreA + nombreB) / 2;

        Console.WriteLine("votre moyenne est de " + moyenne);
        Console.ReadKey();
        }
    }
}
