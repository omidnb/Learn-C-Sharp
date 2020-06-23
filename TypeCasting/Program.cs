using System;

namespace TypeCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            double myDouble = 3.16;
            int myInt = (int) myDouble;

            Console.WriteLine(myInt);

            bool myBool = true;

            Console.WriteLine(Convert.ToString(myInt));     //convert int to string
            Console.WriteLine(Convert.ToDouble(myInt));     //double to int
            Console.WriteLine(Convert.ToInt32(myDouble));   //int
            Console.WriteLine(Convert.ToInt64(myDouble));   //long
            Console.WriteLine(Convert.ToString(myBool));    //bool to string

            string userName = Console.ReadLine();
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Username: " + userName);
            Console.WriteLine("Age: " + age);

            Console.WriteLine("Max between age and myNum: " + Math.Max(myInt, age));
            //Math.Min / Max / Abs / Sqrt / Round
        }
    }
}
