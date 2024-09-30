using System;
using System.ComponentModel.Design;


namespace MyFirstProgram
{
    class Program
    {
        static void Main (string[] args)
        {
            // overloaded constructors = technique to create multiple constructors,
            //                           with a different set of parameters.
            //                           name + parameters = signature

            Pizza pizza = new Pizza("stuffed crsut", "red sauce", "mozzarella");




            Console.ReadLine ();
        }

        class Pizza
        {
            String bread;
            String sauce;
            String cheese;
            String topping;

            public Pizza(String bread, String sauce, String cheese, String topping)
            {
                this.bread = bread;
                this.sauce = sauce;
                this.cheese = cheese;
                this.topping = topping;
            }

            public Pizza(String bread, String sauce, String cheese)
            {
                this.bread = bread;
                this.sauce = sauce;
                this.cheese = cheese;
            }

            public Pizza(String bread, String sauce)
            {
                this.bread = bread;
                this.sauce = sauce;
            }

            public Pizza(String bread)
            {
                this.bread = bread;
            }
        }

    }

  

   

    
}