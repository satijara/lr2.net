using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr01.net
{
    internal class Arrays
    {
        public bool error = false;
        int[] a;
        int length = 20;

        public int Length
        {
            get { return length; }
            set { length = value; }
        }

        public int this[int i]
        {
            get
            {
                if (0 <= i && i < length)
                {
                    return a[i];
                }
                else
                {
                    error = true;
                    return 0;
                }
            }
            set
            {
                if (0 <= i && i < length)
                {
                    a[i] = value;
                }
                else
                {
                    error = true;
                }
            }
        }

        public Arrays()
        {
            a = new int[length];
        }
        public Arrays(int[] mas)
        {
            a = mas;
            length = mas.Length;
        }
        public Arrays(int size)
        {
            Length = size;
            a = new int[length];
            Random rand = new Random();
            for (int i = 0; i < length; i++)
            {
                a[i] = rand.Next(100, 200);
            }
        }
        public (int, int) Sum
        {
            get
            {
                int S = 0, S_even = 0;
                foreach (int i in a)
                {
                    S += i;
                    if (i % 2 == 0)
                    {
                        S_even += i;
                    }
                }
                return (S, S_even);
            }
        }
    }
}