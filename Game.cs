using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Game
    {
        string Combinewords(string word1, string word2)
        {
            string result = word1 + word2;
            return result;
        }
        int SumTwoNum(int num1, int num2)
        {
            int result = num1 + num2;
            return result;
        }

        void PrintStats(string name, float playerHealth, int damage, int level, string role)
        {
            //Prints player stats to the screen 
            Console.WriteLine("Player Name: " + name);
            Console.WriteLine("Player Health: " + playerHealth);
            Console.WriteLine("Player Damage: " + damage);
            Console.WriteLine("Player level: " + level);
            Console.WriteLine("Player Role: " + role);
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
        public void Run()
        {
            void ChangeName(string oldName, string newName)
            {
                oldName = newName;
            }
            {

                string newworld = Combinewords("Peanut", "Butter");
                int number = SumTwoNum(2, 2);
                bool gameOver = false;
                while (gameOver == false)
                { //This variable is used to store health
                    float health = 100.0f;
                    //This Value is used to heal the player
                    float healthRegen = 20.0f;
                    int damage = 120;
                    int level = 1;
                    bool ready = true;
                    string role = "None";
                    Console.WriteLine("Hello traveller! What is your name?");
                    string name = Console.ReadLine();
                    Console.WriteLine("Welcome " + name + " ! " + " Please select a role");
                    Console.WriteLine("Press 1 for Roamer role");
                    Console.WriteLine("Press 2 for Hunter role");
                    char input = Console.ReadKey().KeyChar;
                    if (input == '1')
                    {
                        health = 200;
                        role = ("Roamer");
                    }
                    else if (input == '2')
                    {
                        damage = 40;
                        role = "Hunter";
                        int mana = 100;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input. Using default stats");
                    }
                    Console.Clear();

                    string petname = "Riley";
                    Console.WriteLine("Player Name: " + name);
                    Console.WriteLine("player health: " + health);
                    Console.WriteLine("Player Level: " + level);
                    Console.WriteLine("Player Role: " + role);
                    //Create an application that gets the user's name
                    //along with an additional input. print the user's name and input
                    //to the connsole along with their stats. Must use all data types 
                    Console.Write(name);
                    health = health + healthRegen;
                    Console.WriteLine(health);
                    Console.Write(name + " you just healed" + healthRegen);
                    Console.Write("press any to continue. ");
                    Console.ReadKey();
                    Console.WriteLine("You've been approached by a wild dog.");
                    Console.WriteLine("you can Try to feed it the last of your food, or you can ignore it");
                    Console.WriteLine("Press 1 to feed");
                    Console.WriteLine("Press 2 to ignore");
                    input = Console.ReadKey().KeyChar;
                    if (input == '1')
                    {
                        health = 100;
                        damage = 500;
                        Console.WriteLine("You have a New Companion");
                        Console.WriteLine("now you must Feed it once a day");
                    }
                    else if (input == '2')
                    {
                        Console.WriteLine("You have chosen to fight ");
                        health = 20;
                        damage = 133;
                        Console.WriteLine("You have been heavily damaged and you're bleeding out");
                        Console.WriteLine("you find a nearby merchant and ask if he can help");
                        Console.WriteLine("He ignores you");
                    }
                    else
                    {
                        Console.WriteLine("You have not chosen the dog attacked you and took of your left hand");
                    }
                    Console.WriteLine(name + "You have come across an abandoned gas station.");
                    Console.WriteLine("your new companion begins to bark at it then realize you haven't gave it a name");
                    Console.WriteLine("what is the name you have chosen?");
                    petname = Console.ReadLine();
                    Console.WriteLine("you and" + petname + "Hear a sound coming from the utility closet");
                    Console.WriteLine("What do you choose to do");
                    Console.WriteLine("Do you search it");
                    Console.WriteLine("Do you Continue searching");
                    Console.WriteLine("Press s to Search");
                    Console.WriteLine("Press C to continue");
                    input = Console.ReadKey().KeyChar;
                    if (input == 's')
                    {
                        Console.WriteLine("you open the closet and find a severly injured cashier missing his lower torso");
                        Console.WriteLine("You Try and ask if the cashier is ok but then" + petname + "Begins to attack The wounded teenager");
                    }
                    else if (input == 'c')
                    {
                        Console.WriteLine("You continue to search and find a machete");
                    }
                }
            }
        }
    }
}
