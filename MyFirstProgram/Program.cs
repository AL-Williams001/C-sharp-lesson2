using System;


namespace MyFirstProgram
{
    class Program
    {
        static void Main (string[] args)
        {
          
           Random numbers = new Random();
           int num1 = numbers.Next(1, 7);
           int num2 = numbers.Next(1, 7);
           int num3 = numbers.Next(1, 7);
            //double num = numbers.NextDouble();


            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);

            Console.ReadLine();
        }
    }
}