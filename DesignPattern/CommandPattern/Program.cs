using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            BoilingPoint plant = new BoilingPoint();
            
            plant.OnBoiled += MakeSound;
            plant.BoilWater();
            plant.OnBoiled += PopUp;
            plant.BoilWater();
            plant.OnBoiled += ShutDown;
            plant.BoilWater();
            Console.ReadKey();
        }

        private static void ShutDown(object sender, EventArgs e)
        {
            Console.WriteLine("Shutting down Machine");
        }

        private static void PopUp(object sender, EventArgs e)
        {
            Console.WriteLine("Water is boiled, Click popup to close...");
        }

        private static void MakeSound(object sender, EventArgs e)
        {
            Console.WriteLine("Water is boiled, Beep...Beep....Beep...");
        }
    }
}
