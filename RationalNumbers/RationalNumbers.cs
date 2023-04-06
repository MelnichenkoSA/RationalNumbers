using System;
using System.Collections.Generic;
using System.Text;

namespace RationalNumbers
{
    class RationalNumbers
    {
        public int numerator { get; }
        public int denominator { get; }
        public RationalNumbers(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                throw new ArgumentException("Знаменатель не может быть равен нулю.");
            }

            this.numerator = numerator;
            this.denominator = denominator;
        }
        public static RationalNumbers operator +(RationalNumbers a, RationalNumbers b)
        {
            int numerator = a.numerator * b.denominator + b.numerator * a.denominator;
            int commonDenominator = a.denominator * b.denominator;
            return new RationalNumbers(numerator, commonDenominator);
        }
        public static RationalNumbers operator -(RationalNumbers a, RationalNumbers b)
        {
            int numerator = a.numerator * b.denominator - b.numerator * a.denominator;
            int commonDenominator = a.denominator * b.denominator;
            return new RationalNumbers(numerator, commonDenominator);
        }
        public static RationalNumbers operator *(RationalNumbers a, RationalNumbers b)
        {
            int numerator = a.numerator * b.numerator;
            int denominator = a.denominator * b.denominator;

            return new RationalNumbers(numerator, denominator);
        }
        public static RationalNumbers operator /(RationalNumbers a, RationalNumbers b)
        {
            int numerator = a.numerator * b.denominator;
            int denominator = a.denominator * b.numerator;
            return new RationalNumbers(numerator, denominator);
        }
        public static bool operator >(RationalNumbers a, RationalNumbers b)
        {
            return a.numerator * b.denominator > b.numerator * a.denominator;
        }
        public static bool operator <(RationalNumbers a, RationalNumbers b)
        {
            return a.numerator * b.denominator < b.numerator * a.denominator;
        }
        public static bool operator ==(RationalNumbers a, RationalNumbers b)
        {
            return a.numerator * b.denominator == b.numerator * a.denominator;
        }
        public static bool operator !=(RationalNumbers a, RationalNumbers b)
        {
            return a.numerator * b.denominator != b.numerator * a.denominator;
        }
        public override string ToString()
        {
            Console.WriteLine($"{numerator}/{denominator}");
            return $"{numerator}/{denominator}";

        }
    }
}
