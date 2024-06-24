using System;

namespace RockPaperScissors
{

    class Program
    {
        static void Main()
        {
            bool playerWantsToPlayAgain = true;
            while (playerWantsToPlayAgain) {
                
                string[] picks = { "Rock", "Paper", "Scissors" };
                Random random = new Random();
                string computerPick = picks[random.Next(0, picks.Length)];
                Console.WriteLine($"Please pick your choice {picks[0]},{picks[1]},{picks[2]}");

                string playerPick = Console.ReadLine();
                while (playerPick != picks[0] && playerPick != picks[1] && playerPick != picks[2] )
                {
                    Console.WriteLine($"{playerPick} is not a valid pick , please pick : {picks[0]},{picks[1]},{picks[2]}");
                    playerPick = Console.ReadLine();
                }

                Console.WriteLine($"Your pick is : {playerPick} , Computer pick is : {computerPick}");
                if (playerPick == computerPick)
                {
                    Console.WriteLine("This is draw");
                }
                else
                {
                    bool winConditionOne = playerPick == picks[0] && computerPick == picks[2];
                    bool winConditionTwo = playerPick == picks[1] && computerPick == picks[0];
                    bool winConditionThree = playerPick == picks[2] && computerPick == picks[1];

                    if (winConditionOne || winConditionTwo || winConditionThree)
                    {
                        Console.WriteLine("You Win");
                    }
                    else
                    {
                        Console.WriteLine("You Lose");
                    }

                }
                Console.WriteLine("Do you want to play again? [y/n]");
                string playerInput = Console.ReadLine();
                while (playerInput != "y" && playerInput != "n")
                {
                    Console.WriteLine("Please pick \"y\" or \"n\" ");
                    playerInput = Console.ReadLine();
                }

                if (playerInput == "n")
                {
                    playerWantsToPlayAgain = false;
                }
            }

            Console.WriteLine("Thanks for playing the game");
        }
    }

}
