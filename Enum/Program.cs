using System;

namespace Enum
{
    enum Days
    {
        Sun,
        Mon,
        Tue,
        Wed=10,
        Thu,
        Fri,
        Sat
    }
    class Program
    {
        static void Main(string[] args)
        {
            Days myDay = Days.Sun;
            Console.WriteLine(myDay);

            int myDay2 = (int)Days.Tue;
            int myDay3 = (int)Days.Sat;
            Console.WriteLine(myDay2);
            Console.WriteLine(myDay3);

            switch (myDay)
            {
                case Days.Sat:
                    Console.WriteLine("It's Saturday");
                    break;
                case Days.Sun:
                    Console.WriteLine("It's Sunday");
                    break;
                default:
                    Console.WriteLine("Go to work baby");
                    break;
            }
        }
    }
}
