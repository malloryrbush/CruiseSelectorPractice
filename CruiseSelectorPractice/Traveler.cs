using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CruiseSelectorPractice
{
    class Traveler
    {
        public int Age { get; set; }
        public int Value { get; set; }
        public string ReturnValue { get; set; }

        public Traveler()
        {
            //Default constructor
        }
        public int CustAge()
        {
            if (Age == 50)
            {
                return 1;
            }
            else if (Age == 51)
            {
                return 2;
            }
            else if (Age == 52)
            {
                return 3;
            }
            else if (Age == 53)
            {
                return 4;
            }
            else if (Age == 54)
            {
                return 5;
            }
            else
            {
                return 0;
            }
        }

    }
}