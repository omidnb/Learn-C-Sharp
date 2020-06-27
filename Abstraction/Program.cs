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
    interface ICountry
    {
        void city();
    }

    class Iran : ICountry
    {
        public void city()
        {
            Console.WriteLine("Tehran is the capital city of Iran.");
        }
    }


    //multiple interface
    interface IFirstInterface
    {
        void firstMethod();
    }
    interface ISecondInterface
    {
        void secondMethod();
    }

    class MyClass : IFirstInterface, ISecondInterface
    {
        public void firstMethod()
        {
            Console.WriteLine("Hello");
        }
        public void secondMethod()
        {
            Console.WriteLine("Salam");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            //abstract
            Bmw myCar = new Bmw();
            myCar.carName();
            myCar.carModel();

            //interface
            Iran myCountry = new Iran();
            myCountry.city();

            //multiple interface
            MyClass demo = new MyClass();
            demo.firstMethod();
            demo.secondMethod();
        }
    }
}
