using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learningcsharp
{
    internal class helloworld
    {
        private static void Main(string[] args)
        {
            //PRINT
            System.Console.WriteLine("You can write lines of code like Python's print() function, via console.writeline().");
            Console.WriteLine("Hello world!");

            //INTEGERS
            int age = 26;
                //Int is for integers"
                //Ints can't be bigger or smaller than +/- ~2.1b
            Console.WriteLine(age);

            //LONG NUMBERS
            long bigNumber = 90000000L;
                //Long is a data type for long numbers. They need an L at the end.
            System.Console.WriteLine(bigNumber);

            //DOUBLES
            double negative = -55.2d;
                //doubles are ...
            
            //FLOATS
            

            //NECESSARY FOR KEEPING CONSOLE OPEN
            Console.ReadLine();
        }
    }
}
