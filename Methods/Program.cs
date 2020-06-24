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

        static void Main(string[] args)
        {
            MyMethod1();
            MyMethod1("Omiiid ", "Nb");

            int res = MyMethod2(12, 5);
            Console.WriteLine(res);
            Console.WriteLine(MyMethod2(3, 5));
        }
    }
}
