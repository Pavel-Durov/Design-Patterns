namespace StructuralDesignPatterns.Facade.Model
{
    class SecurityCodeValidator
    {
        public const int SECURITY_CODE = 1234;

        public bool IsCorrect(int code)
        {
            return code == SECURITY_CODE;
        }
    }
}
