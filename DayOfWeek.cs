//-----------------------------------------------------------------------
// <copyright file="DayOfWeek.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace AlgorithmProj
{
    using System;

    /// <summary>
    /// This class will return day of the week after 
    /// taking three parameters of year,month and date
    /// </summary>
    public class DayOfWeek
    {
        /// <summary>
        /// Prints the day of the week.
        /// </summary>
        public void PrintDay()
        {
            ////Array of week Days
            string[] week = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            ////taking user input
            Console.WriteLine("Enter year in (YYYY) Format:");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Month (1-12) Format:");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter date (0-31) Format:");
            int date = Convert.ToInt32(Console.ReadLine());
            ////Formula to calculate the day of the week 
            int y0 = (year - (14 - month)) / 12;
            int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
            int m0 = month + 12 * ((14 - month) / 12) - 2;
            int d0 = (date + x + 31 * m0 / 12) % 7;
            Console.WriteLine("Day of the week is: " + week[d0] + " ");
        }
    }
}
