using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var BankAccount = new BankAccount();
            while (true)
            {
                Console.WriteLine("Do you want to withdraw or deposit(w or d)?");
                var choice = Console.ReadLine();
                Console.WriteLine("Please enter amount");
                double amount = Double.Parse(Console.ReadLine());

                if (choice == "w")
                {
                    BankAccount.Withdraw(amount);
                    Console.WriteLine("ActiveBalance : " + (BankAccount.GetBalance() + BankAccount.GetODLimit()));
                }
                else if (choice == "d")
                {
                    BankAccount.Deposit(amount);
                    Console.WriteLine("ActiveBalance : " + (BankAccount.GetBalance() + BankAccount.GetODLimit()));
                }
                else
                {
                    break;
                }
            }
          

        }
    }
}
