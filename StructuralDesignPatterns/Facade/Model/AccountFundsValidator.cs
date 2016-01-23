using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.Facade.Model
{
    class AccountFundsValidator
    {

        public double Balance { get; private set; } = 1000;


        public bool RequestCash(double requestAmount)
        {
            bool result = false;

            if(requestAmount > Balance)
            {
                Console.WriteLine("NOT ENOUGH MONEY");
            }
            else
            {
                Balance -= requestAmount;
                result = true;
            }
            return result;
        }


        public void Deposit(double amount)
        {
            Balance += amount;
            
        }

   
    }
}
