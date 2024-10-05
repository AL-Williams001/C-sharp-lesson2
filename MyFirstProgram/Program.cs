using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Collections.Generic;


namespace MyFirstProgram
{
    class Program
    {
        static void Main (string[] args)
        {

            // Auto-Implemented properties = shortcut when no additional logic is required in the property
            //                               you do not have to define a field for a property
            //                               you only have to write get; and/or set; inside the property


            Car car = new Car("Ford");

            Console.WriteLine(car.Model);


            Console.ReadLine ();
        }

 
    }

    class Car
    {

       public String Model { get; set; }

        public Car(String model)
        {
            this.Model = model;
        }
    }

   





}