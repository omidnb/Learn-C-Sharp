using System;

namespace Inheritance
{
    class Car
    {
        public string brand;
        public int hp;
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
    }
    class Program
    {
        static void Main(string[] args)
        {
            Bmw myBimmer = new Bmw("BMW", 340, 2005);
            Console.WriteLine(myBimmer.year + " "+ myBimmer.brand + " " + myBimmer.model + "(" + myBimmer.hp + "hp)");
        }
    }
}
