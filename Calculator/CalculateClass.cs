using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
   public class CalculateClass
    {
        public double Sum(double x, double y) => x + y;
        public double Minus(double x, double y) => x - y;
        public double Mul(double x, double y) => x * y;

        public double Div(double x, double y)
        {
            if (x == 0)
                throw new DivideByZeroException();
            return x / y;
        }

    }
}
