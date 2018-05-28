using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Answers
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] MData = new string[100];


            string menuchoice = "0";

            while (menuchoice == "0")
            {
                Console.WriteLine("Please select a topic");
                Console.WriteLine("1. Import Data");
                Console.WriteLine("2. Find Maximum");
                Console.WriteLine("3. Print Array");
                Console.WriteLine("4. Selection Sort");
                Console.WriteLine("5. Linear Search");
                Console.WriteLine("6. Compare Arrays");
                Console.WriteLine("7. Bubble Sort");
                Console.WriteLine("8. Improved Bubble Sort");

                menuchoice = Console.ReadLine();

                switch (menuchoice)
                {

                    case "1":
                        ImportData(MData);
                        menuchoice = "0";
                        break;

                    case "2":
                        FindMaximum(MData);
                        menuchoice = "0";
                        break;

                    case "3":
                        PrintArray(MData);
                        menuchoice = "0";
                        break;

                    case "4":
                        SelectionSort(MData);
                        menuchoice = "0";
                        break;

                    case "5":
                        LinearSearch(MData);
                        menuchoice = "0";
                        break;

                    case "6":
                        CompareArrays(MData);
                        menuchoice = "0";
                        break;

                    case "7":
                        BubbleSort(MData);
                        menuchoice = "0";
                        break;

                    case "8":
                        ImprovedBubbleSort(MData);
                        menuchoice = "0";
                        break;

                    default:
                        Console.WriteLine("Sorry that choice is not a available");
                        menuchoice = "0";
                        break;
                }
            }
        }

        private static void ImprovedBubbleSort(string[] mData)
        {
            throw new NotImplementedException();
        }

        private static void BubbleSort(string[] mData)
        {
            throw new NotImplementedException();
        }

        public static void ImportData(string[] MData)
        {
            StreamReader Moisture = new StreamReader("../../Moisture_Data.txt"); // reading the text file that iss added to solution ../../ changes levels

            for (int i = 0; i < 100; i++) // adding each of the 100 lines to the array
            {
                MData[i] = Moisture.ReadLine();
            }
            Moisture.Close();
        }

        public static void FindMaximum(string[] MData)
        {
            ImportData(MData); // Holds all the data to find values

            Console.WriteLine("enter a anything to find the highest number"); // finds the max number no matter what you type in 
            string N = Console.ReadLine();

            Console.WriteLine(MData.Max());

            /*
            string Max = MData[0]; // having string and int issues, commenting out so programe runs

            for (int i = 0; i < MData.Length; i++)
            {
                if (MData[i] > Max)
                {
                    Max = MData[i];                    
                }                
            }
            */
        }

        public static void PrintArray(string[] MData) // MData in main being pulled though each method
        {
            ImportData(MData); // calling premade method

            Console.WriteLine("Original Array");

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(MData[i]); // displaying the original array for the datafile
            }
            Console.ReadLine();
        }

        public static void SelectionSort(string[] MData)
        {
            //int d, a, m; // see issues below

            Console.WriteLine("Original Array List");
            PrintArray(MData);

            Console.WriteLine("Selection Sorted List");
            /*
            for (int i = 0; i < MData.Length - 1; i++) // string to string issues, commenting out so program runs
            {
                a = i;
                
                for(int b = i + 1; b < MData.Length; b++)
                {
                    if (MData[b] < MData[a])
                    {
                        a = b;
                    }
                }

                if (a != 1)
                {
                    d = MData[i];
                    MData[i] = MData[a];
                    MData[a] = d;
                }            
            }
            */
            Array.Sort(MData);
            Array.Reverse(MData);
            Console.WriteLine(MData);
            Console.WriteLine("Maximum value");
            Console.WriteLine(MData.Max());
            Console.WriteLine("Minimum value");
            Console.WriteLine(MData.Min());
            //Console.WriteLine(MData.Average()); // string and int issue, really need to work on this

        }

        public static void LinearSearch(string[] MData)
        {

        }

        public static void CompareArrays(string[] MData)
        {

        }
    }

    class BubbleSortTiming
    {
        public static void BubbleSort()
        {

        }

        public static void ImprovedBubbleSort()
        {

        }
    }
}
