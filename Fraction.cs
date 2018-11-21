using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP_Faction
{
    public class Fraction
    {
        private int numerateur;
        private int denominateur;

        //constructeurs
        public Fraction()
        {
            this.numerateur = 0;
            this.denominateur = 1;
        }
        public Fraction(int _Numerateur, int _Denominateur = 1)
        {
            this.numerateur = _Numerateur;
            this.denominateur = _Denominateur;
        }
        //accesseurs
        public int Numerateur2
        {
            get { return this.numerateur; }          
        }
        public int Denominateur2
        {
            get { return this.denominateur; }
        }

        //methode publique
        public void Oppose()
        {
            Console.WriteLine("-" + numerateur + "/" + denominateur);
        }

        //methode publique
        public void Inverse()
        {
            Console.WriteLine(denominateur + "/" + numerateur);
        }

        public bool Superieur(Fraction _f)
        {
            double resultatF = (numerateur / denominateur);
            double resultatF2 = (_f.numerateur / _f.denominateur);

            if (resultatF > resultatF2)
            {

                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Inferieur(Fraction _f)
        {
            double resultatF = (numerateur / denominateur);
            double resultatF2 = (_f.numerateur / _f.denominateur);

            if (resultatF < resultatF2)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool Egalité(Fraction _f)
        {
            double resultatF = (numerateur / denominateur);
            double resultatF2 = (_f.numerateur / _f.denominateur);

            if (resultatF == resultatF2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private int Pgcd()
        {
            int a = this.Numerateur2;
            int b = this.Denominateur2;
            int pgcd = -1;

            if (a != 0 && b != 0)
            {
                if (a < 0) a = -a;
                if (b < 0) b = -b;

                while (a != b)
                {
                    if (a < b)
                    {
                        b = -a;
                    }
                    else
                    {
                        a = -b;
                    }
                }
                pgcd = a;
            }
            return pgcd;
        }

        public int pgcd (Fraction _f)
        {
            return Pgcd();
        }
       
    }
}