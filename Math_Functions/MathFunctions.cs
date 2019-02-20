using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Functions
{
    public class MathFunctionClass
    {


        //Square:: Double -> Double 
        public double Square(double value)
        {

            return value * value;
        }

        public double Cube(double value)
        {
            return Math.Pow(value, 3);
        }
    }
}
