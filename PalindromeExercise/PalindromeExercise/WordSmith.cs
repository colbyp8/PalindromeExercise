using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string word)
        {
            //var wordReversed = new string(word.ToLower().Reverse().ToArray());
            //return word.ToLower() == wordReversed ? true : false;
            return word.ToLower().SequenceEqual(word.ToLower().Reverse());

        }
    }

}
