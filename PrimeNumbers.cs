//-----------------------------------------------------------------------
// <copyright file="PrimeNumbers.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace AlgorithmProj
{
    using System;

    /// <summary>
    /// This class will check if the given numbers are prime or not
    /// </summary>
    public class PrimeNumbers
    {
        /// <summary>
        /// Determines whether the specified n is prime.
        /// </summary>
        /// <param name="n">The n.</param>
        /// <returns>
        ///   <c>true</c> if the specified n is prime; otherwise, <c>false</c>.
        /// </returns>
        public bool IsPrime(int n)
        {
#pragma warning disable CS0162 // Unreachable code detected
            for (int i = 2; i <= n / 2; i++)
#pragma warning restore CS0162 // Unreachable code detected
            {
                if (n % i == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

            return true;
        }
    }
}
