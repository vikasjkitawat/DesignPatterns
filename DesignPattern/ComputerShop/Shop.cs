using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShop
{
    class Shop
    {
        private IMachineFactory factory;

        public Shop(IMachineFactory factory)
        {
            this.factory = factory;
        }

        public Computer AssembleMachine()
        {
            Computer computer = new Computer();
            computer.Processor = factory.GetProcessor();
            computer.Harddisk = factory.GetHarddisk();
            computer.Monitor = factory.Display();
        }
    }
}
