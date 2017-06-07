using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObjectDemo2
{
    // Animal is the base case.
    abstract class Animal : IAnimal
    {
        // A shared instance that can be used for comparisons
        public static readonly IAnimal Null = new NullAnimal();

        // The Null Case: this NullAnimal class should be used in place of C# null keyword.
        private class NullAnimal : Animal
        {
            public override void MakeSound()
            {
                // Purposefully provides no behaviour.
                //VIKAS - START
                Console.WriteLine("No Dog Found");
                //VIKAS - END
            }
        }
        public abstract void MakeSound();
    }
}
