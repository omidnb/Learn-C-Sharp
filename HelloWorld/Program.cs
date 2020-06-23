using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.Write("Hello  ");
            Console.WriteLine("World!");

            string str1 = "Hello ";
            string str2 = "World!";
            string str3 = string.Concat(str1, str2);
            Console.WriteLine(str3);
        }
    }
}
