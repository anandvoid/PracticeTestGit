using System;
using System.Collections.Generic;
using System.Text;

namespace CodeBase
{
    
    class PigLatin
    {
        //defining string variables to hold trialing, remaining, return strings
        private string AccWord="";
        private string DecWord = "";
        private string PigLatinStatement="";

        //Splits each word in a string and pass it to the PigLatin ConvertWord Function
        public string Convert(string Statement)
        {
            //Splitting the string based on space delimiter
            string[] Words = Statement.Split(" ");

            //loop for each word in the string
            foreach(string word in Words)
            {
                DecWord = "";
                AccWord = "";
                PigLatinStatement=PigLatinStatement+ConvertWord(word)+" ";
            }
            return PigLatinStatement;
        }

        //Converts a given word to PigLatin
        private string ConvertWord(string Word)
        {
            //Vowel flag to return true if a vowel is found
            bool FoundVowel = false;
            
            for (int i = 0; i < Word.Length; i++)
            {
                if ((char.ToLower(Word[i])) == 'a' ||
                    (char.ToLower(Word[i])) == 'e' ||
                    (char.ToLower(Word[i])) == 'i' ||
                    (char.ToLower(Word[i])) == 'o' ||
                    (char.ToLower(Word[i])) == 'u')
                {
                   FoundVowel = true;
                   //remaing words added to the Dec Word variable upon finding a vowel character
                   DecWord = Word.Substring(Word.Length-i);
                }
                else
                if(!FoundVowel)
                {
                    //trialing characters gets added to AccWord till a Vowel is found.
                   AccWord = AccWord.Trim() + Word[i];
                    
                                  }
                                   
            }
            return DecWord+AccWord+"AY";
        }

    }
}
