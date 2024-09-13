using System;


namespace MyFirstProgram
{
    class Program
    {
        static void Main (string[] args)
        {

            //if statement = a basic form of decision making

            /*Console.WriteLine("Please enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age > 100  )
            {
                Console.WriteLine("You are too old to sign up!");                
            }
            else if (age >= 18)
            {
                Console.WriteLine("You are now signed up!");
            }
            else if (age < 0)
            {
                Console.WriteLine("You haven't been born yet!");
            }
            else
            {
                Console.WriteLine("Must be 18 and above to sign up! ");
            }*/

            Console.WriteLine("Please enter your name: ");
            String name = Console.ReadLine();

            if (name != "")
            {
                Console.WriteLine($"Your name is {name}");                
            }
            else
            {
                Console.WriteLine("You did not enter your name!");
            }


            Console.ReadLine();
        }
    }
}