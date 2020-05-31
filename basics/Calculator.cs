using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DimitrisAndCostas
{
    namespace Math
    {
        public class Calculator
        {
            public static double Add(params double[] numbers)
            {
                double result = 0;

                foreach (double num in numbers)
                {
                    result += num;
                }

                return result;
            }
            public static double Subtract(params double[] numbers)
            {
                double result = 0;

                foreach (double num in numbers)
                {

                    result -= num;
                }

                result += 2 * numbers[0];

                return result;
            }
        }
    }
}
