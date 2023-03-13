using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CalculateIron
{
    internal class Rational
    {
        int numerator;
        int denominator;
        public int Numerator 
        {
            get { return numerator; }
            set { numerator = value; } 
        }
        public int Denominator
        { 
            get { return denominator; } 
            set { if (value == 0) throw new Exception("Error");
                else denominator = value; }
        }
        public Rational(int n, int d)
        {
            this.numerator = n; Denominator = d; 
        }
        public Rational Euclids()
        {
            int max;
            int min;
            int ost;
            do
            {
                if (numerator > denominator)
                {
                    max = numerator; min = denominator;
                }
                else
                {
                    max = denominator; min = numerator;

                }

                if (max % min == 0)
                {
                    ost = min;
                }
                else
                {
                    ost = max % min;
                    int ost2 = min % ost;
                    while (ost2 != 0)
                    {
                        int p = ost;
                        ost = ost2;
                        ost2 = p % ost2;
                    }
                }
                numerator /= ost;
                denominator /= ost;
            }
            while (ost != 1);
            return new Rational(numerator, denominator);
        }
        public Rational Plus(Rational r2)
        {
            int n = numerator * r2.denominator + r2.numerator * denominator;
            int d = denominator *r2.denominator;
            return new Rational(n, d);
        }
        public Rational Minus(Rational r2)
        {
            int n = numerator * r2.denominator - r2.numerator * denominator;
            int d = denominator *r2.denominator;
            return new Rational(n, d);
        }
        public Rational Multiply(Rational r2)
        {
            int n = numerator * r2.numerator;
            int d = denominator * r2.denominator;
            return new Rational(n, d);
        }
        public Rational Division(Rational r2)
        {
            int n = numerator * r2.denominator;
            int d = denominator * r2.numerator;
            return new Rational(n, d);
        }
        public override string ToString()
        {
            return numerator + "/" + denominator;
        }
    }
}

