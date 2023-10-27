using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testgarden
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            if (a < 0)
            {
                throw new Exception("Boom");
            }
            return a + b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public int Soustract(int a, int b)
        {
            return a - b;
        }

        public decimal Divide(int a, int b)
        {
            return a / (decimal)b;
        }
    }
}
