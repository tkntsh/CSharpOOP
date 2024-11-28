using System;

namespace oop1
{
    class Program
    {
        static void Main(string[] args)
        {
            dogAge();
        }

        public static void dogAge()
        {
            Console.WriteLine("Enter your age: ");
            int humanAge = Convert.ToInt32(Console.ReadLine());
            int dogAge = humanAge * 7;

            Console.WriteLine("Your age in dog year is: " + dogAge);
        }
    }
}

