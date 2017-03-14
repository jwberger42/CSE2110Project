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
            switch (input)
            {
                case "rock":
                    Logic(0);
                    break;
                case "paper":
                    Logic(1);
                    break;
                case "scissors":
                    Logic(2);
                    break;
                case "lizard":
                    Logic(3);
                    break;
                case "spock":
                    Logic(4);
                    break;
                default:
                    Console.WriteLine("Don't enter something that is not a choice!!");
                    break;
            }
        }
        static void Logic(int userin)
        {
            Random rand = new Random();
            cpuChoice = rand.Next(0,5);
        }
    }
}