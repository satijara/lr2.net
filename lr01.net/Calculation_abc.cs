using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr01.net
{
    public class Calculation_abc
    {
        private int a, b, c;

        public int A { get { return a; } set { a = value; } }
        public int B { get { return b; } set { b = value; } }
        public int C { get { return c; } set { c = value; } }

        public Calculation_abc()
        {
            a = 0;
            b = 0;
            c = 0;
        }

        public Calculation_abc(int a)
        {
            this.a = a;
            b = 0;
            c = 0;
        }

        public Calculation_abc(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public int Calculate()
        {
            int count = 0;

            if (a > 3)
                count++;

            if (b > 3)
                count++;

            if (c > 3)
                count++;

            return count;
        }
    }
}