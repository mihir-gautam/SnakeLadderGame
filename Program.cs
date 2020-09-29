using System;

namespace SnakeLadderProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            const int NO_PLAY = 0;
            const int LADDER = 1;
            const int SNAKE = 2;
            const int START = 0;

            Console.WriteLine("Welcome to snake and ladder program");
            
            Console.WriteLine("Game Started, Player 1 is at : 0");
            Console.WriteLine("Game Started, Player 2 is at : 0");
            int ScoreP1 = playerScore();
            int ScoreP2 = playerScore();

            if(ScoreP2 > ScoreP1)
            {
                Console.WriteLine("Player 1 won!");
            }
            else
            {
                Console.WriteLine("Player 2 won!");
            }
            static int playerScore()
            {
                int currentScore = 0;
                int rollCount = 0;
                while (currentScore != 100)
                {
                    int newScoreP1 = 0;
                    for (rollCount = 0; newScoreP1 < 100; rollCount++)
                    {
                        int dieNumber = DieRoll();
                        Console.WriteLine("Number on the Die : " + dieNumber);
                        newScoreP1 = nextMove(dieNumber, newScoreP1);
                        Console.WriteLine("New Score : " + newScoreP1 + " after " + rollCount + " rolls of Die");
                        if (newScoreP1 == 100)
                        {
                            Console.WriteLine("Victory");
                        }
                        else if (newScoreP1 > 100)
                        {
                            newScoreP1 = currentScore;
                            Console.WriteLine("Roll the die again");
                        }
                    }
                    return currentScore;
                }
                return rollCount;
            }

            static int DieRoll()
            {
                Random random = new Random();
                int dieNum = random.Next(1, 7);
                return dieNum;
            }

            static int nextMove(int DieNumber, int ScoreP1)
            {
                Random random = new Random();
                int options = random.Next(0, 3);
                switch (options)
                {
                    case NO_PLAY:
                        Console.WriteLine("No Play");
                        break;
                    case SNAKE:
                        Console.WriteLine("Snake");
                        if (ScoreP1 - DieNumber >= 0)
                        {
                            ScoreP1 -= DieNumber;
                            break;
                        }
                        else
                        {
                            ScoreP1 = START;
                            break;
                        }
                    case LADDER:
                        Console.WriteLine("Ladder chosen");
                        ScoreP1 += DieNumber;
                        break;
                }
                return ScoreP1;
                }
            }
        }
    }


