using System;

namespace MoreOrLessGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize Game
            Console.WriteLine("New More or less Game !!!");
            Console.WriteLine("Try to discover THE SECRET NUMBER by entering a number between 0 and 100 include !");

            // set Secret Number
            Random random = new Random();
            int secretNumber = random.Next(100);

            Console.WriteLine("Secret number chosen! You can play ! {0}", secretNumber);

            int playerNumber;
            // Game loop
            do
            {
                string playerEntry = Console.ReadLine();

                if (!int.TryParse(playerEntry, out playerNumber))
                {
                    Console.WriteLine("The secret number is a NUMBER! ");
                }
                else
                {
                    if (playerNumber == secretNumber)
                    {
                        break;
                    }
                    else if (playerNumber < 0 || playerNumber >= 100)
                    {
                        Console.WriteLine("The Secret number is between 0 and 100 included.");
                    } 
                    else if (secretNumber > playerNumber)
                    {
                        Console.WriteLine("TRY AGAIN, the secret number is bigger.");
                    }
                    else
                    {
                        Console.WriteLine("TRY AGAIN, the secret number is smaller.");
                    }
                }
            } while (playerNumber != secretNumber);

            Console.WriteLine("YOU WON!!! You can... Code again!");
        }

        public static void RunGame()
        {
        }
    }
}
