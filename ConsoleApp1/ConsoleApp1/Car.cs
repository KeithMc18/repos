using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Car : Vechile
    {

        protected string make = "";
        protected string model = "";

        public Car(string _make, string _model, int _engineSize)
        {
            make = _make;
            model = _model;
            engineSize = _engineSize;
            numberOfWheels = 4; 
        }
    }
}
