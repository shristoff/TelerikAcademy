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
    public class MortgageAccount : Account, IDepositable
    {
        public MortgageAccount(Customer owner, decimal balance, decimal interestRate)
            : base(owner, balance, interestRate)
        { 
        }

        public override void Deposit(decimal amount)
        {
            base.Deposit(amount);
        }

        public override decimal CalculateInterest(int numberOfMonths)
        {
            if (Owner is IndividualCustomer)
            {
                numberOfMonths = numberOfMonths > 6 ? (numberOfMonths - 6) : 0;
                return base.CalculateInterest(numberOfMonths);
            }
            else if (Owner is CompanyCustomer)
            {
                if (numberOfMonths <= 12)
                    return base.CalculateInterest(numberOfMonths) / 2;
                else
                    return (base.CalculateInterest(12) / 2 + base.CalculateInterest(numberOfMonths - 12));
            }
            else
                throw new ArgumentException("Invalid customer type");
        }
    }
}