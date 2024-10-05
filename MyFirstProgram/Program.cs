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

            // generic = "not specific to a particular data type"
            //            add <T> to: classes, methods, fields, etc.
            //            allows for code reusabilty for different data types

            int[] intArray = { 1, 2, 3 };
            double[] doubleArray = { 1.0, 2.0, 3.0 };
            String[] stringArray = { "1", "2", "3" };

            displayElements(intArray);
            displayElements(doubleArray);
            displayElements(stringArray);

            Console.ReadLine ();
        }

     

        public static void displayElements<Thing>(Thing[] array)
        {
            foreach (Thing item in array)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }



    }

   





}