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
        static void Main(int[] args)
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

                    default:
                        Console.WriteLine("Sorry that choice is not a available");
                        menuchoice = "0";
                        break;
                }
            }
        }
        public static void ImportData(string[] MData)
        {
            StreamReader Moisture = new StreamReader("../../Moisture_Data.txt");

            for (int i = 0; i < 100; i++)
            {
                MData[i] = Moisture.ReadLine();
            }

            Moisture.Close();

            
        }
        public static void FindMaximum(string[] MData)
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

        public static void PrintArray(string[] MData)
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
