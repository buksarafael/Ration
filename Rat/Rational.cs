using System;

namespace Rat
{
    internal class Rational
    {
        private int numarator;
        private int numitor;

        public Rational()
        {
            this.numarator = 0;
            this.numitor = 1;
        }

        public Rational(int numarator)
        {
            this.numarator = numarator;
            this.numitor = 1;
        }

        public Rational(int numarator, int numitor)
        {
            this.numarator = numarator;
            this.numitor = numitor;
        }

        

        internal void Simp()
        {
            int c;
            int numarator = this.numarator;
            int numitor = this.numitor;

            while (numitor!=0)
            {
                c = numarator % numitor;
                numarator = numitor;
                numitor = c;
            }

            this.numarator = this.numarator / numarator;
            this.numitor = this.numitor / numarator;

        }

        public static Rational operator -(Rational a) => new Rational(-a.numarator, a.numitor);

        public static Rational operator +(Rational a, Rational b)
        => new Rational(a.numarator * b.numitor + b.numarator * a.numitor, a.numitor * b.numitor);



        public static Rational operator -(Rational a, Rational b)
        => a + (-b);

        public static Rational operator *(Rational a, Rational b)
        {
            
            return new Rational(a.numarator * b.numarator, a.numitor * b.numitor);
        }
        public static Rational operator ^(Rational a, int b)
        {
            return new Rational(Convert.ToInt32(Math.Pow(a.numarator, b)), Convert.ToInt32(Math.Pow(a.numitor, b)));
        }

        public static Rational operator /(Rational a, Rational b)
        {
            if (b.numarator == 0)
            {
                throw new DivideByZeroException();
            }
            return new Rational(a.numarator * b.numitor, a.numitor * b.numarator);
        }

        public static bool operator <(Rational a,Rational b)
        {
            Rational c = new Rational(a.numarator, a.numitor);
            Rational d = new Rational(b.numarator, b.numitor);
            c.Simp();
            d.Simp();

            if (c.numarator / c.numitor < d.numarator / d.numitor)
                return true;
            else
                return false;

        }

        public static bool operator >(Rational a,Rational b)
        {
            Rational c = new Rational(a.numarator,a.numitor);
            Rational d = new Rational(b.numarator,b.numitor);
            c.Simp();
            d.Simp();

            if (c.numarator / c.numitor > d.numarator / d.numitor)
                return true;
            else
                return false;
        }

        public static bool operator >=(Rational a, Rational b)
        {
            Rational c = new Rational(a.numarator, a.numitor);
            Rational d = new Rational(b.numarator, b.numitor);
            c.Simp();
            d.Simp();

            if (c.numarator / c.numitor >= d.numarator / d.numitor)
                return true;
            else
                return false;
        }

        public static bool operator <=(Rational a, Rational b)
        {
            Rational c = new Rational(a.numarator, a.numitor);
            Rational d = new Rational(b.numarator, b.numitor);
            c.Simp();
            d.Simp();

            if (c.numarator / c.numitor <= d.numarator / d.numitor)
                return true;
            else
                return false;
        }

        public static bool operator ==(Rational a, Rational b)
        {
            Rational c = new Rational(a.numarator, a.numitor);
            Rational d = new Rational(b.numarator, b.numitor);
            c.Simp();
            d.Simp();

            if (c.numarator / c.numitor == d.numarator / d.numitor)
                return true;
            else
                return false;
        }

        public static bool operator !=(Rational a, Rational b)
        {
            Rational c = new Rational(a.numarator, a.numitor);
            Rational d = new Rational(b.numarator, b.numitor);
            c.Simp();
            d.Simp();

            if (c.numarator / c.numitor != d.numarator / d.numitor)
                return true;
            else
                return false;
        }




        public override string ToString()
        {
            if (numitor == 1)
            {
                return Convert.ToString(numarator);
            }
            else
            return numarator+"/"+numitor;
        }
    }
}