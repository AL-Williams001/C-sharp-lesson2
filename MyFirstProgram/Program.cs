using System;
using System.ComponentModel.Design;


namespace MyFirstProgram
{
    class Program
    {
        static void Main (string[] args)
        {

            Car[] garage = { new Car("Mustang"), new Car("Corvette"), new Car("Lambo") };

            foreach (Car car in garage)
            {
                Console.WriteLine(car.model);
            }

            Console.ReadLine();
        }

    }

    class Car
    {
        public string model;

        public Car (string model)
        {
            this.model = model;
        }
    }

    







}