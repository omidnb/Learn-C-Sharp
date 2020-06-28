using System;

namespace Exception_try_catch_
{
    class Program
    {
        static void checkAge(int age)
        {
            if (age > 21)
            {
                throw new Exception("you can smoke");
            }
            else
            {
                Console.WriteLine("not allow to smoke");
            }
        }
        static void Main(string[] args)
        {
            int[] myNum = { 1, 2, 3, 4, 5 };
            try
            {
                Console.WriteLine(myNum[10]);
            }
            catch   //my own msg
            {
                Console.WriteLine("Doesn't exist");
            }

            try
            {
                Console.WriteLine(myNum[10]);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            finally
            {
                Console.WriteLine("Process finished");
            }

            //checkAge Method
            checkAge(25);
        }
    }
}
