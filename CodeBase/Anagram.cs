using System;
using System.Collections.Generic;
using System.Text;

namespace CodeBase
{
    class Anagram
    {
        // Variables defined to capture true or false if a character match found
        bool[] IsfoundChar;
        private bool IsPvtAnagram = false;
        public bool IsAnagram(String Word1, String Word2)
        {
            //Converting to uppercase to make it case insensitive
            Word1 = Word1.ToUpper();
            Word2 = Word2.ToUpper();
            IsfoundChar = new bool[Word1.Length];
            //comparing the length to see if it is an anagram
            if (Word1.Length == Word2.Length)
            {
                //for each word of Word1
                for (int i = 0; i < Word1.Length; i++)
                {
                   // for each word of Word1 of Word2
                    for (int j = 0; j < Word2.Length; j++)
                    {
                     
                        if (Word1[i] == Word2[j])
                        {
                            IsfoundChar[i] = true;
                            break;
                        }
                        else
                        {
                            IsfoundChar[i] = false;
                           }
                    }

                    if (!IsfoundChar[i])
                        return false;
                }
                //checking the boolean array if it contains false
                for (int i = 0; i < Word1.Length; i++)
                {
                    if (!IsfoundChar[i])
                    {
                        IsPvtAnagram = false;
                    }
                    IsPvtAnagram = true;
                }

            }
            else
            {
                return false;
            }
            return IsPvtAnagram;
        }
        
    }
}
