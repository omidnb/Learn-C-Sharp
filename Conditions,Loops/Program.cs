using System;
using System.Linq;

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

            //while
            int i = 1, j = 5;
            while (i < 3)
            {
                Console.WriteLine(i);
                i++;
            }
            //do...while
            do
            {
                Console.WriteLine(j);
                j++;
            }
            while (j < 7);

            //for
            for (int z = 8; z < 10; z++)
            {
                Console.WriteLine(z);
            }

            //foreach
            string[] cars = { "VW", "BMW", "MAZDA", "BENZ", "TOYOTA", "HONDA" };
            foreach (string car in cars)
            {
                if (car == "MAZDA")
                {
                    Console.WriteLine("mazda3");
                    continue;
                }
                if (car == "TOYOTA")
                {
                    break;
                }
                Console.WriteLine(car);
            }

            //sort
            Array.Sort(cars);
            Console.WriteLine(cars[0]); //BENZ

            //using System.Linq 
            int[] myNum = { 5, 9, 200, 45, 3, 10 };
            Console.WriteLine(myNum.Max());
            Console.WriteLine(myNum.Min());
            Console.WriteLine(myNum.Sum());

        }
    }
}
