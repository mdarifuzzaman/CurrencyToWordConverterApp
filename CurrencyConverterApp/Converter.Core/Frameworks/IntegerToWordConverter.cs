using System;
using System.Globalization;
using Converter.Core.Contracts;

namespace Converter.Core.Frameworks
{
    public class IntegerToWordConverter : Converter<int>
    {
        public override string ConvertToWord(int number)
        {
            if (number < 0)
            {
                return "CURRENCY IS NEGETIVE";
            }

            string result = ConvertFromInteger(Convert.ToInt32(number));
            string str = number > 0 ? "dollars" : "dollar";
            return ($"{result} {str}").ToUpper(CultureInfo.InvariantCulture);
        }
    }
}
