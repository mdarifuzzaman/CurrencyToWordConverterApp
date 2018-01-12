using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Converter.Core.Contracts;

namespace Converter.Core.Frameworks
{
    public class DoubleToWordConverter:Converter<double>
    {
        public override string ConvertToWord(double number)
        {
            if (number < 0)
            {
                return "CURRENCY IS NEGETIVE";
            }

            return this.ConvertFromDouble(number);
        }
        protected virtual string ConvertFromDouble(double doubleNumber)
        {
            var beforeFloatingPoint = (int)Math.Floor(doubleNumber);
            string beforeFloatingPointWord = $"{ConvertFromInteger(beforeFloatingPoint)} dollars";
            string afterFloatingPointWord =
                $"{SmallNumberToWord((int)((doubleNumber - beforeFloatingPoint) * 100), "")} cents";
            return ($"{beforeFloatingPointWord} and {afterFloatingPointWord}").ToUpper(CultureInfo.InvariantCulture);
        }

    }
}
