using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testGarden
{
    public class ConsoleCalculator
    {
        private Printer _printer;

        public ConsoleCalculator(Printer printer)
        {
            _printer = printer;
        }

        public void Add(int a, int b)
        {
            string sum = $"{a} + {b} = {a + b}";
            _printer.Print(sum);
        }
    }
}
