//-----------------------------------------------------------------------
// <copyright file="PrimeToPalindromeAndAnagram.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace AlgorithmProj
{
    using System;

    /// <summary>
    /// This class will check first the prime and then 
    /// in that prime it will check palindrome and anagram
    /// </summary>
    public class PrimeToPalindromeAndAnagram
    {
        /// <summary>
        /// Prints the primes.
        /// </summary>
        /// <param name="n">The number.</param>
        /// <returns>return integer array</returns>
        public int[] PrintPrimes(int n)
        {
            int[] primeList = new int[n];
            try
            {
                for (int i = 0; i < primeList.GetLength(0); i++)
                {
                    if (Utility.IsPrime(i))
                    {
                        primeList[i] = i;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return primeList;
        }

        /// <summary>
        /// Determines whether the specified n is palindrome.
        /// </summary>
        /// <param name="n">The number.</param>
        /// <returns>
        ///   <c>true</c> if the specified n is palindrome; otherwise, <c>false</c>.
        /// </returns>
        public bool IsPalindrome(int n)
        {
            int sum = 0, t = n;
            try
            {
                do
                {
                    int rev = n % 10;
                    sum = (sum * 10) + rev;
                    n = n / 10;
                }
                while (n != 0);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return sum == t;
        }

        /// <summary>
        /// Palindromes the list.
        /// </summary>
        /// <param name="n">The number.</param>
        /// <returns>return array of integers</returns>
        public int[] PalindromeList(int[] n)
        {
            int[] palindromeList = new int[n.GetLength(0)];
            try
            {
                for (int i = 0; i < palindromeList.GetLength(0); i++)
                {
                    if (this.IsPalindrome(i))
                    {
                        palindromeList[i] = i;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return palindromeList;
        }
    }
}
