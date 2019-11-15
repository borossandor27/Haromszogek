using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haromszogek
{
    class DHaromszog
    {
        double aOldal;
        double bOldal;
        double cOldal;
        public double a ;
        public double b ;
        public double c ;
        bool ellDerekszogu;
        bool ellMegszerkesztheto;
        bool ellNovekvosorrend;
        public double Kerulet { get => a + b + c; }
        public int SorSzama { get => sorSzama; set => sorSzama = value; }
        public double Terulet { get => (a * b) / 2; set => terulet = value; }
        public DHaromszog(string sor, int sorSzama)
            {
            string[] oldalak = sor.Split(' ');
            aOldal = double.Parse(oldalak[0]);
            bOldal = double.Parse(oldalak[1]);
            cOldal = double.Parse(oldalak[2]);
            if (aOldal<=bOldal && bOldal<=cOldal)
            {
                ellNovekvosorrend = true;
            }
            else
            {
                ellNovekvosorrend = false;
            }
            ellMegszerkesztheto = (aOldal + bOldal > cOldal) ? true : false;
            ellDerekszogu = (aOldal * aOldal + bOldal * bOldal == cOldal * cOldal) ? true : false;
        }
        private double terulet;
        private int sorSzama;
    }
}
