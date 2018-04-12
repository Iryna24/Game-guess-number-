using System;
using Game.Players;

namespace Game
{
    public class HowToPlay
    {
        public int minValue = 0;
        public int maxValue = 0;
        public int guessNumber = 0;

        int numberOfPlayer_1 = 0;
        int numberOfPlayer_2 = 0;
        int numberOfPlayer_3 = 0;
        int numberOfPlayer_4 = 0;
        int numberOfPlayer_5 = 0;

        int round = 1;
        int index = 0;
        bool winnerExist = false;

        public HowToPlay (int min, int max, int guessNum)
        {
            minValue = min;
            maxValue = max;
            guessNumber = guessNum;
        }

        HardWorkingPlayer player_1 = new HardWorkingPlayer();
        SimplePlayer player_2 = new SimplePlayer();
        SimpleSmartPlayer player_3 = new SimpleSmartPlayer();
        HardWorkingCheater player_4 = new HardWorkingCheater();
        SimpleCheater player_5 = new SimpleCheater();

        public void Play()
        {
            int startValue = minValue;

            int[] ArrayForSimpleSmart = new int[maxValue - minValue];
            int[] ArrayAllNamedNumbers = new int[maxValue - minValue];

            for (int i = minValue; i < maxValue; i++)
            {

                player_1.Move(startValue, maxValue, ref numberOfPlayer_1);

                player_2.Move(minValue, maxValue, ref numberOfPlayer_2);

                player_3.Move(minValue, maxValue, ref numberOfPlayer_3);

                while (true)
                {
                    for (int j = 0; j < ArrayForSimpleSmart.Length; j++)
                    {
                        if (ArrayForSimpleSmart[j] == numberOfPlayer_3)
                        {
                            player_3.Move(minValue, maxValue, ref numberOfPlayer_3);
                        }
                    }
                    break;
                }

                ArrayAllNamedNumbers[index] = numberOfPlayer_1;
                ArrayAllNamedNumbers[index + 1] = numberOfPlayer_2;
                ArrayAllNamedNumbers[index + 2] = numberOfPlayer_3;

                player_4.Move(minValue, maxValue, ref numberOfPlayer_4);

                while (true)
                {
                    for (int j = 0; j < ArrayAllNamedNumbers.Length; j++)
                    {

                        if (ArrayAllNamedNumbers[j] == numberOfPlayer_4)
                        {
                            player_4.Move(minValue, maxValue, ref numberOfPlayer_4);
                        }
                    }
                    break;
                }

                ArrayAllNamedNumbers[index + 3] = numberOfPlayer_4;

                player_5.Move(minValue, maxValue, ref numberOfPlayer_5);

                while (true)
                {
                    for (int k = 0; k < ArrayAllNamedNumbers.Length; k++)
                    {
                        if (ArrayAllNamedNumbers[k] == numberOfPlayer_5)
                        {
                            player_5.Move(minValue, maxValue, ref numberOfPlayer_5);
                        }
                    }
                    break;
                }

                ArrayAllNamedNumbers[index + 4] = numberOfPlayer_5;

                Console.WriteLine("Results of " + round + " round: ");
                Console.WriteLine("Hard-working player named " + numberOfPlayer_1);
                Console.WriteLine("Simple player named " + numberOfPlayer_2);
                Console.WriteLine("Simple smart player named " + numberOfPlayer_3);
                Console.WriteLine("Hard-working cheater named " + numberOfPlayer_4);
                Console.WriteLine("Simple cheater named " + numberOfPlayer_5);
                Console.WriteLine();

                if (numberOfPlayer_1 == guessNumber)
                {
                    Console.WriteLine("Hard-working player is winner!");
                    winnerExist = true;
                }

                if (numberOfPlayer_2 == guessNumber)
                {
                    Console.WriteLine("Simple player is winner!");
                    winnerExist = true;
                }

                if (numberOfPlayer_3 == guessNumber)
                {
                    Console.WriteLine("Simple smart player is winner!");
                    winnerExist = true;
                }

                if (numberOfPlayer_4 == guessNumber)
                {
                    Console.WriteLine("Hard-working cheater is winner!");
                    winnerExist = true;
                }

                if (numberOfPlayer_5 == guessNumber)
                {
                    Console.WriteLine("Simple cheater is winner!");
                    winnerExist = true;
                }

                if (winnerExist)
                    break;

                ArrayForSimpleSmart[round - 1] = numberOfPlayer_3;
                index = index + 5;
                round += 1;
            }        
        }
    }
}
