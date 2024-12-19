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

            //DECLARING AND PRINTING DATA TYPES
            int age = 26;
            System.Console.WriteLine("Int is for integers");
            Console.WriteLine(age);
            //LONG NUMBERS
            long bigNumber = 90000000L;
            System.Console.WriteLine("Long is a data type for long numbers. They need an L at the end.");
            System.Console.WriteLine(bigNumber);

            //NECESSARY FOR KEEPING CONSOLE OPEN
            Console.ReadLine();
        }
    }
}
