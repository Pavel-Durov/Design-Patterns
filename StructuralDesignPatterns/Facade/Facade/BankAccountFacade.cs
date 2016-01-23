using StructuralDesignPatterns.Facade.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.Facade.Facade
{
    class BankAccountFacade
    {

        public BankAccountFacade(int accountNumber, int pinCode)
        {
            this.PinCode = pinCode;
            this.AccountNumber = accountNumber;

            _fundsValidator = new AccountFundsValidator();
            _accountNumberValidator = new AccountNumberValidator();
            _securityCodeValidator = new SecurityCodeValidator();
        }

        public int PinCode { get; set; }

        public int AccountNumber { get; set; }

        AccountFundsValidator _fundsValidator;
        AccountNumberValidator _accountNumberValidator;
        SecurityCodeValidator _securityCodeValidator;

        internal void Withdraw(double amount)
        {
            if (_accountNumberValidator.ActivateAccount(AccountNumber) && _securityCodeValidator.IsCorrect(PinCode))
            {
                if (_fundsValidator.RequestCash(amount))
                {
                    Console.WriteLine("Withdraw SUCCEDED");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Withdraw FAILED");
                    Console.ForegroundColor = ConsoleColor.White;

                }
            }
        }

        internal void Deposit(double amount)
        {
            if (_accountNumberValidator.ActivateAccount(AccountNumber) && _securityCodeValidator.IsCorrect(PinCode))
            {
                _fundsValidator.Deposit(amount);
                Console.WriteLine("Deposit SUCCEDED");
                Console.WriteLine($"Your balance : {_fundsValidator.Balance}");    
            }
            else {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Deposit FAILED - Wrong credentials");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

    }
}
