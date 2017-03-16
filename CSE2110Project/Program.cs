using System;

namespace CSE2110Project
{
    class Program
    {
        //what the user says
        private static String input;
        //int version of the user input
        private static int choice;
        //the random int that the cpu chooses
        private static int cpuChoice;
        //the player score
        private static int pScore = 0;
        //the enemy score
        private static int eScore = 0;
        //counter to print the write
        private static int counter = 1;
        //string form of cpu choice
        private static String outChoice;
        //Main, need I say any more?
        public static void Main(string[] args)
        {
            //game loop
            while (true)
            {
                //print the write thing
                if (counter == 1)
                {
                    Console.WriteLine("Rock, paper, scissors, lizard, or Spock?!");
                }
                //ensure that scores are not both 0
                if (eScore > 0 || pScore > 0)
                {
                    Console.WriteLine("Player score: " + pScore + "\t Enemy score: " + eScore);
                }
                //print this if ran more than once
                if (counter == 2)
                {
                    Console.WriteLine("Pick again!");
                }
                //get user input
                input = Console.ReadLine().ToLower();
                //get enemy and comparisons
                Logic(PlayerParser(input));
                //prep for consecutive runs
                counter = 2;
            }
        }
        //pares userin into string format
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
        //get random cpu input and compare
        private static void Logic(int userin)
        {
            //show user output
            Console.WriteLine("You chose: " + input);
            //initialize random
            Random rand = new Random();
            cpuChoice = rand.Next(0,5);
            //get the cpu string and print
            switch (cpuChoice)
            {
                case 0:
                    outChoice = "Rock";
                    break;
                case 1:
                    outChoice = "Paper";
                    break;
                case 2:
                    outChoice = "Scissors";
                    break;
                case 3:
                    outChoice = "Lizard";
                    break;
                case 4:
                    outChoice = "Spock";
                    break;
            }
            Console.WriteLine("The CPU chose: " + outChoice);
            //do the comparisons
            switch (cpuChoice)
            {
                //Rock
                case 0:
                    if (userin == 0) { Console.WriteLine("You both chose rock! Stalemate!"); }
                    if (userin == 1) { Console.WriteLine("Paper covers rock! You win!"); pScore++; }
                    if (userin == 2) { Console.WriteLine("Rock crushes scissors! You lost!"); eScore++; }
                    if (userin == 3) { Console.WriteLine("Rock crushes lizard! You lost!"); eScore++; }
                    if (userin == 4) { Console.WriteLine("Spock vaporizes rock! You win!"); pScore++; }
                    break;
                //Paper
                case 1:
                    if (userin == 0) { Console.WriteLine("Paper covers rock! You lost!"); eScore++; }
                    if (userin == 1) { Console.WriteLine("You both chose paper! Stalemate!"); }
                    if (userin == 2) { Console.WriteLine("Scissors cuts paper! You win!"); pScore++; }
                    if (userin == 3) { Console.WriteLine("Lizard eats paper! You win!"); pScore++; }
                    if (userin == 4) { Console.WriteLine("Paper disproves Spock! You lost!"); eScore++; }
                    break;
                //Scissors
                case 2:
                    if (userin == 0) { Console.WriteLine("Rock crushes scissors! You win!"); pScore++; }
                    if (userin == 1) { Console.WriteLine("Scissors cuts paper! You lost!"); eScore++; }
                    if (userin == 2) { Console.WriteLine("You both chose scissors! Stalemate!"); }
                    if (userin == 3) { Console.WriteLine("Scissors decapitates lizard! You lost!"); eScore++; }
                    if (userin == 4) { Console.WriteLine("Spock smashes scissors! You win!"); pScore++; }
                    break;
                //Lizard
                case 3:
                    if (userin == 0) { Console.WriteLine("Rock crushes lizard! You win!"); pScore++; }
                    if (userin == 1) { Console.WriteLine("Lizard eats paper! You lost!"); eScore++; }
                    if (userin == 2) { Console.WriteLine("Scissors decapitates lizard! You win!"); pScore++; }
                    if (userin == 3) { Console.WriteLine("You both chose lizard! Stalemate!"); }
                    if (userin == 4) { Console.WriteLine("Lizard poisons Spock! You lost!"); eScore++; }
                    break;
                //Spock
                case 4:
                    if (userin == 0) { Console.WriteLine("Spock vaporizes rock! You lost!"); eScore++; }
                    if (userin == 1) { Console.WriteLine("Paper disproves Spock! You win!"); pScore++; }
                    if (userin == 2) { Console.WriteLine("Spock smashes scissors! You lost!"); eScore++; }
                    if (userin == 3) { Console.WriteLine("Lizard poisons Spock! You win!"); pScore++;  }
                    if (userin == 4) { Console.WriteLine("You both chose Spock! Stalemate! \n RIP Leonard Nimoy"); }
                    break;
            }
        }
    }
}