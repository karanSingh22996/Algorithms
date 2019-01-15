//-----------------------------------------------------------------------
// <copyright file="MonthlyPayment.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace AlgorithmProj
{
    using System;

    /// <summary>
    /// this will calculate the loan amount 
    /// </summary>
    public class MonthlyPayment
    {
        /// <summary>
        /// calculate the Loans amount.
        /// </summary>
        public void LoanCalCulator()
        {
            try
            {
                ////Taking user input for year month and date
                Console.WriteLine("Enter principal Amount:");
                double p = Utility.GetDouble();
                Console.WriteLine("Enter rate %:");
                double R = Utility.GetDouble();
                Console.WriteLine("Enter time in year:");
                double y = Utility.GetDouble();
                ////Formula to calculate the loan amount
                double n = 12 * y;
                double r = R / (12 * 100);
                double payment = (p * r) / Math.Pow(1 - (1 + r), -n);
                Console.WriteLine("Loan Amount Per Month = " + payment);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
