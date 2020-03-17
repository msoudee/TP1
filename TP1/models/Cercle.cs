using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1.models
{
    class Cercle : Forme
    {

        public double Rayon { get; set; }

        public Cercle ()
	    {

	    }

        public Cercle (double rayon)
	    {
            this.Rayon = rayon;
	    }

        protected override double aire()
        {
            return Rayon * Rayon * Math.PI;
        }

        protected override double perimetre()
        {
            return Rayon * 2 * Math.PI;
        }

        public override string ToString()
        {
            return "Cercle de rayon " + this.Rayon + "\nAire = " + aire() + "\nPérimètre = " + perimetre() + "\n";
        }
    }
}
