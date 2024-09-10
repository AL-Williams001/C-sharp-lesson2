using System;


namespace MyFirstProgram
{
    class Program
    {
        static void Main (string[] args)
        {
            // type casting = Cvonerting a value to a different date type
            //                Usefule when we accept user input (string)
            //                Different date tupes can do different things 

            double a = 3.14;
            int b = Convert.ToInt32(a);


            int c = 123;
            double d = Convert.ToDouble(c);

            int e = 321;
            String f = Convert.ToString(e);

            string g = "$";
            char h = Convert.ToChar(g);

            string i = "true";
            bool j = Convert.ToBoolean(i);

            Console.WriteLine(b.GetType());
            Console.WriteLine(d.GetType());
            Console.WriteLine(f.GetType());
            Console.WriteLine(h.GetType());
            Console.WriteLine(j.GetType());


            Console.ReadLine();
        }
    }
}