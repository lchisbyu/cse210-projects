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



            Random rnd = new Random();
            int currentCard = rnd.Next(1, 14);
            int nextCard = 0;


            string playAgain = "yes";




            while (points > 0 && playAgain == "yes")
            {
                points--;

                if (nextCard == 0)
                {
                    null;

                }

                else
                {

                    currentCard = nextCard;
                }



                Console.WriteLine("The card is " + currentCard);



                Console.WriteLine("Is the next card higher or lower? ");
                string userGuess = Console.ReadLine();

                nextCard = rnd.Next(1, 14);

                if (nextCard == currentCard) { }

                else if (nextCard < currentCard) { }

                else { }


                Console.WriteLine("You have " + points + "points");

                points = points - 75;
                Console.WriteLine("Your card was less than the other card");
                Console.WriteLine("You now have " + points);
                Console.WriteLine("Try again!");


                Console.WriteLine("Do you want to play again?");
                playAgain = Console.ReadLine();


            }


            Console.WriteLine("Thanks for playing Hilo, Goodbye");
        }
    }
}
