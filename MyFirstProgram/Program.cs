using System;
using System.ComponentModel.Design;


namespace MyFirstProgram
{
    class Program
    {
        static void Main (string[] args)
        {
            //ToString() = converts an object to its string representation so that it is suitable for display
           
           Car car = new Car("Chevy", "Corvette", 2022, "blue");

            Console.WriteLine(car);

            Console.ReadLine();
        }

        class Car
        {
            String make;
            String model;
            int year;
            String color;

            public Car(String make, String model, int year, String color)
            {
                this.make = make;
                this.model = model;
                this.year = year;
                this.color = color;
            }
            public override String ToString()
            {
                String message = $"This is  a {make} {model}";
                return message;
            }
        }

        

    


    }








}