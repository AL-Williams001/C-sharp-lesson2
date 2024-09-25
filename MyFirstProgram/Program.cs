using System;


namespace MyFirstProgram
{
    class Program
    {
        static void Main (string[] args)
        {

            // method = perofrms a section of code, whenever it's called invoked.
            //          benefit = Let's us reuse code w/o writing it multiple times

            String name = "AL";
            int age = 23;


            singHappyBirthday(name, age);
            
            Console.ReadLine();

        }

        static void singHappyBirthday (String name, int age)
        {
            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine($"Happy birthday dear {name}!");
            Console.WriteLine($"You are {age} years old!");
            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine();
        }
    }
}