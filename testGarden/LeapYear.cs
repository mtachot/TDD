using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testGarden
{
    public class LeapYear
    {
        public bool IsLeap(int year)
        {
            if (year % 400 == 0) return true;
            if (year % 4 != 0 || year % 100 == 0) return false;
            return true;
        }
    }
}
