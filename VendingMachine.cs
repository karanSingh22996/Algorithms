//-----------------------------------------------------------------------
// <copyright file="VendingMachine.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace AlgorithmProj
{
    using System;

    /// <summary>
    /// This class will return the change of notes
    /// </summary>
    public class VendingMachine
    {
        /// <summary>
        /// Vending the results.
        /// </summary>
        public void VendingResults()
        {
            int[] notes = { 1000, 500, 100, 50, 20, 10, 5, 2, 1 };
            Console.WriteLine("Enter your amount:");
            int amount = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < notes.GetLength(0); i++)
            {
                if (amount / notes[i] > 0)
                {
                    Console.WriteLine("Note of " + notes[i] + " is " + (amount / notes[i]));
                    count = (count + amount) / notes[i];
                    amount = amount % notes[i];
                }
            }

            Console.WriteLine("Minimum number of notes = " + count);
        }
    }
}
