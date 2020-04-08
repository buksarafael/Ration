using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rat
{
    class Program
    {
        static void Main(string[] args)
        {
            Rational r1 = new Rational();
            Rational r2 = new Rational(10);
            Rational r3 = new Rational(10, 5);
            Rational r4 = new Rational();
            Rational r5 = new Rational(10, 3);

            Console.WriteLine(r1);
            Console.WriteLine(r2);
            Console.WriteLine(r3);

            r4 = r2 + r3;

            Console.WriteLine(r4);
            r4.Simp();
            Console.WriteLine(r4);

            r4 = r3 + r5;
            Console.WriteLine(r4);
            r4.Simp();
            Console.WriteLine(r4);
        }
    }
}
