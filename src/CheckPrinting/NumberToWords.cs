using System;

namespace CheckPrinting
{
    public static class NumberToWords
    {
        /// <summary>
        /// Converts the <paramref name="dollars"/> to its English textual representation in words.
        /// </summary>
        /// <param name="dollars">The dollar amount to convert.</param>
        /// <returns>The number in words, e.g. Four hundred fifty-six and 00/100.</returns>
        public static string Convert(decimal dollars)
        {
            var wholeNumber = (int)Math.Truncate(dollars);
            var decimalPlaces = (int)(dollars % 1 * 100);

            var words = ConvertNumberToWords(wholeNumber).ToUpper();
            if (dollars < 101)
            {
                words = words.Replace('-', ' ');
            }

            return $"{words} AND {decimalPlaces}/100";
        }

        private static string ConvertNumberToWords(int number)
        {
            // Credit: http://stackoverflow.com/a/2730393/4403297

            if (number == 0)
                return "Zero";

            if (number < 0)
                return "Minus " + ConvertNumberToWords(Math.Abs(number));

            var words = "";

            if (number / 1000000 > 0)
            {
                words += ConvertNumberToWords(number / 1000000) + " Million ";
                number %= 1000000;
            }

            if (number / 1000 > 0)
            {
                words += ConvertNumberToWords(number / 1000) + " Thousand ";
                number %= 1000;
            }

            if (number / 100 > 0)
            {
                words += ConvertNumberToWords(number / 100) + " Hundred ";
                number %= 100;
            }

            if (number > 0)
            {
                //if (words != "")
                //    words += "and ";

                var unitsMap = new[] { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
                var tensMap = new[] { "Zero", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

                if (number < 20)
                    words += unitsMap[number];
                else
                {
                    words += tensMap[number / 10];
                    if (number % 10 > 0)
                        words += "-" + unitsMap[number % 10];
                }
            }

            return words;
        }
    }
}
