//-----------------------------------------------------------------------
// <copyright file="Sqrt.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace AlgorithmProj
{
    using System;

    /// <summary>
    /// This class will return the square root of the number
    /// </summary>
    public class Sqrt
    {
        /// <summary>
        /// calculate the SQRTs .
        /// </summary>
        public void SqrtCal()
        {
            try
            {
                Console.WriteLine("Enter a non negative number");
                double c = Utility.GetDouble();
                double t = c;
                t = ((c / t) + t) / 2;
                double epsilon = 1e-15;
                while (Math.Abs((t - c) / t) > epsilon * t)
                {
                    t = ((c / t) + t) / 2.0;
                }

                Console.WriteLine("Sqrt " + t);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
