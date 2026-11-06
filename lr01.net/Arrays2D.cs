using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr01.net
{
    internal class Arrays2D
    {
        public bool error = false;
        int x_length = 10;
        int y_length = 12;
        private int [,] a;
        public int X_Length
        {
            get { return x_length; }
            set { x_length = value; }
        }
        public int Y_Length
        {
            get { return y_length; }
            set { y_length = value; }
        }
        public int this[int i, int j]
        {
            get
            {
                if (0 <= i && i < x_length && 0 <= j && j < y_length)
                {
                    return a[i, j];
                }
                else
                {
                    error = true;
                    return 0;
                }
            }
            set
            {
                if (0 <= i && i < x_length && 0 <= j && j < y_length)
                {
                    a[i, j] = value;
                }
                else
                {
                    error = true;
                }
            }
        }
        void generate()
        {
            for (int i = 0; i < x_length; i++)
            {
                for (int j = 0; j < y_length; j++)
                {
                    this[i, j] = (i + 1) + 2 * (j + 1);
                }
            }
        }
        public Arrays2D(int a_length, int b_length)
        {
            X_Length = a_length;
            Y_Length = b_length;
            a = new int[x_length, y_length];
            generate();
        }
        public Arrays2D()
        {
            a = new int[x_length, y_length];
            generate();
        }
        public (int, int) Sum_Dob
        {
            get
            {
                int P = 1, S = 0;
                foreach (int i in a)
                {
                    S += i;
                    P *= i;
                }
                return (S, P);
            }
        }
    }
}