using Interfaces;
using Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> accntNumbers = new List<string> {"CITI-456", "NATIONAL-987", "CHASE-222"};
            foreach (var account in accntNumbers)
            {
                ICreditUnionFactory anAbstractFactory = CreditUnionFactoryProvider.GetCreditUnionFactory(account);
                if (anAbstractFactory == null)
                {
                    Console.WriteLine("Sorry. This credit union w/ account number" + " ' {0} ' is invalid.", (account));
                }
                else
                {
                    ILoanAccount loan = anAbstractFactory.CreateLoanAccount();
                    ISavingsAccount savings = anAbstractFactory.CreateSavingsAccount();
                }
            }
            Console.ReadLine();
        }
    }
}
