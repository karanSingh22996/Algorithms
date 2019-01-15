//-----------------------------------------------------------------------
// <copyright file="ReadFromInstSort.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace AlgorithmProj
{
    using System.IO;
    using System;

    /// <summary>
    /// This class will read the data from file 
    /// and sort them using insertion sort
    /// </summary>
    public class ReadFromInstSort
    {
        /// <summary>
        /// Reads the file.
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
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        st[i] = s;
                        i++;
                    }
                }
            }catch(Exception e)
            {
                System.Console.WriteLine(e.Message);
            }

            return st;
        }
    }
}
