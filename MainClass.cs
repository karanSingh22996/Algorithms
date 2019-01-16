//-----------------------------------------------------------------------
// <copyright file="MainClass.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace AlgorithmProj
{
    using System;

    /// <summary>
    /// This class is created to execute all the programs at one compilation
    /// </summary>
    public class MainClass
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments is or string array.</param>
        public static void Main(string[] args)
        {
            try
            {
                string st = null;
                do
                {
                    Console.WriteLine("Enter 1. For Anagram Programs");
                    Console.WriteLine("Enter 2. For Prime Numbers Programs");
                    Console.WriteLine("Enter 3. For PrimeToPalindromeAndAnagram Numbers Programs");
                    Console.WriteLine("Enter 4. For Day of week  Programs");
                    Console.WriteLine("Enter 5. For Vending Machine  Programs");
                    Console.WriteLine("Enter 6. For Binary Search for Integer Programs");
                    Console.WriteLine("Enter 7. For Binary Search for String Programs");
                    Console.WriteLine("Enter 8. For Insertion sort for Integers Programs");
                    Console.WriteLine("Enter 9. For Insertion sort for Strings Programs");
                    Console.WriteLine("Enter 10. For Bubble sort of Integers Programs");
                    Console.WriteLine("Enter 11. For Bubble sort of Strings Programs");
                    Console.WriteLine("Enter 12. For TemperatureConversion Programs");
                    Console.WriteLine("Enter 13. For Monthly Payment Programs");
                    Console.WriteLine("Enter 14. For sqrt Programs");
                    Console.WriteLine("Enter 15. For Decimal To Binary Programs");
                    Console.WriteLine("Enter 16. For Decimal To Binary Extended Programs");
                    Console.WriteLine("Enter 17. For Binary Search from File Programs");
                    Console.WriteLine("Enter 18. For Sorting the file data Using Insertion sort Programs");
                    Console.WriteLine("Enter 19. For Sorting the list data Using Bubble sort Programs");
                    Console.WriteLine("Enter 20. For Sorting the string using merge sort Programs");
                    Console.WriteLine("Enter 21. For Find Number using binary search Programs");
                    int n = Convert.ToInt32(Console.ReadLine());
                    switch (n)
                    {
                        case 1:
                            Anagram anagram = new Anagram();
                            anagram.IsAnagram();
                            break;
                        case 2:
                            PrimeNumbers primeNumbers = new PrimeNumbers();
                            Console.WriteLine("Enter your range:");
                            int num = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Prime Numbers are:");
                            for (int i = 2; i <= num; i++)
                            {
                                if (primeNumbers.IsPrime(i))
                                {
                                    Console.WriteLine(i + " ");
                                }
                            }

                            break;
                        case 3:
                            PrimeToPalindromeAndAnagram ppa = new PrimeToPalindromeAndAnagram();
                            Console.Write("Enter the range of numbers:");
                            int range = Convert.ToInt32(Console.ReadLine());
                            int[] primes = ppa.PrintPrimes(range);
                            Console.WriteLine("Total primes numbers in " + range);
                            for (int i = 2; i < primes.GetLength(0); i++)
                            {
                                if (primes[i] != 0)
                                {
                                    Console.Write(primes[i] + " ");
                                }
                            }

                            Console.WriteLine();
                            int[] palindromes = ppa.PalindromeList(primes);
                            Console.WriteLine("Palindromes in prime List are:");
                            for (int i = 0; i < palindromes.GetLength(0); i++)
                            {
                                if (Utility.IsPrime(i) && palindromes[i] != 0)
                                {
                                    Console.Write(palindromes[i] + " ");
                                }
                            }

                            Console.WriteLine();
                            break;
                        case 4:
                            DayOfWeek dow = new DayOfWeek();
                            dow.PrintDay();
                            break;
                        case 5:
                            VendingMachine vm = new VendingMachine();
                            vm.VendingResults();
                            break;
                        case 6:
                            Console.WriteLine("Enter the size of Array:");
                            int size = Utility.GetInt();
                            int[] arr = new int[size];
                            Console.WriteLine("Enter " + size + " Elemenets");
                            for (int i = 0; i < arr.GetLength(0); i++)
                            {
                                arr[i] = Utility.GetInt();
                            }

                            Console.WriteLine("Enter an item to search:");
                            int item = Utility.GetInt();

                            Utility.BinarySearch(arr, item);
                            break;
                        case 7:
                            Console.WriteLine("Enter the size of Array:");
                            int sizeStr = Utility.GetInt();
                            string[] str = new string[sizeStr];
                            Console.WriteLine("Enter " + sizeStr + " Elemenets");
                            for (int i = 0; i < str.GetLength(0); i++)
                            {
                                str[i] = Utility.GetString();
                            }

                            Console.WriteLine("Enter an item to search:");
                            string itemStr = Utility.GetString();
                            Utility.BinarySearchStr(str, itemStr);
                            break;
                        case 8:
                            Console.WriteLine("Enter the size of Array:");
                            int sizeIns = Utility.GetInt();
                            int[] arrIns = new int[sizeIns];
                            Console.WriteLine("Enter " + sizeIns + " Elemenets");
                            for (int i = 0; i < arrIns.GetLength(0); i++)
                            {
                                arrIns[i] = Utility.GetInt();
                            }

                            Utility.InsertionSortInt(arrIns);
                            break;
                        case 9:
                            Console.WriteLine("Enter the size of Array:");
                            int strsize = Utility.GetInt();
                            string[] strIns = new string[strsize];
                            Console.WriteLine("Enter " + strsize + " Elemenets");
                            for (int i = 0; i < strIns.GetLength(0); i++)
                            {
                                strIns[i] = Utility.GetString();
                            }

                            Utility.InsertionSortStr(strIns);
                            break;
                        case 10:
                            Console.WriteLine("Enter the size of Array:");
                            int sizeBubInt = Utility.GetInt();
                            int[] arrBubInt = new int[sizeBubInt];
                            Console.WriteLine("Enter " + sizeBubInt + " Elemenets");
                            for (int i = 0; i < arrBubInt.GetLength(0); i++)
                            {
                                arrBubInt[i] = Utility.GetInt();
                            }

                            Utility.BubbleSortInt(arrBubInt);
                            break;
                        case 11:
                            Console.WriteLine("Enter the size of Array:");
                            int strsizeBub = Utility.GetInt();
                            string[] strBub = new string[strsizeBub];
                            Console.WriteLine("Enter " + strsizeBub + " Elemenets");
                            for (int i = 0; i < strBub.GetLength(0); i++)
                            {
                                strBub[i] = Utility.GetString();
                            }

                            Utility.BubbleSortStr(strBub);
                            break;
                        case 12:
                            TemperatureConversion tc = new TemperatureConversion();
                            tc.FahrenToCel();
                            break;
                        case 13:
                            MonthlyPayment mp = new MonthlyPayment();
                            mp.LoanCalCulator();
                            break;
                        case 14:
                            Sqrt sqrt = new Sqrt();
                            sqrt.SqrtCal();
                            break;
                        case 15:
                            DecimalToBinary dtb = new DecimalToBinary();
                            Console.WriteLine("Enter the number to get binary conversion");
                            int bin = Utility.GetInt();
                            string binary = dtb.DecToBin(bin);
                            Console.WriteLine("Binary num of " + bin + " is " + binary);
                            break;
                        case 16:
                            DecimalToBinExtended decimalToBinExtended = new DecimalToBinExtended();
                            Console.WriteLine("Enter the number to get binary conversion");
                            int bin1 = Utility.GetInt();
                            string st1 = decimalToBinExtended.DecToBin(bin1);
                            Console.WriteLine("Decimal To Binary Conversion is: " + st1);
                            int swap1 = decimalToBinExtended.SwapFunct(st1);
                            Console.WriteLine("After swaping Binary To decimal: " + swap1);
                            int btd = decimalToBinExtended.BinToDec(swap1);
                            Console.WriteLine("Binary to decimal Conversion of the number " + bin1 + " is " + btd);
                            break;
                        case 17:
                            BinarySearchList bsl = new BinarySearchList();
                            string[] bslf = bsl.ReadFile();
                            Array.Sort(bslf);
                            Console.WriteLine("File Contains Following words ");
                            for (int i = 0; i < bslf.Length; i++)
                            {
                                Console.WriteLine(bslf[i] + " ");
                            }

                            Console.WriteLine("Enter the item to search form file");
                            string search = Console.ReadLine();
                            Utility.BinarySearchStr(bslf, search);
                            break;
                        case 18:
                            ReadFromInstSort instSort = new ReadFromInstSort();
                            string[] inssort = instSort.ReadFile();
                            Utility.InsertionSortStr(inssort);
                            break;
                        case 19:
                            BubbleSortOfList bubbleSortOfList = new BubbleSortOfList();
                            int[] r = bubbleSortOfList.ReadFile();
                            Utility.BubbleSortInt(r);
                            break;
                        case 20:
                            MergeSortString mergeSortString = new MergeSortString();
                            Console.WriteLine("Enter size of array:");
                            int mst = Utility.GetInt();
                            string[] mss = new string[mst];
                            Console.WriteLine("Enter " + mst + " elements");
                            for (int i = 0; i < mss.Length; i++)
                            {
                                mss[i] = Utility.GetString();
                            }

                            Console.WriteLine("Sorted Arrays:");
                            mergeSortString.Sort(mss);
                            foreach (string line in mss)
                            {
                                Console.WriteLine(line + " ");
                            }

                            break;
                        case 21:
                            FindYourNumber fyn = new FindYourNumber();
                            fyn.FindNumber();
                            break;
                        default:
                            Console.WriteLine("Out of reach:");
                            break;
                    }

                    Console.WriteLine("Do you want to execute another program press(y/n)");
                    st = Console.ReadLine();
                }
                while (st != "n");
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
