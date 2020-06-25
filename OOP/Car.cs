using System;

namespace OOP
{
    class Country
    {
        public string buildIn = "Germany";
    }
    class Car
    {
        string color = "gray";
        static void Main(string[] args)
        {
            Car myObj1 = new Car();
            Console.WriteLine(myObj1.color);

            Country myObj2 = new Country();
            Console.WriteLine(myObj2.buildIn);
        }
    }
}
