using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Transactions;


namespace Support_Bank
{
    class Program
    {
      
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // List<Transaction> testlist =  ReadCsv("C:/Work/Training/Support_Bank/Transactions2014.csv");
            AnnualAccount Account2014 = new AnnualAccount();
            Account2014.GenerateTransactionList("C:/Work/Training/Support_Bank/Transactions2014.csv");
            Account2014.GeneratePeopleList();
            Account2014.AssignTransactions();
        }
    }
}