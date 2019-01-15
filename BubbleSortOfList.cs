//-----------------------------------------------------------------------
// <copyright file="BubbleSortOfList.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace AlgorithmProj
{
    using System;
    using System.IO;

    /// <summary>
    /// This class will Read data from file and using bubble
    /// sort it will sort the data in ascending order
    /// </summary>
    public class BubbleSortOfList
    {
        /// <summary>
        /// The list for storing the data inside the file
        /// </summary>
        int[] list = new int[11];

        /// <summary>
        /// Reads the file.
        /// </summary>
        /// <returns>return array of integer</returns>
        public int[] ReadFile()
        {
           
                ////Path of the file
                string path = @"C:\Users\admin\Desktop\number.txt";
            ////stringReader is a class it open the text files and reads the data
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    string s;
                    int j = 0;
                    ////loop will iterate till file reach to null data
                    while ((s = sr.ReadLine()) != null)
                    {
                        try
                        {
                            int i = int.Parse(s);
                            this.list[j] = i;
                            j++;
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                    }
                }

                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return this.list;
        }
    }
}
