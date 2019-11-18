using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haromszogek
{
    class DHaromszog
    {
        //-- Fields ------------------
        private double aOldal;
        private double bOldal;
        private double cOldal;
        private int sorSzama;

        //-- Properties -------------------
        public double a { get => aOldal; set => aOldal = value; }
        public double b { get => bOldal; set => bOldal = value; }
        public double c { get => cOldal; set => cOldal = value; }
        private bool EllDerekszogu { get => Math.Abs((aOldal * aOldal + bOldal * bOldal) - (cOldal * cOldal)) < 10E-7;  }
        private bool EllMegszerkesztheto { get => ((aOldal + bOldal) > cOldal); }
        private bool EllNovekvosorrend { get => (aOldal <= bOldal && bOldal <= cOldal); }
        public double Kerulet { get => aOldal + bOldal + cOldal; }
        public int SorSzama { get => sorSzama; set => sorSzama = value; }
        public double Terulet { get => (aOldal * bOldal) / 2; }

        public DHaromszog(string sor, int ssz)
        {
            string szoveg = string.Format("{0,3}", ssz) + ". sor: ";
            string[] oldalak = sor.Split(' ');
            if (double.Parse(oldalak[0]) <= 0)
            {
                throw (new SajatHibakezelo(szoveg + "Az 'a' oldal nem lehet nulla vagy negatív"));
            }
            else if (double.Parse(oldalak[1]) <= 0)
            {
                throw (new SajatHibakezelo(szoveg + "A 'b' oldal nem lehet nulla vagy negatív"));
            }
            else if (double.Parse(oldalak[2]) <= 0)
            {
                throw (new SajatHibakezelo(szoveg + "A 'c' oldal nem lehet nulla vagy negatív"));
            }

            this.SorSzama = ssz;
            a = double.Parse(oldalak[0]);
            b = double.Parse(oldalak[1]);
            c = double.Parse(oldalak[2]);
            if (!this.EllNovekvosorrend)
            {
                throw (new SajatHibakezelo(szoveg + "Az adatok nincsenek növekvő sorrendben!"));
            }
            else if (!this.EllMegszerkesztheto)
            {
                throw (new SajatHibakezelo(szoveg + "A háromszöget nem lehet megszerkeszteni!"));
            }
            else if (!this.EllDerekszogu)
            {
                throw (new SajatHibakezelo(szoveg + "A háromszög nem derékszögű!"));
            }
        }
    }
}
