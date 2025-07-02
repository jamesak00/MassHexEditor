using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace MassHexEditor
{
    class Program
    {
        public static string outputFolder;
        public static void Main(string[] args)
        {
            Console.Title = "Mass Hex Editor Program";
            
            while (true)
            {
                Console.WriteLine("~Mass Hex Editor Program~\n(1)Create Files\n(2)Set Custom Output Folder\n(3)Exit");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        while (true)
                        {
                            Console.Clear();
                            FileManager.FileCreation();
                            Console.WriteLine("Would you like to do it again?\n(1)Yes\n(2)No");
                            string choice2 = Console.ReadLine();
                            if (choice2 == "2")
                            {
                                Console.Clear();
                                break;
                            }
                        }
                        break;

                    case "2":
                        Console.Clear();
                        Console.WriteLine($"Current output: {outputFolder}");
                        Console.WriteLine("Enter Output Folder: ");
                        outputFolder = Console.ReadLine();
                        Console.WriteLine($"New output: {outputFolder}");
                        Console.ReadKey();
                        break;

                    case "3":
                        Console.Clear();
                        Console.WriteLine("Thanks for your time!");
                        Console.ReadKey();
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Choose something.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
        }
    }
}
