using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpInterViewQuestion
{
    public static class CountingOccurrence
    {

        public static void Countcharacter(string str)
        {
            //Creating the disctionary to hold the character and the number.
            //  Dictionary<char, int> characterCount = new Dictionary<char, int>();


            Dictionary<char, int> characterList = new Dictionary<char, int>();

            foreach(var character in str)
            {
                if (character != ' ')
                {
                    if (!characterList.ContainsKey(character))
                    {
                        characterList.Add(character, 1);

                    }
                    else
                    {
                        characterList[character]++;

                        
                    }
                }
            }

             foreach(var character in characterList)
            {
                Console.WriteLine(character.Key + " -" + character.Value);
            }
            //Using foreach to loopthrough the dictionary 
            //foreach (var character in str)
            //{
            //    if (character != ' ')
            //    {
            //        if (!characterCount.ContainsKey(character))
            //        {
            //            characterCount.Add(character, 1);
            //        }
            //        else
            //        {
            //            characterCount[character]++;
            //        }
            //    }

            //}
            //foreach (var character in characterCount)
            //{
            //    Console.WriteLine("{0} - {1}", character.Key, character.Value);
            //}
        }
    }
}