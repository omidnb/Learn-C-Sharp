using System;

namespace Test
{
    class Test1
    {
        public Test1()
        {
            Console.WriteLine("Constructor");
        }
        ~Test1()
        {
            Console.WriteLine("Destructor");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Test1 destructorExample = new Test1();
            
        }
    }
}
