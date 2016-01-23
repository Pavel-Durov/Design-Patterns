using StructuralDesignPatterns.Facade.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.Facade
{
    class Test
    {
        public static void Run()
        {
            BankAccountFacade facade = new BankAccountFacade(12345678, 1234);

            facade.Withdraw(60);
            facade.Deposit(60);


            facade.Withdraw(1001);

        }
    }
}
