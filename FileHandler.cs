using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Montoya
{
    static internal class FileHandler
    {
        private static string directoryString = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
        private static string quotesPath = directoryString + "\\Megadesk\\data\\quotes.json";
        //private static string validatorPath= directoryString + "\\Megadesk\\data\\";
        private static string pricesPath= directoryString + "\\Megadesk\\data\\rushOrderPrices.txt";

        public static void WriteQuoteToFile(DeskQuote quoteToWrite) 
        {
            string dataToWrite = JsonConvert.SerializeObject(quoteToWrite, Formatting.Indented);

            using (StreamWriter writer = File.AppendText(quotesPath))
            {
                writer.WriteLine(dataToWrite);
            }
        }
        public static int[,] GetRushOrderPrices()
        {
            int[,] returnArray = new int[3,3];
            using(StreamReader reader = new StreamReader(pricesPath))
            {
                for(int i = 0; i <= 2; i++)
                {
                    for(int j = 0; j <= 2; j++)
                    {
                        returnArray[i,j] = Convert.ToInt32(reader.ReadLine());
                    }
                }
                return returnArray;
            }
        }
        public static void GetQuotes() { }

        public static void GetValidationItems() { }

    }
}
