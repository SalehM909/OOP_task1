using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_task1
{
    public class Bank
    {
        private List<BankAccount> accounts = new List<BankAccount>();


        public void AddAccount()
        {
            Console.WriteLine("enter your name");
            string name = Console.ReadLine();

            Console.WriteLine("enter your accountNumber");
            string number = Console.ReadLine();

            BankAccount ba = new BankAccount(name,number);

            accounts.Add(ba);
            Console.WriteLine($"Account for {ba.AccountHolderName} added.");
        }
        public void DisplayAllAccounts()
        {
            Console.WriteLine("List of Bank Accounts:");
            foreach (var account in accounts)
            {
                Console.WriteLine(account.GetAccountInfo());
                Console.WriteLine();
            }

        }
        public BankAccount GetAccountByNumber(string accountNumber)
        {
            return accounts.Find(account => account.AccountNumber == accountNumber);
        }



    }
}
