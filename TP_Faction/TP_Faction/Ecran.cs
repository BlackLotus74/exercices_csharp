using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP_Faction
{

    public class Ecran
    {

        //méthode
        public static void Affiche(Fraction _f)
        {
            if (_f.Denominateur2 == 1 && _f.Numerateur2 >= 0)
            {
                int answer = _f.Numerateur2;
                int answer2 = _f.Denominateur2;

                Console.WriteLine(_f.Numerateur2);
            }
            else
            {
                Console.WriteLine(_f.Numerateur2 + "/" + _f.Denominateur2);
            }
        }
       
    }
}
