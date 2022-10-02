using System;

namespace RockPapperScissor
{
    public class Program
    {
        static void Main(string[] args)
        {
            Services services = new Services();
            string inputCPU;
            Random random = new Random();
            int cpuPoints = 0;
            int playerPoints = 0;
            int round = 1;
            int maxRounds = 5;
            bool roundsValid;

            while (true)
            {
                if (round == 1)
                {
                    Console.Write("Hello! How many rounds u want play? ");
                    roundsValid = Int32.TryParse(Console.ReadLine(), out maxRounds);
                    if (!roundsValid)
                    {
                        Console.WriteLine("Wrong Command");
                        continue;
                    }
                }

                int numCPU = random.Next(0, 3);
                Console.Write("Round: " + round + ". " + "Choose between ROCK, PAPPER, SCISSORS : ");
                string inputPlayer = Console.ReadLine();

                Console.WriteLine();
                switch (numCPU)
                {
                    case 0:
                        inputCPU = "rock";
                        services.InputCpuRock(inputCPU, ref cpuPoints, ref playerPoints, inputPlayer);
                        break;

                    case 1:
                        inputCPU = "scissors";
                        services.inputCpuScissors(inputCPU, ref cpuPoints, ref playerPoints, inputPlayer);
                        break;

                    case 2:
                        inputCPU = "papper";
                        services.inputCpuPapper(inputCPU, ref cpuPoints, ref playerPoints, inputPlayer);
                        break;
                };

                Console.WriteLine();
                round++;
                services.Scores(ref cpuPoints, ref playerPoints, ref round, maxRounds);
            }
        }
    }
}
