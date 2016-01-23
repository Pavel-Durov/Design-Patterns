namespace StructuralDesignPatterns.Facade.Model
{
    class AccountNumberValidator
    {

        public const int ACCOUNT_NUMBER = 12345678;

        public bool ActivateAccount(int account)
        {
            return account == ACCOUNT_NUMBER;
        }
    }
}
