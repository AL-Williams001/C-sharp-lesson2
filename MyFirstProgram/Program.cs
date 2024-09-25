using System;


namespace MyFirstProgram
{
    class Program
    {
        static void Main (string[] args)
        {

            // foreach loop = a simplier way to iterate over an array, but it's less flexible

            String[] cars = { "BMW", "Ford", "Corvette" };       
 

            foreach (String car in cars)
            {
                Console.WriteLine(car);
            }

            Console.ReadLine();

        }
    }
}