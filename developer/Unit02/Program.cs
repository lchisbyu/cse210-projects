using System;

namespace Unit02
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hilo!");
            Console.WriteLine("Hello, What is your name? ");
            string name = Console.ReadLine();




            int points;
            points = 300;
            Console.WriteLine("You have " + points + "points");
            points = points - 75;
            Console.WriteLine("Your card was less than the other card");
            Console.WriteLine("You now have " + points);
            Console.WriteLine("Try again!");


            Random rnd = new Random();
            int currentCard = rnd.Next(1, 14);
            int nextCard = 0;


            string playAgain = "yes";




            while (points > 0 && playAgain == "yes")
            {
                points--;

                Console.WriteLine("Is the next card higher or lower? ");
                string userGuess = Console.ReadLine();

                Console.WriteLine("Do you want to play again?");
                playAgain = Console.ReadLine();

            }



            IF

            else
                Console.WriteLine("Thanks for playing Hilo, Goodbye");
        }
    }
}
