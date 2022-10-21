using System;

namespace Unit03
{

    class Director

    {

        string[] words = { "people", "book", "time", "library", "checkout" };
        int a = 4;
        Console.WriteLine(words[a]);
            Random rnd = new Random();

            for (int i = 0; i< 10; i++)
            {
                int wordIndex = rnd.Next(0, 5);
        Console.WriteLine(words[wordIndex]);
                Console.WriteLine("Do you want to continue?");
                Console.ReadLine();
            }

}
}

