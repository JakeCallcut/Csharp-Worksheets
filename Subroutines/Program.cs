using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace Subroutines
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your a string of numbers separated with a space");
            string numbers = Console.ReadLine();
            int[] numbersArray = { };
            string currentNumber;

            bool stop = false;
            do
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers.Substring(i, 1) == " ")
                    {
                        numbersArray.Append(currentNumber);       
                    }

                    currentNumber = currentNumber + numbers.Substring(i, 1);                            //last edit
                }
            } while ();
        }
    }
}
