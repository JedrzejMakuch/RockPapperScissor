using System;

namespace RockPapperScissor
{
    public class Services
    {
        public void inputCpuPapper(string inputCPU, ref int cpuPoints, ref int playerPoints, string inputPlayer)
        {
            Console.WriteLine("Computer chose: " + inputCPU);
            if (inputPlayer.ToLower() == "scissors")
            {
                Console.WriteLine("You won!");
                playerPoints++;
            }
            else if (inputPlayer.ToLower() == "papper")
            {
                Console.WriteLine("No one win!");
            }
            else if (inputPlayer.ToLower() == "rock")
            {
                Console.WriteLine("Computer Won!");
                cpuPoints++;
            }
            else
            {
                Console.WriteLine("Wrong Command! Point for computer!");
                cpuPoints++;
            }
        }

        public void inputCpuScissors(string inputCPU, ref int cpuPoints, ref int playerPoints, string inputPlayer)
        {
            Console.WriteLine("Computer chose: " + inputCPU);
            if (inputPlayer.ToLower() == "rock")
            {
                Console.WriteLine("You won!");
                playerPoints++;
            }
            else if (inputPlayer.ToLower() == "scissors")
            {
                Console.WriteLine("No one win!");
            }
            else if (inputPlayer.ToLower() == "papper")
            {
                Console.WriteLine("Computer Won!");
                cpuPoints++;
            }
            else
            {
                Console.WriteLine("Wrong Command! Point for computer!");
                cpuPoints++;
            }
        }

        public void InputCpuRock(string inputCPU, ref int cpuPoints, ref int playerPoints, string inputPlayer)
        {
            Console.WriteLine("Computer chose: " + inputCPU);
            if (inputPlayer.ToLower() == "rock")
            {
                Console.WriteLine("No one win!");
            }
            else if (inputPlayer.ToLower() == "scissors")
            {
                Console.WriteLine("Computer Won!");
                cpuPoints++;
            }
            else if (inputPlayer.ToLower() == "papper")
            {
                Console.WriteLine("You Won!");
                playerPoints++;
            }
            else
            {
                Console.WriteLine("Wrong Command! Point for computer!");
                cpuPoints++;
            }
        }

        public void Scores(ref int cpuPoints, ref int playerPoints, ref int round, int maxRounds)
        {
            if (round > maxRounds)
            {
                if (playerPoints > cpuPoints)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Your points: " + playerPoints + ", Computer points: " + cpuPoints);
                    Console.WriteLine("YOU WON THE GAME!!");
                }
                else if (playerPoints < cpuPoints)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Your points: " + playerPoints + ", Computer points: " + cpuPoints);
                    Console.WriteLine("YOU LOSE THE GAME!!");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Your points: " + playerPoints + ", Computer points: " + cpuPoints);
                    Console.WriteLine("DRAW!!");
                }

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Do you wanna play again? <y/n>");

                PlayAgain(ref cpuPoints, ref playerPoints, ref round);
            }
        }

        public void PlayAgain(ref int cpuPoints, ref int playerPoints, ref int round)
        {
            var consoleKey = Console.ReadKey(true);
            if (consoleKey.Key == ConsoleKey.N)
            {
                Environment.Exit(0);
            } 
            else if(consoleKey.Key == ConsoleKey.Y)
            {
                Console.Clear();
                round = 1;
                playerPoints = 0;
                cpuPoints = 0;

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}
