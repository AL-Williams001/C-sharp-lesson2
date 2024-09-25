using System;


namespace MyFirstProgram
{
    class Program
    {
        static void Main (string[] args)
        {

            // array = a variable that can store multiple values

            String[] cars = new string[3];

            //String[] cars = { "BMW", "Ford", "Corvette" };

            cars[0] = "Tesla";
            cars[1] = "Ford";
            cars[2] = "Corvette";
 
            

            for(int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }


            Console.ReadLine();

        }
    }
}