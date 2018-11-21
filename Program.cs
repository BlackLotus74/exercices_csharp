using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Faction
{
    class Program
    {
        static void Main(string[] args)
        {

            //Fraction f = new Fraction(12, 7);
            //Fraction f1 = new Fraction(9);
            //Fraction f2 = new Fraction();

            //Ecran.Affiche(f);
            //Ecran.Affiche(f1);
            //Ecran.Affiche(f2);

            //Fraction f3 = new Fraction(4, 7);
            ////Ecran.Affiche(f3);
            //f3.Oppose();

            Fraction f4 = new Fraction(4, 7);
            f4.Inverse();

            Fraction f = new Fraction(11, 7);
            Fraction f1 = new Fraction(5, 4);

            f.Superieur(f1); //retourne vrai


            //Fraction f2 = new Fraction(-75, 90);
            //f.pgcd(f2);

            Console.ReadKey();
        }

    }
}
