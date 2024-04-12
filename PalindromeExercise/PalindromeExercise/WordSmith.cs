using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith

    {
        public bool IsAPalindrome(string word)
        {
            char[] reverse = word.ToCharArray();
            Array.Reverse(reverse);
            string x = new string(reverse);

            if (word == x)
            {  return true; }
            else { return false; }
        }
    }
}
