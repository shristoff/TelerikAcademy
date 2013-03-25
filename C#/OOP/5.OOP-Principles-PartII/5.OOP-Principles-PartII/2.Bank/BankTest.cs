/*2.A bank holds different types of accounts for its customers: deposit accounts, loan accounts and mortgage accounts. 
  Customers could be individuals or companies. All accounts have customer, balance and interest rate (monthly based). 
  Deposit accounts are allowed to deposit and withdraw money. Loan and mortgage accounts can only deposit money.
  All accounts can calculate their interest amount for a given period (in months). In the common case its is calculated 
  as follows: number_of_months * interest_rate. Loan accounts have no interest for the first 3 months 
  if are held by individuals and for the first 2 months if are held by a company.
  Deposit accounts have no interest if their balance is positive and less than 1000.
  Mortgage accounts have ½ interest for the first 12 months for companies and no interest for the first 6 months for individuals.
  Your task is to write a program to model the bank system by classes and interfaces. You should identify the classes, interfaces, 
  base classes and abstract actions and implement the calculation of the interest functionality through overridden methods.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class BankTest
    {
        static void Main()
        {
            IndividualCustomer individualCustomer1 = new IndividualCustomer("Peter Johnson");
            CompanyCustomer companyCustomer1 = new CompanyCustomer("Telerik");
            Account[] accounts = {
                new DepositAccount(individualCustomer1, 2345M, 0.4M),
                new MortgageAccount(individualCustomer1, -230000M, 0.5M),
                new LoanAccount(companyCustomer1, -1000000M, 0.2M)
            };

            foreach (Account account in accounts)
            {
                Console.WriteLine("The year interest is: {0:P}", account.CalculateInterest(12));
            }

            Console.WriteLine(new string('=', 40));

            Console.WriteLine("Balance: {0}", accounts[0].Balance);
            accounts[0].Deposit(200m);
            Console.WriteLine("Balance after deposit: {0}", accounts[0].Balance);
            (accounts[0] as DepositAccount).Withdraw(50m);
            Console.WriteLine("Balance after withdraw: {0}", accounts[0].Balance);

            Console.WriteLine("Balance: {0}", accounts[1].Balance);
            accounts[1].Deposit(1000m);
            Console.WriteLine("Balance after deposit: {0}", accounts[1].Balance);
        }
    }
}
