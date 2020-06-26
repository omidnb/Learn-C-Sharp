using System;

namespace OOP
{
    class Country
    {
        public string buildIn = "Germany";
        public int year = 2005;
        public string brand = " BMW";
        public void Describe()
        {
            Console.WriteLine(year + brand);
        }
        
    }
    class Car
    {
        string color = "gray";

        static void Describe2()
        {
            Country myObj = new Country();
            Console.WriteLine(myObj.year + myObj.brand);
        }

        static void Main(string[] args)
        {
            Car myObj1 = new Car();
            Console.WriteLine(myObj1.color);

            Country myObj2 = new Country();
            Console.WriteLine(myObj2.buildIn);
            myObj2.year = 2019;
            Console.WriteLine(myObj2.year);  //2019

            Country myObj3 = new Country();
            myObj3.year = 2001; //we don't have access to brand because it's not public
            myObj3.Describe();  //2001 BMW


            Describe2();
        }
    }
}
