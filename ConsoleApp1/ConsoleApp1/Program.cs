using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            Vechile vechile = new Vechile();

            Car car1 = new Car("Ford", "Fiesta", 1250);
            Car car2 = new Car("Opel", "Astra", 1600);


            Console.WriteLine(vechile.ToString());
            Console.WriteLine(car1.ToString());
            Console.WriteLine(car2.ToString());



        }
    }
}
