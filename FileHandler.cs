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
        private static string pricesPath= directoryString + "\\Megadesk\\data\\rushOrderPrices.txt";
        
        public static void WriteQuoteToFile(DeskQuote quoteToWrite) 
        {
            var readQuotes = GetQuotes() ?? new List<DeskQuote>();

            readQuotes.Add(quoteToWrite);
            string quotesToWrite = JsonConvert.SerializeObject(readQuotes);

            using (StreamWriter writer = new StreamWriter(quotesPath, false))
            {
                writer.Write(quotesToWrite);
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
        public static List<DeskQuote> GetQuotes() 
        {
            string quotesJson = File.ReadAllText(quotesPath);
            List<DeskQuote> readQuotes = JsonConvert.DeserializeObject<List<DeskQuote>>(quotesJson);

            return readQuotes;
        }

        public static void GetValidationItems() { }

    }
}
