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

            Console.WriteLine(userName.ToUpper());  //we have ToLower() too
            Console.WriteLine("Length of username: " + userName.Length);

            string max = $"Max between {age} and {myInt} is {Math.Max(myInt, age)}";
            Console.WriteLine(max);

            string stringExamples = $"second char of username is \"{userName[1]}\" ";
            Console.WriteLine(stringExamples);

            string myStr = "Omid Nobahari";
            int charPos = myStr.IndexOf("N");
            string lastName = myStr.Substring(charPos);
            Console.WriteLine(lastName);
        }
    }
}
