using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OOP_task1
{
    public class BankAccount
    {

        public string AccountNumber { get; set; }
        public string AccountHolderName { get; set; }
        public decimal Balance { get; private set; }


        public BankAccount(string accountHolderName, string accountNumber)
        {
            AccountHolderName = accountHolderName;
            AccountNumber = accountNumber;
            Balance = 0;
        }


        public BankAccount(decimal initialDeposit, string accountHolderName, string accountNumber)
        {
           this.AccountHolderName = accountHolderName;
           this.AccountNumber = accountNumber;
           Deposit (initialDeposit);
        }

        public void Deposit(decimal amount)

        {

            if (Balance <= 0)
            {
                Console.WriteLine("Deposit amount must be omre than (0).");
                return;
            }
            Balance += amount;
            Console.WriteLine($"Deposited: {amount:C}. New Balance: {Balance:C}");
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Withdrawal amount must be more than (0).");
                return;
            }

            if (amount > Balance)
            {
                Console.WriteLine("Insufficient balance for this withdrawal.");
                return;
            }

            Balance -= amount;
            Console.WriteLine($"Withdrew: {amount:C}. New Balance: {Balance:C}");


        }
        public string GetAccountInfo()
        {
            return $"Account Holder: {AccountHolderName}\nAccount Number: {AccountNumber}\nBalance: {Balance:C}";
        }
        public decimal GetBalance()
        {
            return Balance;


        }
    }
}
