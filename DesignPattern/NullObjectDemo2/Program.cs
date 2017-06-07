using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObjectDemo2
{
    //Taken from https://en.wikipedia.org/wiki/Null_Object_pattern#C.23
    class Program
    {
        static void Main(string[] args)
        {
            IAnimal dog = new Dog();
            dog.MakeSound(); // outputs "Woof!"

            /* Instead of using C# null, use the Animal.Null instance.
             * This example is simplistic but conveys the idea that if the Animal.Null instance is used then the program
             * will never experience a .NET System.NullReferenceException at runtime, unlike if C# null were used.
             */
            IAnimal unknown = Animal.Null;  //<< replaces: IAnimal unknown = null;
            unknown.MakeSound(); // outputs nothing, but does not throw a runtime exception        

            Console.ReadKey();
        }
    }
}
