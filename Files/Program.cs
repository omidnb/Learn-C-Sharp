using System;
using System.IO;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstTry = "Hello World! :)";
            File.WriteAllText("My_First_File.txt", firstTry);

            string myText = "\nWelcome.";
            File.AppendAllText("My_First_File.txt", myText);

            string readText = File.ReadAllText("My_First_File.txt");
            Console.WriteLine(readText);
        }
    }
}
