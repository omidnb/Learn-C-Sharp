using System;

namespace Abstraction
{
    abstract class Car
    {
        //Abstract method (does not have a body)
        public abstract void carName(); 

        //Regular method
        public void carModel()
        {
            Console.WriteLine("E30");
        }
    }
    class Bmw : Car
    {
        public override void carName()
        {
            Console.WriteLine("BMW");
        }
    }

    //Interface
    //completely abstract class with only abstract methods and properties
    interface Country
    {
        void city();
    }

    class Iran : Country
    {
        public void city()
        {
            Console.WriteLine("Tehran is the capital city of Iran.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Bmw myCar = new Bmw();
            myCar.carName();
            myCar.carModel();


            Iran myCountry = new Iran();
            myCountry.city();
        }
    }
}
