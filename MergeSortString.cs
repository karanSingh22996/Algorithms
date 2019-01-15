//-----------------------------------------------------------------------
// <copyright file="MergeSortString.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace AlgorithmProj
{
    using System;
    /// <summary>
    /// This class will sort the data using merge sort divide and conquer rule
    /// </summary>
    public class MergeSortString
    {
        /// <summary>
        /// Array declared to store numbers
        /// </summary>
        String[] array;
        String[] tempMergeArray;
        int length;

        /// <summary>
        /// This method is declared and defined to 
        /// initialized instance array and variable
        /// </summary>
        public void Sort(String[] inputArr)
        {
            try
            {
                ////initialising instance array and variable
                this.array = inputArr;
                this.length = inputArr.Length;
                this.tempMergeArray = new String[this.length];
                ////calling method recursively to sort all the data
                this.DivideArray(0, this.length - 1);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        /// <summary>
        /// this method will divide the array in parts
        /// </summary>
        /// <param name="lowerIndex"></param>
        /// <param name="higherIndex"></param>
        public void DivideArray(int lowerIndex, int higherIndex)
        {
            try
            {
                if (lowerIndex < higherIndex)
                {
                    ////finding middle element by adding lower 
                    ///and highest and dividing by 2
                    int middle = lowerIndex + (higherIndex - lowerIndex) / 2;
                    ////calling method recursively 
                    ////first will divide till lower to middle
                    this.DivideArray(lowerIndex, middle);
                    ////this recusive method will divide from middle+1 to higherIndex
                    this.DivideArray(middle + 1, higherIndex);
                    ////this recursive method will 
                    MergeArray(lowerIndex, middle, higherIndex);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="lowerIndex"></param>
        /// <param name="middle"></param>
        /// <param name="higherIndex"></param>
        public void MergeArray(int lowerIndex, int middle, int higherIndex)
        {
            try
            {
                for (int m = lowerIndex; m <= higherIndex; m++)
                {
                    this.tempMergeArray[m] = this.array[m];
                }
                int i = lowerIndex;
                int j = middle + 1;
                int k = lowerIndex;
                while (i <= middle && j <= higherIndex)
                {
                    if (string.Compare(tempMergeArray[i], tempMergeArray[j]) <= 0)
                    {
                        this.array[k] = tempMergeArray[i];
                        i++;
                    }
                    else
                    {
                        this.array[k] = tempMergeArray[j];
                        j++;
                    }
                    k++;

                }
                while (i <= middle)
                {
                    this.array[k] = tempMergeArray[i];
                    k++;
                    i++;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

}

