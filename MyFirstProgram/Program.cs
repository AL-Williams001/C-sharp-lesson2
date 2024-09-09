using System;


namespace MyFirstProgram
{
    class Program
    {
        static void Main (string[] args)
        {
            int x; //declaration
            x = 123; // initialization

            int y = 321; // delcaration + initialization

            int z = x + y;

            int age = 21; //whole integer
            double height = 300.5; // decimal number
            bool alive = false; // true or false
            char symbol = '@';
            String name = "AL";

            Console.WriteLine($"My name is  {name} and my age is {age}");
            Console.WriteLine($"My height is {height}cm");
            Console.WriteLine($"Are you alive {alive}");
            Console.WriteLine($"Your symbol is: {symbol}");

            String username = symbol + name;

            Console.WriteLine($"My username is : {username}");




            Console.ReadLine();
        }
    }
}