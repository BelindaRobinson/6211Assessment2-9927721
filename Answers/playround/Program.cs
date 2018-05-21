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

            int[] MData = new int[100];
            int[] MData2 = MData;
            

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

                    default:
                        Console.WriteLine("Sorry that choice is not a available");
                        menuchoice = "0";
                        break;
                }
            }
        }
        public static void ImportData(int[] MData)
        {
            StreamReader Moisture = new StreamReader("../../Moisture_Data.txt"); // reading the text file that iss added to solution ../../ changes levels

            string myString = Moisture.ReadToEnd();

            Moisture.Close();
            
            char rc = (char)10;
            String[] listLines = myString.Split(rc);
            List<List<int>> listArrays = new List<List<int>>();
            for (int i = 0; i < listLines.Length; i++)
            {
                List<int> array = new List<int>();
                String[] listInts = listLines[i].Split(' ');
                for (int j = 0; j < listInts.Length; j++)
                {
                    if (listInts[j] != "\r")
                    {
                        array.Add(Moisture);
                    }
                }
                listArrays.Add(array);

                for (int a = 0; a < 100; a++)
                {
                    Console.WriteLine(array[]);
                }
                Console.ReadLine();


                /*for (int i = 0; i < 100; i++) // adding each of the 100 lines to the array
                {
                    MData[i] = Moisture.ReadLine();
                }
                Moisture.Close();*/
            }
        }
        public static void FindMaximum(int[] MData)
        {
            ImportData(MData);

            /*for (int i = 0; i < MData.Length; i++)
            {
                if (MData[i] == value)
                {
                    return true;
                }
                    
            } */
                
            
        }

        public static void PrintArray(int[] MData)
        {
            ImportData(MData);

            Console.WriteLine("Moisture Data file added to array");

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(MData[i]);
            }
            Console.ReadLine();

        }
    }
}
