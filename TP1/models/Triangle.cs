using TP1.models;

namespace TP1
{
    internal class Triangle : Forme
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public Triangle()
        {

        }

        public Triangle(double a, double b, double c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }

        protected override double aire()
        {
            double p = perimetre() / 2;

            return System.Math.Sqrt(p*(p-A)*(p-B)*(p-C));
        }

        protected override double perimetre()
        {
            return A + B + C;
        }

        public override string ToString()
        {
            return "Triangle de côtés A=" + A + " B=" + B + " C=" + C + "\nAire = " + aire() + "\nPérimètre = " + perimetre() + "\n";
        }
    }
}