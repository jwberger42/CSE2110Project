using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE2110Project
{
    class Program
    {
        private static String input;
        private static int choice;
        private static int cpuChoice;
        private static int pScore = 0;
        private static int eScore = 0;
        public static void Main(string[] args)
        {
            Console.WriteLine("Rock, paper, scissors, lizard, or Spock?!");
            input = Console.ReadLine().ToLower();
            Logic(PlayerParser(input));
        }
        private static int PlayerParser(String input)
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
        private static void Logic(int userin)
        {
            Console.WriteLine("You chose: " + input);
            Random rand = new Random();
            cpuChoice = rand.Next(0,5);
            switch (cpuChoice)
            {
                case 0:
                    if (userin == 0) { Console.WriteLine("You both chose rock! Stalemate!"); }
                    if (userin == 1) { Console.WriteLine("Paper covers rock! You win!"); pScore++; }
                    if (userin == 2) { Console.WriteLine("Rock crushes scissors! You lost!"); eScore++; }
                    if (userin == 3) { Console.WriteLine("Rock crushes lizard! You lost!"); eScore++; }
                    if (userin == 4) { Console.WriteLine("Spock vaporizes rock! You win!"); pScore++; }
                    break;
                case 1:
                    if (userin == 0) { Console.WriteLine("Paper covers rock! You lost!"); eScore++; }
                    if (userin == 1) { Console.WriteLine("You both chose paper! Stalemate!"); }
                    if (userin == 2) { Console.WriteLine("Scissors cuts paper! You win!"); pScore++; }
                    if (userin == 3) { Console.WriteLine("Lizard eats paper! You win!"); pScore++; }
                    if (userin == 4) { Console.WriteLine("Paper disproves Spock! You lost!"); }
                    break;
                case 2:
                    if (userin == 2) { Console.WriteLine("You both chose scissors! Stalemate!"); }
                    break;
                case 3:
                    if (userin == 3) { Console.WriteLine("You both chose lizard! Stalemate!"); }
                    break;
                case 4:
                    if (userin == 4) { Console.WriteLine("You both chose Spock! Stalemate! \n RIP Leonard Nimoy"); }
                    break;
            }
            if (cpuChoice == 0 && userin == 3)
            {
                Console.WriteLine("Rock curshes lizard, you lose!");
            } else if (cpuChoice == 0 ) { }
        }
    }
}