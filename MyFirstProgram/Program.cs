using System;
using System.ComponentModel.Design;


namespace MyFirstProgram
{
    class Program
    {
        static void Main (string[] args)
        {
            // constrctors = A special method in a class
            //               Same name as the class name
            //               Can be used to assign arguments to fields when creating an object

            Car car1 = new Car("Ford", "Mustang", 2022, "black");
            Car car2 = new Car("Chevrolet", "Corvette", 2021, "blue");

            car1.Drive();
            car2.Drive();

            Console.ReadLine ();
        }

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

        public void Drive()
        {
            Console.WriteLine($"You drive the {make} {model}");
            
            
        }
    }

   

    
}