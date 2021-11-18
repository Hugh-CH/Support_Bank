
using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using NLog;

namespace Support_Bank
{
    public class Person
    {
        private static readonly ILogger logger = LogManager.GetCurrentClassLogger();
        
        public string name;
        public List<Transaction> listOfPaymentsOut;
        public List<Transaction> listOfPaymentsIn;

        public void AddPaymentOut(Transaction transaction)
        {
            listOfPaymentsOut.Add(transaction);
        }

        public void AddPaymentIn(Transaction transaction)
        {
            listOfPaymentsIn.Add(transaction);
        }

        public float CalculateBalance()
        {
            float balance = 0;
            foreach (Transaction payment in listOfPaymentsIn)
            {
                balance += payment.amount;
            }
            foreach (Transaction payment in listOfPaymentsOut)
            {
                balance -= payment.amount;
            }
            return balance;
        }

        public Person(string name)
        {
            this.name = name;
            listOfPaymentsIn = new List<Transaction>();
            listOfPaymentsOut = new List<Transaction>();
        }

        public void PrintTransactions()
        {
            Console.WriteLine($"Payments Made By {name}");
            Console.WriteLine("=========================");

            foreach (Transaction payment in listOfPaymentsOut)
            {
                Console.WriteLine($"On {payment.date}, {payment.amount:c} to {payment.to} for {payment.narrative}");
            }
            
            Console.WriteLine("");
            
            Console.WriteLine($"Payments Made to {name}");
            Console.WriteLine("=========================");
            
            foreach (Transaction payment in listOfPaymentsIn)
            {
                Console.WriteLine($"On {payment.date}, {payment.amount:c} from {payment.from} for {payment.narrative}");
            }
            
            Console.WriteLine("=========================");
            
            float balance = CalculateBalance();
            switch (balance>=0)
            {
                case    true:
                    Console.WriteLine($"In total {name} is owed {balance:c}");
                    break;
                case false:
                    balance = Math.Abs(balance);
                    Console.WriteLine($"In total {name} owes {balance:C}");
                    break;
            }
            
            
        }
    }
}