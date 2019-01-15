//-----------------------------------------------------------------------
// <copyright file="Anagram.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace AlgorithmProj
{
    using System;

    /// <summary>
    /// Anagram class will check either two
    /// strings are anagram or not.
    /// </summary>
    public class Anagram
    {
        /// <summary>
        /// Determines whether this instance is anagram.
        /// </summary>
        public void IsAnagram()
        {
            ////Taking two string type input from user.
            Console.WriteLine("Enter first String:");
            string str1 = Console.ReadLine();

            Console.WriteLine("Enter second String:");
            string str2 = Console.ReadLine();
            ////converting string into char array and in lower case
            char[] ch1 = str1.ToLower().ToCharArray();
            char[] ch2 = str2.ToLower().ToCharArray();
            ////sorting array of characters 
            Array.Sort(ch1);
            Array.Sort(ch2);
            ////converting again char array into string
            string newStr1 = new string(ch1);
            string newStr2 = new string(ch2);
            ////checking either all the character of the string matches with one another or not
            if (newStr1 == newStr2)
            {
                Console.WriteLine("Given strings are anagram");
            }
            else
            {
                Console.WriteLine("Given strings are NOT anagrams");
            }
        }
    }
}
