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

            decimal[] MData = new decimal[100]; // decimal 

            decimal DData = MData[100];

            string[] input = File.ReadLines("../../Moisture_Data.txt").ToArray(); //class week8 file reader 
            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(input[i] + " ");
                string Dinput = input[i];

                if (Decimal.TryParse(Dinput, out DData))
                {
                    Console.WriteLine(MData);
                }
            }
            Console.WriteLine();

            
            string menuchoice = "0";

            while (menuchoice == "0")
            {
                Console.WriteLine("Please select a topic"); //change cases to each question instead
                Console.WriteLine("1. Question1");
                Console.WriteLine("2. Question2");
                Console.WriteLine("3. Question3");
                Console.WriteLine("4. Question4");        

                menuchoice = Console.ReadLine();

                switch (menuchoice)
                {

                    case "1":
                        FindMaximum(MData);
                        PrintArray(MData);
                        menuchoice = "0";
                        break;

                    case "2":
                        SelectionSort(MData);
                        menuchoice = "0";
                        break;

                    case "3":
                        LinearSearch(MData);
                        CompareArrays(MData);
                        menuchoice = "0";
                        break;

                    case "4":
                        BubbleSort(MData);
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

        private static void ImprovedBubbleSort(decimal[] mData) // here to make menu work with other bubble class
        {
            throw new NotImplementedException();
        }

        private static void BubbleSort(decimal[] mData)
        {
            throw new NotImplementedException();
        }

        public static void ImportData(decimal[] MData)
        {
            /*
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
            */
            decimal DData;

            string[] input = File.ReadLines("../../Moisture_Data.txt").ToArray(); //class week8 file reader 
            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(input[i] + " ");
                string Dinput = input[i];
                if (Decimal.TryParse(Dinput, out DData))
                {
                    Console.WriteLine(DData);
                }
            }
            Console.WriteLine();

        }

        public static void FindMaximum(decimal[] MData)
        {
            ImportData(MData); // Holds all the data to find values

            Console.WriteLine("enter a anything to find the highest number"); // finds the max number no matter what you type in 
            string N = Console.ReadLine();

            Console.WriteLine(MData.Max());


            string Max = MData[i];  // string not int

            for (int i = 0; i < MData.Length; i++)
            {               
                for (int a = -1; a < MData.Length; a++) // this within another loop 
                {
                    if (decimal.TryParse(Max, out MData) > Max)
                    {
                        Max = MData[a];
                    }
                    int index = Array.FindIndex(MData, Max);
                    MData[index] = 0;
                }
            }
        }

        public static void PrintArray(decimal[] MData) // MData in main being pulled though each method
        {
            ImportData(MData); // calling premade method

            Console.WriteLine("Original Array");

            for (int i = 0; i < 100; i++)
            {
                Console.Write(MData[i]); // displaying the original array for the datafile
            }
            Console.ReadLine();
        }

        public static void SelectionSort(decimal[] MData)
        {
            int d = 0;
            int a = 0;

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
            
            Console.WriteLine("Maximum value is {0}", MData[99]);
            
            Console.WriteLine("Minimum value is {0}", MData[0]);

            Average = 0;
            Total = 0;

            for (int b = 0; b < MData.Length; b++)
            {
                Total = MData[b]
            }
            // need to find total then / to get average

            Console.WriteLine("Average value");
            

        }

        public static void LinearSearch(decimal[] MData, DData[100])
        {
            for (int i = 0; i < MData.Length; i++)
            {
                if (MData[i] == Data)
                    return true;
                return false;
            }
            
        }

        public static void CompareArrays(decimal[] MData)
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