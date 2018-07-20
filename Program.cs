using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber5
{
    class Program
    {
        static void Main(string[] args)
        {

            bool runProgram = true;
            while (runProgram)
            {

                long constant, f, input;


                Console.Write("Calculate the factorial of a given number:\n");


                Console.Write("Input the number : ");
                f = long.Parse(Console.ReadLine());
                input = f;

                for (constant = f - 1; constant >= 1; constant--)
                    input = input * constant;

                Console.Write("The Factorial of {0} is: {1}\n", f, input);


                Console.WriteLine("Press Y to coninue:");
                string inputFinal = Console.ReadLine();
                if (inputFinal.ToLower() == "y")
                { runProgram = true; }
                else
                { runProgram = false; }

            }
        }
    }
}
