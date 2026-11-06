using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr01.net
{
    public class Tetrahedron
    {
        private double a;

        public double A
        {
            get { return a; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Ребро має бути додатним");

                a = value;
            }
        }

        public Tetrahedron()
        {
            A = 1;
        }

        public Tetrahedron(double a)
        {
            A = a;
        }

        public Tetrahedron(Tetrahedron other)
        {
            if (other == null)
                throw new ArgumentNullException(nameof(other));

            A = other.A;
        }

        // Об'єм тетраедра
        public double CalculateVolume()
        {
            return Math.Pow(a, 3) * Math.Sqrt(2) / 12;
        }

        // Висота тетраедра
        public double CalculateHeight()
        {
            return a * Math.Sqrt(6) / 3;
        }

        // Площа повної поверхні
        public double CalculateSurfaceArea()
        {
            return Math.Sqrt(3) * a * a;
        }
    }
}