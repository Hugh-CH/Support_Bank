using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Transactions;
using NLog;
using NLog.Config;
using NLog.Targets;


namespace Support_Bank
{
    class Program
    {
      private static readonly ILogger logger = LogManager.GetCurrentClassLogger();
        static void Main(string[] args)
        {
            
            var config = new LoggingConfiguration();
            var target = new FileTarget { FileName = @"C:\Work\Training\Support_Bank\Logs\SupportBank.log", Layout = @"${longdate} ${level} - ${logger}: ${message}" };
            config.AddTarget("File Logger", target);
            config.LoggingRules.Add(new LoggingRule("*", LogLevel.Debug, target));
            LogManager.Configuration = config;
            
            logger.Debug("Program Start");
            
            
            Bank ABank = new Bank(); 
            ABank.SetUpFromCsv("C:/Work/Training/Support_Bank/DodgyTransactions2015.csv");
            
            if (args[0] == "List")
                if (args.Length == 1)
                    ABank.ListAll();
                else if (args.Length == 2)
                {
                    ABank.ListIndividual(args[1]);    
                }

        }
    }
}