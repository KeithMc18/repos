using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Vechile
    {
        protected int engineSize = 0;
        protected int numberOfWheels = 0;

        public override string ToString()
        {
            return ("Engine Size :" + engineSize + " || Number of Wheels: " + numberOfWheels);
        }
    }
}
