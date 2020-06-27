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
    class Program
    {
        static void Main(string[] args)
        {
            Bmw myCar = new Bmw();
            myCar.carName();
            myCar.carModel();
        }
    }
}
