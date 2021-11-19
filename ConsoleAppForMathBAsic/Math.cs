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

        public double addByLoop(int i, int j)
        {
            double sum = 0.0;
            for(int m =0; m <i; m++)
            {
                if(i % 2 == 0)
                {
                    sum += i;
                } else
                {
                    sum += j;
                }
            }
            return sum;
        }
    }
}
