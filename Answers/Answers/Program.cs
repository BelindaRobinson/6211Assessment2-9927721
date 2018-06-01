﻿using System;
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

            int[] MData = new int[100]; // decimal 


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

        private static void ImprovedBubbleSort(int[] mData) // here to make menu work with other bubble class
        {
            throw new NotImplementedException();
        }

        private static void BubbleSort(int[] mData)
        {
            throw new NotImplementedException();
        }

        public static void ImportData(int[] MData)
        {
            try
            {
                using (StreamReader Moisture = new StreamReader("../../Moisture_Data.txt")) // week8 at the bottom and change into main method, dont use streamreader
                {
                    string Data = Moisture.ReadToEnd();
                    Console.WriteLine(Data);
                }
            }

            catch (Exception e)
            {
                Console.WriteLine("cant read file");
                Console.WriteLine(e.Message);
            }

            string[] input = File.ReadLines(@"c:\Data.txt").ToArray(); //class week8 file reader 
            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(input[i] + " ");
            }
            Console.WriteLine();
        }

        public static void FindMaximum(int[] MData)
        {
            ImportData(MData); // Holds all the data to find values

            Console.WriteLine("enter a anything to find the highest number"); // finds the max number no matter what you type in 
            string N = Console.ReadLine();

            Console.WriteLine(MData.Max());


            int Max = MData[0]; // string not int

            for (int i = 0; i < MData.Length; i++) // this within another loop 
            {
                if (MData[i] > Max)
                {
                    Max = MData[i];
                }
                int index =Array.FindIndex(MData, Max);
                MData[index] = 0;
            }

        }

        public static void PrintArray(int[] MData) // MData in main being pulled though each method
        {
            ImportData(MData); // calling premade method

            Console.WriteLine("Original Array");

            for (int i = 0; i < 100; i++)
            {
                Console.Write(MData[i]); // displaying the original array for the datafile
            }
            Console.ReadLine();
        }

        public static void SelectionSort(int[] MData)
        {
            int d, a;

            PrintArray(MData);

            Console.WriteLine("Selection Sorted List");

            for (int i = 0; i < MData.Length - 1; i++)
            {
                a = i;

                for (int b = i + 1; b < MData.Length; b++)
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

            Array.Sort(MData);
            Array.Reverse(MData);
            Console.WriteLine(MData);
            Console.WriteLine("Maximum value");
            Console.WriteLine(MData.Max());
            Console.WriteLine("Minimum value");
            Console.WriteLine(MData.Min());
            Console.WriteLine("Average value");
            Console.WriteLine(MData.Average());

        }

        public static void LinearSearch(int[] MData)
        {

        }

        public static void CompareArrays(int[] MData)
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