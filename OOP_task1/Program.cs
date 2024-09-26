using System;

namespace OOP_task1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Bank myBank = new Bank();

            while (true)
            {
                Console.WriteLine("Choose an operation:");
                Console.WriteLine("0: Add Account");
                Console.WriteLine("1: Display All Accounts");
                Console.WriteLine("2: Get Account by Number");
                Console.WriteLine("3: Exit the program");

                // Safe input handling
                if (int.TryParse(Console.ReadLine(), out int op))
                {
                    switch (op)
                    {
                        case 0:
                            myBank.AddAccount();
                            break;

                        case 1:
                            myBank.DisplayAllAccounts();
                            break;

                        case 2:
                            Console.WriteLine("Enter account number:");
                            string accountNumber = Console.ReadLine();
                            var account = myBank.GetAccountByNumber(accountNumber);
                            if (account != null)
                            {
                                Console.WriteLine(account.GetAccountInfo());
                            }
                            else
                            {
                                Console.WriteLine("Account not found.");
                            }
                            break;

                        case 3:
                            Console.WriteLine("Exiting...");
                            return; 

                        default:
                            Console.WriteLine("Invalid operation. Please try again.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid integer.");
                }
            }
        }
    }
}

