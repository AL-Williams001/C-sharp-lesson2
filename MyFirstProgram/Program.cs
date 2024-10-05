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

            List<Player> players = new List<Player>();

           /* Player player1 = new Player("AL");
            Player player2 = new Player("Art");
            Player player3 = new Player("Arthur");*/


            players.Add(new Player("AL"));
            players.Add(new Player("Art"));
            players.Add(new Player("Arthur"));

            foreach (Player player in players)
            {
                Console.WriteLine(player);
            }


            Console.ReadLine ();
        }







    }

    class Player
    {
        public String username;

        public Player(String username)
        {
            this.username = username;
        }

        public override string ToString()
        {
            return username;
        }
    }






}