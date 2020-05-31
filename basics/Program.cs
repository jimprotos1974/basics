using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DimitrisAndCostas.Math;

namespace basics
{
    class Program
    {
        enum Operations
        {
            Undefined = 0,
            Add = 1,
            Subtract = 2
        }
        static void Main(string[] args)
        {
            string input;
            List<double> list;
            Operations operation;

            bool endMainLoop = false;

            bool endOperationLoop;
            bool endNumbersLoop;
            
            while (!endMainLoop)
            {
                input = string.Empty;
                list = new List<double>();
                operation = Operations.Undefined;

                endOperationLoop = false;
                endNumbersLoop = false;

                while (!endOperationLoop)
                {
                    Console.WriteLine("Please pick an operation:");
                    Console.WriteLine("1 to add,");
                    Console.WriteLine("2 to subtract");
                    Console.WriteLine("\"x\" to exit");

                    input = Console.ReadLine();

                    if (input == "1")
                    {
                        operation = Operations.Add;
                        endOperationLoop = true;
                    }
                    else if (input == "2")
                    {
                        operation = Operations.Subtract;
                        endOperationLoop = true;
                    }
                    else if (input == "x")
                    {
                        endOperationLoop = true;
                        return;
                    }

                }

                while (!endNumbersLoop)
                {
                    Console.WriteLine("Please enter a double number (or \"x\" to exit)");

                    input = Console.ReadLine();

                    double outNum = 0;

                    if (input == "x")
                    {
                        break;
                    } else {
                        if (Double.TryParse(input, out outNum))
                        {
                            list.Add(outNum);
                        } else
                        {
                            Console.WriteLine("Careful! You must enter a valid double number.");
                        }
                    }
                }

                double result = 0;

                if (operation == Operations.Add)
                {
                    result = Calculator.Add(list.ToArray());
                } else if (operation == Operations.Subtract)
                {
                    result = Calculator.Subtract(list.ToArray());
                }

                Console.WriteLine(result);
            }

            Console.ReadLine();
        }
    }

}
