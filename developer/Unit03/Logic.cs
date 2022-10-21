using System;
using System.Collections.Generic;


namespace Unit03
{

    class Logic

    {
        private List<string> userguess = new List<string>();

        static bool compareUserGuessWord(string letter, string word)
        {
            return word.IndexOf(letter) != -1;


        }

    }
}

// compare user guess to word