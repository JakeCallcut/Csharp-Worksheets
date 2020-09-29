using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name");
            string name = Console.ReadLine();

            Console.WriteLine("please enter the number of letters in your first name");
            int firstNameLength = Convert.ToInt16(Console.ReadLine());

            int totalNameLength = name.Length - 1;
            Console.WriteLine("the length of your name is " + totalNameLength);

            string forename = name.Substring(0, firstNameLength);
            Console.WriteLine("your first name is " + forename);

            string surname = name.Substring(firstNameLength,(name.Length - firstNameLength));                                            
            Console.WriteLine("your last name is " + surname);

            Console.ReadKey();
            for (int i = 0; i < 7; i++)             //clears space
            {
                Console.WriteLine(" ");
            }

            Console.WriteLine("please enter where you would like to search in your name");
            int start = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("please enter the number of characters to select");
            int toCollect = Convert.ToInt16(Console.ReadLine());

            bool found = false;
            do
            {
                try
                {
                    string searchTerm = name.Substring(start, toCollect);
                    Console.WriteLine("your search term is: " + searchTerm);
                    found = true;
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Please enter a valid search term");
                    Console.ReadKey();
                }
            } while (found == false);

            Console.ReadKey();
        }
    }
}
