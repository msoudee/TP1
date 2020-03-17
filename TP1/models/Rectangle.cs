using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1.models
{
    class Rectangle : Forme
    {
        public double Longueur { get; set; }
        public double Largeur { get; set; }

        public Rectangle()
        {

        }

        public Rectangle(double longueur, double largeur)
        {
            this.Largeur = largeur;
            this.Longueur = longueur;
        }
        protected override double aire()
        {
            return Largeur * Longueur;
        }

        protected override double perimetre()
        {
            return (Largeur * 2) + (Longueur * 2) ;
        }

        public override string ToString()
        {
            return "Rectangle de longueur = " + this.Longueur + " et largeur = " + this.Largeur + "\nAire = " + aire() + "\nPérimètre = " + perimetre() + "\n";
        }
    }
}
