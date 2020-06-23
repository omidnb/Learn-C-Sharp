using System;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            const int myNum = 15;   //unchangeable
            Console.WriteLine(myNum);

            int a = 25;      //use "long" for very big numbers
            double b = 2.5D; //can use "float" too (D isn't required)
            float c = 2.5F;  //can use "float" too (F is required)
            string myName = "Omid";

            Console.WriteLine("My name is " + myName + " and I'm " + a + " years old.");
        }
    }
}
