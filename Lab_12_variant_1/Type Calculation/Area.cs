using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab_12_variant_1.Type_Calculation
{
    public class Area : TypesCalculation
    {
        double a, b, c;
        public Area(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            area = CalculateArea();
        }
        double CalculateArea()
        {
            if ((a + b > c) && (a + c > b) && (b + c > a))
            {
                double p = (a + b + c) / 2;
                return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }
            else
                throw new ArgumentException();
        }
        public double? Calculate
        {
            get
            {
                return area;
            }
        }
    }
}
