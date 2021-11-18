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
            Bank Account2014 = new Bank();
            Account2014.SetUpFromCsv("C:/Work/Training/Support_Bank/Transactions2014.csv");
        }
    }
}