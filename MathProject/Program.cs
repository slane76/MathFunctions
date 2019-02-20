using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Math_Functions;


namespace MathProject
{
    class Program
    {
        static void Main(string[] args)
        {
            MathFunctionClass mathFunctions = new MathFunctionClass();

            Console.WriteLine($"The value of 2pi squared is: {mathFunctions.Square(2 * Math.PI):F3}");
            
        }
    }
}
