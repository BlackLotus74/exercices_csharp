using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_StructureAlternative05
{
    class Program
    {
        static void Main(string[] args)
        {
            float a;
            float b;
            float x;

            Console.WriteLine("Résoudre l'équation du premier degré : ax + b = 0");

            Console.WriteLine("veuillez renseigner la valeur de a : ");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("veuillez renseigner la valeur de b : ");
            b = float.Parse(Console.ReadLine());

            Console.WriteLine("Nous allons rechercher la valeur de x solution de l'équation ax + b = 0");
            Console.Read();
         
            if (a == 0 && b == 0)
            {              
                Console.WriteLine("l'équation est inderterminée ");
            }
            else if (a == 0 && b != 0)
            {
                Console.WriteLine("l'équation est impossible ");               
            }         
            else          
            {
                x = -b / a;
                Console.WriteLine("la solution de l'équation est : x = {0:##,##0.00}", x);
            }       
            Console.ReadKey();    
        }
    }
} 
