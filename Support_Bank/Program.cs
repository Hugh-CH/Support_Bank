using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Transactions;


namespace Support_Bank
{
    class Program
    {
        static List<Transaction> ReadCsv(string filename)
        {
            List<Transaction> listOfTransactions = new List<Transaction>();

            StreamReader sr = new StreamReader(filename);
            string line;
            string[] row = new string [5];
            line = sr.ReadLine();
            while ((line = sr.ReadLine()) != null)
            {
                row = line.Split(',');
                listOfTransactions.Add(new Transaction(row));
            }

            return listOfTransactions;
        }

       
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<Transaction> testlist =  ReadCsv("C:/Work/Training/Support_Bank/Transactions2014.csv");
            
            
            
        }
    }
}