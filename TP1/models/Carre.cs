using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1.models
{
    class Carre : Forme
    {
        public double Longueur { get; set; }

        public Carre()
        {

        }

        public Carre(double cote)
        {
            this.Longueur = cote;
        }
        protected override double aire()
        {
            return Longueur * Longueur;
        }

        protected override double perimetre()
        {
            return (Longueur * 2) + (Longueur * 2) ;
        }

        public override string ToString()
        {
            return "Carré de côté " + this.Longueur + "\nAire = " + aire() + "\nPérimètre = " + perimetre() + "\n";
        }
    }
}
