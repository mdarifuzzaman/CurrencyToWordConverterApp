// © 2018 Sitecore Corporation A/S. All rights reserved. Sitecore® is a registered trademark of Sitecore Corporation A/S.

using System;
using System.Globalization;
using Converter.Core.Contracts;

namespace Converter.Core.Frameworks
{
    public class IntegerToWordConverter : Contracts.Converter<int>
    {

        public override string ConvertToWord(int number)
        {
            if (number < 0)
            {
                return "CURRENCY IS NEGETIVE";
            }

            var result = ConvertFromInteger(Convert.ToInt32(number));
            var str = number > 0 ? "dollars" : "dollar";
            return ($"{result} {str}").ToUpper(CultureInfo.InvariantCulture);
        }
    }
}
