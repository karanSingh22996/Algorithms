//-----------------------------------------------------------------------
// <copyright file="DecimalToBinary.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace AlgorithmProj
{
    using System;

    /// <summary>
    /// This class will simply convert the given decimal number into binary
    /// </summary>
    public class DecimalToBinary
    {
        /// <summary>
        /// Decimals to binary.
        /// </summary>
        /// <param name="n">integer number</param>
        /// <returns>string return type</returns>
        public string DecToBin(int n)
        {
            string bin = "";
            do
            {
                /// rev declared
                int rev = n % 2;
                bin = rev + bin;
                n = n / 2;
            }
            while (n != 0);
            return bin;
        }
    }
}
