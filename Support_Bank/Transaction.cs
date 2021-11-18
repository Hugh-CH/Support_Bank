using System;
using NLog;

namespace Support_Bank
{
    public class Transaction
    {
        private static readonly ILogger logger = LogManager.GetCurrentClassLogger();
        
        public string date;
        public string from;
        public string to;
        public string narrative;
        public float amount;

        public Transaction(string[] csvRow)
        {
            this.date = csvRow[0];
            this.from = csvRow[1];
            this.to = csvRow[2];
            this.narrative = csvRow[3];
            this.amount = float.Parse(csvRow[4]);
        }
        
        public void PrintTransaction()
        {
            Console.WriteLine("Date        From     To       Narrative           Amount");
            Console.WriteLine(date + "  " + from + "    " + to + "  " + narrative +"    "+ amount.ToString());
        }
    }
}