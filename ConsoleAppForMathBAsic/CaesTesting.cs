using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppForMathBAsic
{
    public class CaesTesting
    {
        private double[] numbers = { 3, -7, 3.3, 1.7, 3, -8, 9.1, 2,5, 2, -1.9}; 

        Math math = new Math(); 
        public double performAction(double x, double y)
        {
            if (x < 5 && y > 10 && y %2 == 0)
            {
                return math.Add(x, y);
            }
            else if (x > 5 && y < 5 || x %2 == 0)
            {
                return math.subtract(x, y);
            }
            else
            {
                return math.multiply(x, y);
            }
        }
        public void TestVoid(int x, int ans)
        {
            if (x == 7)
            {
                ans = 9;
            }
            else
            {
                ans = 10;
            }

        }

        public double findSum(int index)
        {
            double total = 0.0;
            if (index <= 10 && index >= 0)
            {
                for(int i = 0; i < index; ++i)
                {
                    if (numbers[i] > 0)
                    {
                        total += numbers[i];
                    }
                }
            }
            return total;
        }

    }
}
