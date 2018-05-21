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
                Console.WriteLine("1. Print Queue");
                Console.WriteLine("2. Enqueue");
                Console.WriteLine("3. Dequeue");
                Console.WriteLine("4. Contains");
                Console.WriteLine("5. To Array");

                menuchoice = Console.ReadLine();

                switch (menuchoice)
                {

                    case "1":
                        PrintArray(MData);
                        menuchoice = "0";
                        break;

                    case "2":
                        ImportData(MData);
                        menuchoice = "0";
                        break;

                    case "3":
                        FindMaximum(MData);
                        menuchoice = "0";
                        break;

                    default:
                        Console.WriteLine("Sorry that choice is not a available");
                        menuchoice = "0";
                        break;
                }
            }
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

            /*string Max = MData[0]; // having string and int issues 

            for (int i = 0; i < MData.Length; i++)
            {
                if (MData[i] > Max)
                {
                    Max = MData[i];                    
                }                
            }*/
        }

        public static void PrintArray(string[] MData) // MData in main being pulled though each method
        {
            ImportData(MData); 

            Console.WriteLine("Original Array");

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(MData[i]); // displaying the original array for the datafile
            }
            Console.ReadLine();
        }

        public static void SelectionSort(string[] MData)
        {
            int SD, A;
                       
            PrintArray(MData);

            Console.WriteLine("Selection Sorted List");
            for (int i = 0; i < MData.Length - 1; i++)
            {
                A = i;
                for (int j = i + 1; j < MData.Length; j++)
                {
                    if (MData[j] < MData[A])
                    {
                        A = j;
                    }
                }
                
                if (A != 1)
                {
                    SD = MData[i];
                    MData[i] = MData[A];
                    MData[A] = SD;
                }
                Console.WriteLine(MData[i]);
            }

        }
    }
}
