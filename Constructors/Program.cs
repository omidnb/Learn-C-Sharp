using System;

namespace Constructors
{
    class Color {
        private string clr; //field
        public string Clr   //property
        {
            get { return clr; }
            set { clr = value; }
        }
    }

    class Car
    {
        public string brand;
        public string model;
        public int year;

        public Car(string carBrand, string carModel, int carYear)
        {
            brand = carBrand;
            model = carModel;
            year = carYear;
        }

        static void Main(string[] args)
        {
            Car myCar = new Car("BMW", "E46", 2005);
            Console.WriteLine(myCar.year + " " + myCar.brand + " " + myCar.model);

            Color myClr = new Color();
            myClr.Clr = "red";
            Console.WriteLine(myClr.Clr);

        }
    }
}
