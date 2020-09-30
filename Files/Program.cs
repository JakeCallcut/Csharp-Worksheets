using System;
using System.IO;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a file name");
            string fileName = Console.ReadLine();
            string path = @"E:\Programming\C#\Worksheets\Files\" + fileName;

            while (true)
            {
                if (File.Exists(path)) { 
                    Console.WriteLine("Would you like to read from or write to the file? (R/W)");
                    string fileMode = Console.ReadLine();

                    if (fileMode.ToUpper() == "W")
                    {

                        using (StreamWriter sw = File.CreateText(path))
                        {
                            bool stop = false;
                            while (stop == false)
                            { 
                                Console.Clear();
                                Console.WriteLine("You can now write to the file");
                                Console.WriteLine("Please enter what you want to write, or type 'exit' to stop writing");
                                string lineToWrite = Console.ReadLine();

                                if (lineToWrite == "exit")
                                {
                                    stop = true;
                                    Console.Clear();
                                    Console.WriteLine("You have stopped writing to the file");
                                }
                                else
                                {
                                    sw.WriteLine(lineToWrite);
                                    Console.WriteLine("Line has been written to file");
                                }
                            }
                        }

                    }
                    else if (fileMode.ToUpper() == "R")
                    {

                        using (StreamReader sr = File.OpenText(path))
                        {
                            string s;
                            while ((s = sr.ReadLine()) != null)
                            {
                                Console.WriteLine(s);
                            }
                        }

                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Please enter R to read or W to write");
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Please enter a valid file in this directory:");
                    Console.WriteLine(@"E:\Programming\C#\Worksheets\Files");
                    Console.ReadKey();
                }
            }
        }
    }
}
