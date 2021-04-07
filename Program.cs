using System;

namespace deliverable_two
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Meet 'Not-so-Chatty-Bot', what would you like to say to him? He has a limited vocabulary so\n here's a list of things he has learned to respond to." +
                ": 'hello'; 'bye'; 'sup'; 'hello there'. Give it a try!");

            string lastInput = "";
        another:
            string input = "";
            input = Console.ReadLine().ToLower();

            if (input == lastInput)
            {
                Console.WriteLine("I'm sorry but you have already said that.");
            }
            else
            {
                switch (input)

                {

                    case "hello":
                        Console.WriteLine("Hi good to see you");
                        break;

                    case "sup":
                        Console.WriteLine("I am good");
                        break;

                    case "hello there":
                        Console.WriteLine("General Kenobi");
                        break;

                    case "bye":
                        Console.WriteLine("Good bye!");
                        Environment.Exit(0);
                        break;
                }

            }
            Console.WriteLine("Please try another greeting.");
            lastInput = input;
            goto another;

        }
    }
}
