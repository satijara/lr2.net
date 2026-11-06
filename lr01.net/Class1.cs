using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr01.net
{
    internal class Tabul {
        public double[,] xy = new double[10, 2];
        public int n = 0;
        private double f1 (double x)
        {
            return 2 * x * Math.Pow(Math.E, -x);
        }
        private double f2(double x)
        {
            return Math.Pow((x-1), 3) + Math.Cos(Math.Pow(x, 3));
        }
        private double f3(double x)
        {
            return 2 * Math.Sqrt(Math.Pow(x, 3)) * Math.Sin(Math.Pow(x, 3));
        }
        public void tab (double xn = 8.0, double xk = 12.1, double h = 0.11, double a = 0.8)
        {
            double x = xn, y;
            int i = 0;
            while (x <= xk)
            {
                if (x < 0)
                {
                    y = f1(x);
                }
                else
                {
                    if ((x >= 0) && (x < a))
                    {
                        y = f2(x);
                    }
                    else
                    {
                        y = f3(x);
                    }
                    xy[i, 0] = x;
                    xy[i, 1] = y;
                    x = x + h;
                    i++;
                }
                n = i;
            }
        }
    }
}