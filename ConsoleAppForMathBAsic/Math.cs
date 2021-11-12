using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppForMathBAsic
{
    public class Math
    {
        public virtual double Add(double a, double b)
        {
            return a + b;
        }
        public double subtract(double a, double b)
        {
            return a - b;
        }
        public double devide(double a, double b)
        {
            if (b == 0)
                throw new ArgumentException(nameof(b), "Denominator cannot be zero");
            return a / b;
        }
        public double multiply(double a, double b)
        {
            return a * b;
        }

    }
}
