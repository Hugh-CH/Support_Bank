using System;

namespace Support_Bank
{
    public class Transaction
    {
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