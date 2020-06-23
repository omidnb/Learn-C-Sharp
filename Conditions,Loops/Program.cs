using System;

namespace If_Else
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 25;
            if (age > 21)
            {
                Console.WriteLine("Adult");
            }
            else
            {
                Console.WriteLine("Kiddo");
            }

            int num = 25;
            string result = (num > 21) ? "Adult" : "Kiddo";
            Console.WriteLine(result);
        }
    }
}
