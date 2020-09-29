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
            const int END = 100;

            Console.WriteLine("Welcome to snake and ladder program");
            int ScoreP1 = 0;
            Console.WriteLine("Game Started, Player 1 is at :" + ScoreP1);
            int dieNumber = DieRoll();
            Console.WriteLine("Number on the Die : " + dieNumber);
            ScoreP1 = nextMove(dieNumber, ScoreP1);
            Console.WriteLine("New Score : " + ScoreP1);

            static int DieRoll()
            {
                Random random = new Random();
                int dieNum = random.Next(1, 7);
                return dieNum;
            }
        
            Console.WriteLine("Player score after rolling the die : " + ScoreP1);

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
                        ScoreP1 -= DieNumber;
                        break;
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


