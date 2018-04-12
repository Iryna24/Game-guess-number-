using System;

namespace Game
{
    public static class StartGame
    {
        public static void Start()
        {
            int minValue;
            int maxValue;
            int guessNumber;
            
                do
                { 
                bool start = true;

                Console.WriteLine("Please, enter min value: ");
                string text = Console.ReadLine();
                bool res = Int32.TryParse(text, out minValue);

                Console.WriteLine("Please, enter max value: ");
                string text1 = Console.ReadLine();
                bool res1 = Int32.TryParse(text1, out maxValue);

                Console.WriteLine("Please, enter guess number from " + minValue + " to " + maxValue);
                string text2 = Console.ReadLine();
                bool res2 = Int32.TryParse(text2, out guessNumber);

                if (guessNumber > maxValue || guessNumber < minValue)
                {
                    Console.WriteLine("Error: Please, enter guess number from " + minValue + " to " + maxValue);
                    Console.WriteLine();
                    start = false;
                }

                if (start)
                {
                    HowToPlay play = new HowToPlay(minValue, maxValue, guessNumber);
                    play.Play();
                }

            } while (guessNumber < minValue || guessNumber > maxValue);
        }
    }
}
