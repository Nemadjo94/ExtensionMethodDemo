using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    //Class should be static and public for the extension method to work
    public static class ExtensionClass
    {
        //Add this method to Class1 by referencing it using this Class1 obj
        //Method should be static and public
        public static void ExtensionMethod(this Class1 obj)
        {
            Console.WriteLine("Calling the extension method...");
        }
    }
}
