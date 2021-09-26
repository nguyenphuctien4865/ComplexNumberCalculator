using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoPhuc
{
    public class ComplexNumber
    {
        private int imaginary;
        private int real;

        public ComplexNumber(int a, int b)
        {
            Real = a;
            Imaginary = b;
        }

        public int Imaginary
        {
            get => imaginary;
            set
            {
                imaginary = value;
            }
        }

        public int Real
        {
            get => real;
            set
            {
                real = value;
            }
        }

        public static ComplexNumber operator +(ComplexNumber x, ComplexNumber y) 
        {
            return new ComplexNumber(x.Real + y.Real, x.Imaginary + y.Imaginary);
        }

        public static ComplexNumber operator -(ComplexNumber x, ComplexNumber y)
        {
            return new ComplexNumber(x.Real - y.Real, x.Imaginary - y.Imaginary);
        }

        public static ComplexNumber operator *(ComplexNumber x, ComplexNumber y)
        {
            return new ComplexNumber(x.Real * y.Real, x.Imaginary * y.Imaginary);
        }

        public  override string ToString()
        {
            if (imaginary > 0)
            {
                return "( "+real + "+" + imaginary + "i )";
            }

            if (imaginary < 0)
            {
                return "( "+ real + "" + imaginary + "i )";
            }

            return "( "+real + "+" + imaginary + "i )";
        }

        public static ComplexNumber Multiply(ComplexNumber x, ComplexNumber y)
        {
            return x * y;
        }

        public static ComplexNumber Add(ComplexNumber x, ComplexNumber y)
        {
            return x + y;
        }

        public static ComplexNumber Subtract(ComplexNumber x, ComplexNumber y)
        {
            return x - y;
        }
    }
}