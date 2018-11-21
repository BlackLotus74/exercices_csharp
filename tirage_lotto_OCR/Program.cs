using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tirage_lotto_OCR
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aléatoire = new Random();
            List<int> TableauLoto = new List<int>();

                Console.WriteLine("Le tirage du loto va débuter !!! ");
                Console.WriteLine("Le premier numéro est :");

            for (int i = 0; i < 7; i++)
            {                
                int candidat;
                   
                do
                {
                    
                    candidat = aléatoire.Next(1, 49);
                }
                while (TableauLoto.Exists(x => { return x == candidat; }));

                TableauLoto.Add(candidat);
                
            }
            for (int i = 0; i < TableauLoto.Count; i++)
                
            {
                Console.WriteLine(TableauLoto[i]);
                Console.WriteLine("Le numéro suivant est...");
                Console.ReadKey();
            }
            Console.WriteLine("Le tirage est terminé ! ");
            Console.ReadKey();
        }
    }
}
