using System;

namespace SnakeLadderProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to snake and ladder program");
            int ScoreP1 = 0;
            Console.WriteLine("Game Started, Player 1 is at :" + ScoreP1);
            
            static int DieRoll()
            {
                Random random = new Random();
                int dieNum = random.Next(1, 7);
                return dieNum;
            }
            ScoreP1 = DieRoll();
            Console.WriteLine("Player score after rolling the die : " + ScoreP1);
        }
    }
}
