using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class BoilingPoint
    {
        public event EventHandler OnBoiled;

        public void BoilWater()
        {
            for (int i = 0; i <= 150; i++)
            {
                Thread.Sleep(100);
                Console.WriteLine("Water Temp is " + i);
                if (i == 100 && OnBoiled!= null)
                {
                    OnBoiled?.Invoke(null,null);
                }
            }
        }
    }
}
