using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    //BuilderPattern
    //https://www.codeproject.com/Articles/470476/Understanding-and-Implementing-Builder-Pattern-in

    //BuilderPattern
    //http://www.dotnetexamples.com/2013/07/builder-design-pattern.html

    class Program
    {
        static void Main(string[] args)
        {
            HouseConstructor constructor = new HouseConstructor();

            House concreteHouse = constructor.ConstructConcreteHouse();

            House woodenHouse = constructor.ConstructWoodenHouse();
            
            Console.ReadKey();
        }
    }
}
