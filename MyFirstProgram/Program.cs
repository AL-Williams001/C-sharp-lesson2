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

            //getters & setters = add security to fields by encapsilation 
            //                    They're accessors found within properties

            //properties = combine aspects of both fields and methoods (share name with a field)
            //get accessor = used to return the property value
            //get accessor = used to assign a new value
            // value keyword = defines the value being assigned by the set (parameter)

            Car car = new Car(400);

            car.Speed = 1000000000;

            Console.WriteLine(car.Speed);



            Console.ReadLine ();
        }

        class Car
        {
            private int speed;

            public Car(int speed)
            {
                Speed = speed;
            }

            public int Speed
            {
                get { return speed; } // get accessor = read

                set
                {
                    if(value > 500)
                    {
                        speed = 500;
                    }
                    else
                    {
                    speed = value;
                    }
                }
            } 
        }






    }

   





}