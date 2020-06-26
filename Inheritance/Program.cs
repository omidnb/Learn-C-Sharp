using System;

namespace Inheritance
{
    class Car
    {
        public string brand;
        public int hp;
        
        public virtual void honk()
        {
            Console.WriteLine("BEEP!");
        }
    }

    class Bmw : Car
    {
        public string model = "E46";
        public int year;
        public Bmw(string carBrand, int carHp, int carYear)
        {
            brand = carBrand;
            hp = carHp;
            year = carYear;
        }

        public override void honk()
        {
            Console.WriteLine("BOOGH!");
        }
    }

    class Benz : Car
    {
        public virtual void honk()
        {
            Console.WriteLine("BooghBoogh!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Bmw myBimmer = new Bmw("BMW", 340, 2005);
            Console.WriteLine(myBimmer.year + " "+ myBimmer.brand + " " + myBimmer.model + "(" + myBimmer.hp + "hp)");

            Car myCar = new Car();
            Car myBmw = new Bmw("bmw", 230, 2020);
            Car myBenz = new Benz();

            myCar.honk();   //virtual
            myBmw.honk();   //override
            myBenz.honk();  //virtual
        }
    }
}
