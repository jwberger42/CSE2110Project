using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE2110Project
{
    class Program
    {
        static String input;
        static int choice;
        static int cpuChoice;
        static void Main(string[] args)
        {
            Console.WriteLine("Rock, paper, scissors, lizard, or Spock?!");
            input = Console.ReadLine().ToLower();
            Logic(PlayerParser(input));
        }
        static int PlayerParser(String input)
        {
            switch (input)
            {
                case "rock":
                    choice = 0;
                    break;
                case "paper":
                    choice = 1;
                    break;
                case "scissors":
                    choice = 2;
                    break;
                case "lizard":
                    choice = 3;
                    break;
                case "spock":
                    choice = 4;
                    break;
            }
            return choice;
        }
        static void Logic(int userin)
        {
            Console.WriteLine("You chose: " + input);
            Random rand = new Random();
            cpuChoice = rand.Next(0,5);

        }
    }
}