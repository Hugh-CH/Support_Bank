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
            Bank Account2014 = new Bank();
            Account2014.SetUpFromCsv("C:/Work/Training/Support_Bank/Transactions2014.csv");
            //Account2014.ListAll();
            Account2014.ListIndividual("Sarah T");
            
        }
    }
}