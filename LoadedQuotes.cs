using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Montoya
{
    internal static class LoadedQuotes
    {
        public static List<DeskQuote> Quotes = preaareQuotesList();
        private static List<DeskQuote> preaareQuotesList()
        {
            List<DeskQuote> quotes = new List<DeskQuote>();
            quotes.AddRange(FileHandler.GetQuotes());
            return quotes;
        }
    }
}
