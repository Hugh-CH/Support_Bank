using System;
using System.Globalization;
using System.IO;
using System.Transactions;


namespace Support_Bank
{
    class Program
    {
        static void ReadCsv(string filename)
        {
            StreamReader sr = new StreamReader(filename);
            string line;
            string[] row = new string [5];
            line = sr.ReadLine();
            line = sr.ReadLine();
            //while ((line = sr.ReadLine()) != null)
            //{
                row = line.Split(',');
                Console.WriteLine(row[1]);
                Transaction test = new Transaction(row);
                test.PrintTransaction();
                // }
        }

       
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ReadCsv("C:/Work/Training/Support_Bank/Transactions2014.csv");
            
            
            
        }
    }
}