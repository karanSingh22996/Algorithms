//-----------------------------------------------------------------------
// <copyright file="Utility.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace AlgorithmProj
{
    using System;
    using System.Diagnostics;

    /// <summary>
    /// This class is created to make record 
    /// of all the frequent used functions
    /// </summary>
    public class Utility
    {
        /// <summary>
        /// Gets the integer.
        /// </summary>
        /// <returns>integer return type</returns>
        public static int GetInt()
        {
            int i = 0;
            try
            {
                i = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return i;
        }

        /// <summary>
        /// Gets the double.
        /// </summary>
        /// <returns>return double</returns>
        public static double GetDouble()
        {
            double i = 0.0;
            try
            {
                i = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return i;
        }

        /// <summary>
        /// Gets the string.
        /// </summary>
        /// <returns>return string</returns>
        public static string GetString()
        {
            string i = null;
            try
            {
                i = Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return i;
        }

        /// <summary>
        /// Determines whether the specified n is prime.
        /// </summary>
        /// <param name="n">The n.</param>
        /// <returns>
        ///   <c>true</c> if the specified n is prime; otherwise,<c>false</c>.
        /// </returns>
        public static bool IsPrime(int n)
        {
            try
            {
                for (int i = 2; i <= n / 2; i++)
                {
                    if (n % i == 0)
                    {
                        return false;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return true;
        }

        /// <summary>
        /// Reverses the of number.
        /// </summary>
        /// <param name="n">The n.</param>
        /// <returns>return integer</returns>
        public static int ReverseOfNum(int n)
        {
            int rNum = 0;
            try
            {
                do
                {
                    int rev = n % 10;
                    rNum = (rNum * 10) + rev;
                    n = n / 10;
                }
                while (n != 0);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return rNum;
        }

        /// <summary>
        /// Counts the number.
        /// </summary>
        /// <param name="num">The number.</param>
        /// <returns>return digit count</returns>
        public static int CountNum(int num)
        {
            int count = 0;
            try
            {
                do
                {
                    count++;
                    num = num / 10;
                }
                while (num != 0);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return count;
        }

        /// <summary>
        /// Binaries the search.
        /// </summary>
        /// <param name="arr">The array.</param>
        /// <param name="item">The item.</param>
        public static void BinarySearch(int[] arr, int item)
        {
            try
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                Array.Sort(arr);
                int low = 0;
                int high = arr.GetLength(0) - 1;
                int middle = (low + high) / 2;
                while (low <= high)
                {
                    if (arr[middle] == item)
                    {
                        Console.WriteLine(item + " is found at " + middle + " Position");
                        break;
                    }
                    else if (item > arr[middle])
                    {
                        low = middle + 1;
                    }
                    else
                    {
                        high = middle - 1;
                    }

                    middle = (low + high) / 2;
                }

                if (low > high)
                {
                    Console.WriteLine(item + " Not find in the list");
                }

                stopwatch.Stop();
                Console.WriteLine("Elapsed Time: " + stopwatch.Elapsed);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Binaries the search string.
        /// </summary>
        /// <param name="str">The string.</param>
        /// <param name="item">The item.</param>
        public static void BinarySearchStr(string[] str, string item)
        {
            try
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                Array.Sort(str);
                int low = 0;
                int high = str.GetLength(0) - 1;
                int middle = (low + high) / 2;
                while (low <= high)
                {
                    if (str[middle].CompareTo(item) == 0)
                    {
                        Console.WriteLine(item + " Found at " + middle + " Position ");
                        break;
                    }
                    else if (str[middle].CompareTo(item) < 0)
                    {
                        low = middle + 1;
                    }
                    else
                    {
                        high = middle + 1;
                    }

                    middle = (low + high) / 2;
                }

                if (low > high)
                {
                    Console.WriteLine(item + " is not in list of array");
                }

                stopwatch.Stop();
                Console.WriteLine("ElapsedTime = " + stopwatch.Elapsed);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Insertions the sort integer.
        /// </summary>
        /// <param name="arr">The array.</param>
        public static void InsertionSortInt(int[] arr)
        {
            try
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                int temp, j;
                for (int i = 1; i < arr.GetLength(0); i++)
                {
                    temp = arr[i];
                    j = i;
                    while (j > 0 && arr[j - 1] > temp)
                    {
                        arr[j] = arr[j - 1];
                        j = j - 1;
                    }

                    arr[j] = temp;
                }

                Console.WriteLine("Sorted Arrays are:");
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    Console.Write(arr[i] + " ");
                }

                Console.WriteLine();
                stopwatch.Stop();
                Console.WriteLine("ElapsedTime = " + stopwatch.Elapsed);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Insertions the sort string.
        /// </summary>
        /// <param name="str">The string.</param>
        public static void InsertionSortStr(string[] str)
        {
            try
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                string temp;
                int j;
                for (int i = 1; i < str.GetLength(0); i++)
                {
                    temp = str[i];
                    j = i;
                    while (j > 0 && string.Compare(str[j - 1], temp, true) > 0)
                    {
                        str[j] = str[j - 1];
                        j = j - 1;
                    }

                    str[j] = temp;
                }

                Console.WriteLine("Sorted Strings are:");
                for (int k = 0; k < str.GetLength(0); k++)
                {
                    Console.Write(str[k] + " ");
                }

                Console.WriteLine();
                stopwatch.Stop();
                Console.WriteLine("ElapsedTime = " + stopwatch.Elapsed);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Bubbles the sort integer.
        /// </summary>
        /// <param name="arr">The array.</param>
        public static void BubbleSortInt(int[] arr)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < arr.GetLength(0) - 1; i++)
            {
                for (int j = 1; j < arr.GetLength(0) - i; j++)
                {
                    if (arr[j - 1] > arr[j])
                    {
                        int temp = arr[j - 1];
                        arr[j - 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            Console.WriteLine("Sorted Array is:");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine();
            stopwatch.Stop();
            Console.WriteLine("ElapsedTime = " + stopwatch.Elapsed);
        }

        /// <summary>
        /// Bubbles the sort string.
        /// </summary>
        /// <param name="str">The string.</param>
        public static void BubbleSortStr(string[] str)
        {
            try
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                for (int i = 0; i < str.GetLength(0) - 1; i++)
                {
                    for (int j = 1; j < str.GetLength(0) - i; j++)
                    {
                        if (string.Compare(str[j - 1], str[j], true) > 0)
                        {
                            string temp = str[j - 1];
                            str[j - 1] = str[j];
                            str[j] = temp;
                        }
                    }
                }

                Console.WriteLine("Sorted strings are:");
                for (int i = 0; i < str.GetLength(0); i++)
                {
                    Console.Write(str[i] + " ");
                }

                Console.WriteLine();
                stopwatch.Stop();
                Console.WriteLine("ElapsedTime = " + stopwatch.Elapsed);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}