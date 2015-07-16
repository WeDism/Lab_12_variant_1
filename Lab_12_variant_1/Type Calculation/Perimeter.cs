using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab_12_variant_1.Type_Calculation
{
    public class Perimeter : TypesCalculation
    {
        double a, b, c;
        public Perimeter(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            perimeter = CalculatePerimetr();
        }
        double CalculatePerimetr()
        {
            if ((a + b > c) && (a + c > b) && (b + c > a))
                return a + b + c;
            else
                throw new ArgumentException();
        }
        public double? Calculate
        {
            get
            {
                return perimeter;
            }
        }
    }
}
