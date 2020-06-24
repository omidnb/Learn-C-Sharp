using System;

namespace Methods
{
    class Program
    {
        static void MyMethod1(string fName = "Omid ", string lName = "Nobahari")
        {
            Console.WriteLine("My name is " + fName + lName);
        }

        static int MyMethod2(int x , int y)
        {
            return x * 2 + y;
        }

        static void MyMethod3(string car, string model)
        {
            string res = $"My fav car is {car} {model}.";
            Console.WriteLine(res);
        }


        static int PlusMethod(int x , int y)
        {
            return x + y;
        }
        static double PlusMethod(double x, double y)
        {
            return x + y;
        }

        static void Main(string[] args)
        {
            MyMethod1();
            MyMethod1("Omiiid ", "Nb");

            int res = MyMethod2(12, 5);
            Console.WriteLine(res);
            Console.WriteLine(MyMethod2(3, 5));

            MyMethod3("BMW", "E46");

            Console.WriteLine(PlusMethod(8, 5));
            Console.WriteLine(PlusMethod(8.5, 5.2));
        }
    }
}
