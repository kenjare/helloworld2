using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Game
    {
        public void Run()
        {
            Console.WriteLine("Hello traveller! What is your name?");
            string name = Console.ReadLine();
            //This variable is used to store health
            float health = 100.0f;
            //This Value is used to heal the player
            float healthRegen = 20.0f;
            name = Console.ReadLine();
            string role = Console.ReadLine();
            int maxLevel = 100;
            int level = 1;
            bool ready = true;
            Console.WriteLine("Player Name: " + name);
            Console.WriteLine("palyer health: " + health);
            Console.WriteLine("Player Level: " + level);
            Console.WriteLine("Player Role: " + role);
            //Create an application that gets the user's name
            //along with an additional input. print the user's name and input
            //to the connsole along with their stats. Must use all data types 
            Console.Write(name);
            health = health + healthRegen;
            Console.WriteLine(health);
            Console.Write(name + " you just healed" + healthRegen);

        }
    }
}
