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
        public bool EllDerekszogu { get => Math.Abs((aOldal * aOldal + bOldal * bOldal) - (cOldal * cOldal)) < 10E-7;  }
        public bool EllMegszerkesztheto { get => (aOldal + bOldal > cOldal); }
        public bool EllNovekvosorrend { get => (aOldal <= bOldal && bOldal <= cOldal); }
        public double Kerulet { get => aOldal + bOldal + cOldal; }
        public int SorSzama { get => sorSzama; set => sorSzama = value; }
        public double Terulet { get => (aOldal * bOldal) / 2; }

        public DHaromszog(string sor, int ssz)
        {
            this.SorSzama = ssz;
            string[] oldalak = sor.Split(' ');
            a = double.Parse(oldalak[0]);
            b = double.Parse(oldalak[1]);
            c = double.Parse(oldalak[2]);
        }
    }
}
