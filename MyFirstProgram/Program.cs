﻿using System;
using System.ComponentModel.Design;


namespace MyFirstProgram
{
    class Program
    {
        static void Main (string[] args)
        {
            // conditional operator = used in conditional assignment if a condition is True/False

            // (condition) ? x : y

            double temperature = 20;
            //String message;

            // message = (temperature >= 15) ? "It's warm outside" : "It's cold outside";

            //Console.WriteLine(message);

            Console.WriteLine((temperature >= 15) ? "It's warm outside" : "It's cold outside");

            Console.ReadLine ();
        }

        
       
        


    }
}