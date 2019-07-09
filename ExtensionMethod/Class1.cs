using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    //Class1 must be public for ExtensionClass to give it the ExtensionMethod
    public class Class1
    {
        public void Display()
        {
            Console.WriteLine("Displaying...");
        }

        public void Print()
        {
            Console.WriteLine("Printing...");
        }
    }
}
