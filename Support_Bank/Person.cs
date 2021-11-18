
using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;

namespace Support_Bank
{
    public class Person
    {
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

        public Person(string name)
        {
            this.name = name;
            listOfPaymentsIn = new List<Transaction>();
            listOfPaymentsOut = new List<Transaction>();
        }

    }
}