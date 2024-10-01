﻿using System;
using System.ComponentModel.Design;


namespace MyFirstProgram
{
    class Program
    {
        static void Main (string[] args)
        {
            //method overriding = provides a new version of a methos inherited from a parent class
            //                    inherited method must be: abstract, virtual, or already overriden
            //                    Used with ToString(), polymorphism

            Dog dog = new Dog();
            Cat cat = new Cat();

            dog.Speak();
            cat.Speak();
           

            Console.ReadLine();
        }

        class Animal
        {
            public virtual void Speak()
            {
                Console.WriteLine("The animal goes *brrr*");
            }
        }

        class Dog : Animal
        {
            public override void Speak()
            {
                Console.WriteLine("The dog goes *woof*");
            }
        }

        class Cat : Animal
        {
            public override void Speak()
            {
                Console.WriteLine("The cat goes *meow*");
            }
        }


    }








}