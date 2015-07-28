using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab_12_variant_1
{
    public class Triangle
    {
        double a, b, c;
        double? area, perimeter;
        public Triangle() { }
        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public void CalculateArea()
        {
            if ((a + b > c) && (a + c > b) && (b + c > a))
            {
                double p = (a + b + c) / 2;
                area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }
            else
                throw new ArgumentException();
        }
        public void CalculatePerimeter()
        {
            if ((a + b > c) && (a + c > b) && (b + c > a))
                perimeter = a + b + c;
            else
                throw new ArgumentException();
        }
        public double? Area
        {
            get
            {
                return area;
            }
            set
            {
                area = value;
            }
        }
        public double? Perimeter
        {
            get
            {
                return perimeter;
            }
            set
            {
                perimeter = value;
            }
        }
    }
}
