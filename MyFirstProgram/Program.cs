using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;


namespace MyFirstProgram
{
    class Program
    {
        static void Main (string[] args)
        {
            // interface = defines a "contract" that all the classes inheriting from should follow

           //              An interface declares "What a class should have"
           //              An inheriting class defines "how it should do it"


          //               Benefit = security + multiple inheritance + "plug-and-play"
           
            
            Rabbit rabbit = new Rabbit ();
            Hawk hawk = new Hawk ();
            Fish fish = new Fish ();

            hawk.Hunt();

            rabbit.Flee();

            fish.Hunt();
            fish.Flee();



            
            Console.ReadLine ();
        }

        interface IPrey
        {
            void Flee();
        }

        interface IPreditor
        {
            void Hunt();
        }

        class Rabbit : IPrey
        {
            public void Flee()
            {
                Console.WriteLine("The rabbit runs away");
            }
        }

        class Hawk : IPreditor
        {
            public void Hunt()
            {
                Console.WriteLine("The is hawk hunting for food");
            }
        }

        class Fish : IPreditor, IPrey
        {
            public void Flee()
            {
                Console.WriteLine("The small fish swims away");
            }

            public void Hunt()
            {
                Console.WriteLine("The big fish is searching for a smaller fish");
            }
        }














    }








}