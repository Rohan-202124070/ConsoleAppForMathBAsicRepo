using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppForMathBAsic
{
    public class ChildMath : Math
    {
        public override double Add(double a, double b)
        {
            double double_it = 2;
            return (a + b) * double_it;
        }

    }
}
