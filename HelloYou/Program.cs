﻿using System;

namespace HelloYou
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name");
            string name = Console.ReadLine();

            Console.WriteLine("Welcome " + name);
        }
    }
}
