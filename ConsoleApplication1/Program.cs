using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex
{
    class Complex
    {
        public int a, b;
        public Complex(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public static Complex operator +(Complex first, Complex second)
        {
            Complex third = new Complex(first.a + second.a, first.b + second.b);
                return third;
        }
    }
}

 