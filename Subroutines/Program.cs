﻿using System;
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
                bool working = true;

                try                                                         //tests for format exception
                {
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
                }
                catch (System.FormatException)
                {
                    working = false;
                }

                if (working == true)
                {

                    for (int i = 0; i < numbers.Length; i++)                //populates list
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

                    Console.WriteLine("The mean of those values is " + InputProcessing.FindMean(numbersList));
                    Console.WriteLine("The highest of those values is " + InputProcessing.FindHighest(numbersList));
                    Console.WriteLine("The lowest of those values is " + InputProcessing.FindLowest(numbersList));

                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Please enter a valid input");
                }

            }
            else
            {
                Console.WriteLine("Please enter only numbers, separated by commas");
            }
        }
    }
}
