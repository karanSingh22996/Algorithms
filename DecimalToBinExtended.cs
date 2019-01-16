//-----------------------------------------------------------------------
// <copyright file="DecimalToBinExtended.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace AlgorithmProj
{
    using System;

    /// <summary>
    /// This class will convert bin to dec and 
    /// again after swap it will give decimal form 
    /// </summary>
    public class DecimalToBinExtended
    {
        /// <summary>
        /// Decimals to bin.
        /// </summary>
        /// <param name="n">The n.</param>
        /// <returns>string return type</returns>
        public string DecToBin(int n)
        {
            string bin = "";
            try
            {
                do
                {
                    int rev = n % 2;
                    bin = rev + bin;
                    n = n / 2;
                }
                while (n != 0);  
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return bin;
        }

        /// <summary>
        /// Swaps the function.
        /// </summary>
        /// <param name="st">string</param>
        /// <returns>return integer values</returns>
        public int SwapFunct(string st)
        {
            int bin = 0;
            try
            {
                string st1 = st.Substring(0, 4);
                string st2 = st.Substring(4);
                string concat = st2 + st1;
                bin = int.Parse(concat);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return bin;
        }

        /// <summary>
        /// Bins to decimal.
        /// </summary>
        /// <param name="n">The n.</param>
        /// <returns>return decimal value of binary</returns>
        public int BinToDec(int n)
        {
            int dec = 0;
            try
            {
                int count = 0;
                do
                {
                    int r = n % 10;
                    dec = dec + (r * this.Pow(2, count));
                    n = n / 10;
                    count++;
                }
                while (n != 0);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return dec;
        }

        /// <summary>
        /// Power the specified n.
        /// </summary>
        /// <param name="n">The n.</param>
        /// <param name="p">The p.</param>
        /// <returns>return integer number power</returns>
        public int Pow(int n, int p)
        {
            int power = 1;
            try
            {
                while (p > 0)
                {
                    power = power * n;
                    p--;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return power;
        }      
    }
}
