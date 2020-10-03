using System;
using System.IO;

namespace Encryption
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Would you like to encrypt or decrypt text? (E/D)");
            string encOrDec = Console.ReadLine();
            Console.Clear();

            if (encOrDec.ToUpper() == "E")
            {
                Console.WriteLine("Please enter the line to encrypt");
                string lineToEncrypt = Console.ReadLine();

                Console.WriteLine("Please enter the number by which you would like to shift the text by");
                int shiftNumber = Convert.ToInt32(Console.ReadLine());

                Processing.AppplyShift(lineToEncrypt, shiftNumber);                         //last edit

            }
            else if (encOrDec.ToUpper() == "D")
            {

            }
            else
            {
                Console.WriteLine("Please enter either E or D, to encrypt or decrypt");
            }
        }
    }
}
