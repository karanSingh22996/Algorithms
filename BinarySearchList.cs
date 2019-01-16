//-----------------------------------------------------------------------
// <copyright file="BinarySearchList.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace AlgorithmProj
{
    using System;
    using System.IO;

    /// <summary>
    /// this class will read the data from file 
    /// </summary>
    public class BinarySearchList
    {
        /// <summary>
        /// Reads the file.
        /// and search for the given data
        /// if present returns its position
        /// </summary>
        /// <returns>return string array</returns>
        public string[] ReadFile()
        {
            string[] st = new string[10];
            try
            {
                string path = @"C:\Users\admin\Desktop\karan.txt";
                using (StreamReader sr = File.OpenText(path))
                {
                    int i = 0;
                    string s;
                    while ((s = sr.ReadLine()) != null)
                    {
                        st[i] = s;
                        i++;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return st;
        }
    }
}
