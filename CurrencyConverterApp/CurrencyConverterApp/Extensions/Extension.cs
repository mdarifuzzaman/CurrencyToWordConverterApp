namespace CurrencyConverterService.Extensions
{
    public static class Extension
    {
        public static bool IsInteger(this decimal number)
        {
            return number % 1 == 0;
        }
    }
}
