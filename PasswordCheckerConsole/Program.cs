using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PasswordCheckerConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = "JakeCallcut";
            string password = "password";
            int attempts = 0;


            do
            {
                
                Console.WriteLine("Please enter your user ID, or enter 'change' to change your password");
                string inpUser = Console.ReadLine();

                if (inpUser.ToUpper() == "CHANGE")
                {


                    bool changed = false;
                    do
                    {
                        Console.WriteLine("Please enter your old password");
                        string oldpass = Console.ReadLine();

                        if (oldpass == password)
                        {

                            Console.WriteLine("please enter your new password");
                            string newpass = Console.ReadLine();

                            Console.WriteLine("Please re-enter your new password");
                            string newpass2 = Console.ReadLine();

                            if (newpass == newpass2)
                            {
                                password = newpass;
                                Console.WriteLine("Your password has been changed");
                                changed = true;
                            }
                            else
                            {
                                Console.WriteLine("The passwords do not match");
                            }

                        }
                        else
                        {
                            Console.WriteLine("Incorrect old password, please try again");
                        }

                    } while (changed == false);
                }
                else 
                {

                    Console.WriteLine("Please enter your password");
                    string inpPass = Console.ReadLine();

                    if (inpUser == username)
                    {
                        if (inpPass == password)
                        {
                            Console.WriteLine("Access Granted");
                            attempts += 4;
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Incorrect Password, Access Denied");
                            attempts++;
                            Console.ReadKey();
                            Console.Clear();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Incorrect User ID, Access Denied");
                        attempts++;
                        Console.ReadKey();
                        Console.Clear();
                    }
                }

            } while (attempts <= 3);
        }
    }
}
