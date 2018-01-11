// © 2018 Sitecore Corporation A/S. All rights reserved. Sitecore® is a registered trademark of Sitecore Corporation A/S.

using System;
using Converter.Core.Contracts;

namespace Converter.Core.Frameworks
{
    public class IntegerToWordConverter : Contracts.Converter<int>
    {

        public override string ConvertToWord(int number)
        {
            return ConvertFromInteger(Convert.ToInt32(number));
        }
    }
}
