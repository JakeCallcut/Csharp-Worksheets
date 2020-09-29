using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace Subroutines
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your a string of numbers separated with a comma");
            string numbers = Console.ReadLine();

            if (InputProcessing.NoErrors(numbers) == true)
            {
                var numbersList = new List<double>();
                string numToAdd = "";

                for (int i = 0; i < numbers.Length; i++)
                {
                    
                    if (numbers.Substring(i, 1) == ",")
                    {
                        numbersList.Add(Convert.ToDouble(numToAdd));
                        numToAdd = "";
                    }
                    else
                    {
                        numToAdd = numToAdd + numbers.Substring(i, 1);
                    }
                }
                numbersList.Add(Convert.ToDouble(numToAdd));
                numToAdd = "";
                
                //IT WORKS!!!!, last edit

                Console.ReadKey();

            }
            else
            {
                Console.WriteLine("Please enter only numbers, separated by commas");
            }
        }
    }
}
