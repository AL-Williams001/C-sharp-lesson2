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
            // List = data structure that represents a list of objects that can be accessed by the index.
            //        Similat to array, but can dynamically increase/decrease in size
            //        using System.Collections.Generic;

           
            List<String> food = new List<String> ();

            food.Add("fries");
            food.Add("pizza");
            food.Add("hamburger");
            food.Add("hotdog");
            food.Add("fries");// add method

            //food.Remove("fries"); remove method
            //food.Insert(0, "sushi");  insert method
            //Console.WriteLine(food.Count); count property
            //Console.WriteLine(food.IndexOf("pizza")); IndexOf property
            //Console.WriteLine(food.LastIndexOf("fries")); Last IndexOf property
            //Console.WriteLine(food.Contains("pizza")); Contains method
            //food.Sort (); Sorth method
            //food.Reverse(); Reverse method
            //food.Clear ();

            String[] foodArray = food.ToArray (); //to declare into an array


            foreach (String item in food)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine ();
        }




    }








}