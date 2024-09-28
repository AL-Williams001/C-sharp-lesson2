using System;
using System.ComponentModel.Design;


namespace MyFirstProgram
{
    class Program
    {
        static void Main (string[] args)
        {
            // object = An instance of a class
            //          A class can be used as a blueprint to create objects (OOP)
            //          objects can have a fields & methods (characteristics & actions)

            Human human1 = new Human ();
            Human human2 = new Human();

            human1.name = "AL";
            human1.age = 23;

            human2.name = "Art";
            human2.age = 25;


            human1.Eat();
            human1.Sleep();


            human2.Eat();
            human2.Sleep();


            Console.ReadLine ();
        }

    }

    class Human
    {
        public String name;
        public int age;

        public void Eat()
        {
            Console.WriteLine($"{name} is eating");
        }

        public void Sleep()
        {
            Console.WriteLine($"{name} is sleeping");
        }


    }

    
}