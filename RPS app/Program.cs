using System;

namespace RPS_app
{
    class Program
    {
        static void Main(string[] args)
        {
            string player, opponent, answer;
            int randomNumber, roundNumber;
            bool playAgain = true;

            while (playAgain)
            {

                int playerScore = 0;
                int opponentScore = 0;
                Console.WriteLine("How many rounds do you want to play?");
                if (int.TryParse(Console.ReadLine(), out roundNumber))
                {
                    if (roundNumber > 0)
                    {
                        for (int n = 0; n < roundNumber; n++)
                        {

                            do
                            {
                                Console.Write("Chose between ROCK, PAPER or SCISSORS:   ");
                                player = Console.ReadLine();
                                player = player.ToUpper();
                                if (player != "ROCK" && player != "PAPER" && player != "SCISSORS")
                                {
                                    Console.WriteLine("\nWrong input! Please try again\n\n");
                                }
                            } while (player != "ROCK" && player != "PAPER" && player != "SCISSORS");

                            Random random = new Random();

                            randomNumber = random.Next(1, 4);

                            if (randomNumber == 1)
                            {
                                opponent = "ROCK";
                                Console.WriteLine("\nOpponent chose ROCK");
                                if (player == "ROCK")
                                {
                                    Console.WriteLine("\nDRAW!\n\n");
                                }
                                else if (player == "PAPER")
                                {
                                    Console.WriteLine("\nPLAYER WINS!\n\n");
                                    playerScore++;
                                }
                                else if (player == "SCISSORS")
                                {
                                    Console.WriteLine("\nOPPONENT WINS!\n\n");
                                    opponentScore++;
                                }
                            }
                            else if (randomNumber == 2)
                            {
                                opponent = "PAPER";
                                Console.WriteLine("\nOpponent chose PAPER");
                                if (player == "PAPER")
                                {
                                    Console.WriteLine("\nDRAW!\n\n");
                                }
                                else if (player == "ROCK")
                                {
                                    Console.WriteLine("\nOPPONENT WINS!\n\n");
                                    opponentScore++;
                                }
                                else if (player == "SCISSORS")
                                {
                                    Console.WriteLine("\nPLAYER WINS!\n\n");
                                    playerScore++;
                                }
                            }
                            else if (randomNumber == 3)
                            {
                                opponent = "SCISSORS";
                                Console.WriteLine("\nOpponent chose SCISSORS");
                                if (player == "SCISSORS")
                                {
                                    Console.WriteLine("\nDRAW!\n\n");
                                }
                                else if (player == "PAPER")
                                {
                                    Console.WriteLine("\nOPPONENT WINS!\n\n");
                                    opponentScore++;
                                }
                                else if (player == "ROCK")
                                {
                                    Console.WriteLine("\nPLAYER WINS!\n\n");
                                    playerScore++;
                                }
                            }
                            else
                            {
                                Console.WriteLine("I dont understand that command.");
                            }

                            Console.WriteLine("\nScore \tPlayer: \t{0} \tOpponent: \t{1} \n\n", playerScore, opponentScore);

                        }
                    }
                    else
                    {
                        Console.WriteLine("You must enter a valind number of rounds.\n");
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("Please input valid number.\n");
                    continue;
                }

                if (playerScore > opponentScore)
                {
                    Console.WriteLine("PLAYER WINS THE GAME!\n");
                }
                else if (playerScore == opponentScore)
                {
                    Console.WriteLine("IT'S A DRAW!\n");
                }
                else
                {
                    Console.WriteLine("OPPONENT WINS THE GAME!\n");
                }

                do
                {
                    Console.WriteLine("Do you want to play tha game again? (y/n)");
                    answer = Console.ReadLine();
                    answer = answer.ToLower();
                    if (answer == "y")
                    {
                        playAgain = true;
                        Console.Clear();
                    }
                    else if (answer == "n")
                    {
                        playAgain = false;
                    }
                    else
                    {

                        Console.WriteLine("Wrong input! Please try again.\n");
                    }

                } while (answer != "y" && answer != "n");
            }
        }
    }
}
