using System;
using System.Diagnostics;

namespace If_Else
{
    class Program
    {
        static void Main(string[] args)
        {
            //if...else
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

            //switch
            int meat = 5;
            switch (meat)
            {
                case 1:
                    Console.WriteLine("beef");
                    break;
                case 2:
                    Console.WriteLine("fish");
                    break;
                case 3:
                    Console.WriteLine("chicken");
                    break;
                default:
                    Console.WriteLine("looking for some special meats");
                    break;
            }

            //while, do/while
            int i = 1 , j = 1;
            while(i < 5)
            {
                Console.WriteLine(i);
                i++;
            }

            do
            {
                Console.WriteLine(j);
                j++;
            }
            while (j < 5);
        }
    }
}
