using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr01.net
{
    public class Calculation_ab
    {
        private int a, b;

        public int A { get { return a; } set { a = value; } }
        public int B { get { return b; } set { b = value; } }

        public Calculation_ab()
        {
            a = 0;
            b = 0;
        }

        public Calculation_ab(int a)
        {
            this.a = a;
            b = a;
        }

        public Calculation_ab(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public long Calculate()
        {
            if (a > b)
                throw new ArgumentException("a має бути меншим або рівним b");

            long sum = 0;

            for (long i = a; i <= b; i++)
            {
                if (i % 2 == 0 && i % 6 == 2)
                {
                    sum += i;
                }
            }

            return sum;
        }
    }
}