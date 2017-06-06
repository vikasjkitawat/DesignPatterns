using ComputerShop;
using ComputerShop.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            //Abstract Factory
            //https://www.codeproject.com/Articles/716413/Factory-Method-Pattern-vs-Abstract-Factory-Pattern

            IMachineFactory factory = new HighEndMachineFactory();// Or new LowEndMachineFactory();
            
            Shop shop = new Shop(factory);
            shop.AssembleMachine();
            Console.ReadKey();
        }
    }
}
