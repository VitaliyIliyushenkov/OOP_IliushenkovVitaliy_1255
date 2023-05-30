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
            Numerator = n; Denominator = d;
            Evclid_Metod();
        }
        public static Rational operator + (Rational r1, Rational r2)
        {
            return new Rational(r1.Numerator * r2.Denominator + r2.Numerator * r1.Denominator,
                r1.Denominator*r2.Denominator);
        }
        public static Rational operator -(Rational r1, Rational r2)
        {
            return new Rational(r1.Numerator * r2.Denominator - r2.Numerator * r1.Denominator,
                r1.Denominator * r2.Denominator);
        }
        public static Rational operator *(Rational r1, Rational r2)
        {
            return new Rational(r1.Numerator * r2.Numerator,
                r1.Denominator * r2.Denominator);
        }
        public static Rational operator /(Rational r1, Rational r2)
        {
            return new Rational(r1.Numerator * r2.Denominator,
                r1.Denominator * r2.Numerator);
        }
        private void Evclid_Metod()
        {
            int max;
            int min;
            int ost;
            do
            {
                if (Numerator > Denominator)
                {
                    max = Numerator; min = Denominator;
                }
                else
                {
                    max = Denominator; min = Numerator;

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
                Numerator /= ost;
                Denominator /= ost;
            }
            while (ost != 1);
        }
    }
}

