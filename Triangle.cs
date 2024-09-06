using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IseseisevToo_VsevolodTsarevTARpv23
{
    public class Triangle
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public double Perimeter()
        {
            return A + B + C;
        }

        public double Pindala()
        {
            double s = Perimeter() / 2;
            return Math.Sqrt(s * (s - A) * (s - B) * (s - C));
        }
    }

    public class TriangleOperations
    {
        public static Triangle GetTriangleWithMaxPerimeter(Triangle[] triangles)
        {
            return triangles.OrderByDescending(t => t.Perimeter()).First();
        }

        public static Triangle GetTriangleWithMaxPindala(Triangle[] triangles)
        {
            return triangles.OrderByDescending(t => t.Pindala()).First();
        }
    }
}