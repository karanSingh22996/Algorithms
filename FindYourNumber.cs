//-----------------------------------------------------------------------
// <copyright file="FindYourNumber.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace AlgorithmProj
{
    using System;

    /// <summary>
    /// This class will return that number which you have think in your mind
    /// only u need to told the number between 0 to n-1
    /// </summary>
    public class FindYourNumber
    {
        /// <summary>
        /// This method is using binary search to search for the number it will ask every time if your number is in range
        /// if in range you need to type true if not then false
        /// </summary>
        public void FindNumber()
        {
            try
            {
                ////Taking user input
                Console.WriteLine("enter the  the power of 2");
                int n = Utility.GetInt();
                ////finding power of that number using static function pow of math class
                int N = (int)Math.Pow(2, n);
                ////declaring and initializing array of 2 to th power n
                int[] array = new int[N];
                ////iterating loop from zero to 2 to the power n-1
                for (int i = 0; i <= N - 1; i++)
                {
                    array[i] = i;
                }

                /*for(int i=0 ; i<=N-1 ; i++)
                {
                 System.out.println(array[i]);
                }*/
                ////here console ask to guess number between o and 2 to the power n-1
                Console.WriteLine("guess the number between 0 and " + (N - 1));
                int firstIndex = 0;
                int lastIndex = N - 1;
                bool correct;
                bool highOrLow;
                ////iterating till first index is less than or equal to lastIndex
                while (firstIndex <= lastIndex)
                {
                    int middle = (firstIndex + lastIndex) / 2;

                    Console.WriteLine("you number is " + array[middle] + " if yes enter true,else false");

                    correct = Convert.ToBoolean(Console.ReadLine());
                    if (correct == true)
                    {
                        Console.WriteLine("your guessed number is " + array[middle]);
                        break;
                    }

                    Console.WriteLine("is your number is greater than " + array[middle] + " is yes enter true,else enter false");
                    highOrLow = Convert.ToBoolean(Console.ReadLine());
                    if (highOrLow)
                    {
                        firstIndex = middle + 1;
                    }
                    else
                    {
                        lastIndex = middle - 1;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
