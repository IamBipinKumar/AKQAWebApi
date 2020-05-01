/// <summary>
/// AKQA Utilities Utility namespace
/// </summary>
namespace AKQA.Utilities.Utility
{
    using AKQA.Utilities.Constants;
    using AKQA.Utilities.Extensions;
    using Nut;
    using System.Globalization;

    /// <summary>
    /// Currency Converter
    /// </summary>
    public static class CurrencyConverter
    {
        /// <summary>
        /// Convert to Text
        /// </summary>
        /// <param name="amount">Amount</param>
        /// <param name="toUpperCase">To Upper Case flag</param>
        /// <param name="charToAppend">Char to append</param>
        /// <returns>Convert amount into text</returns>
        public static string ConvertToText(decimal amount, bool toUpperCase, string charToAppend)
        {
            var amountString = amount.ToText(Currency.USD, Language.English);
            amountString = toUpperCase ? amountString.ToUpper(CultureInfo.InvariantCulture) : amountString;
            amountString = AppendChar(amountString, charToAppend);

            return amountString;
        }

        /// <summary>
        /// Append Char
        /// </summary>
        /// <param name="amount">Amount in string</param>
        /// <param name="charToAppend">Char to append</param>
        /// <returns>Char appended amount</returns>
        public static string AppendChar(string amount, string charToAppend)
        {
            return amount
                .ReplaceChar(Constants.TWENTY, charToAppend)
                .ReplaceChar(Constants.THIRTY, charToAppend)
                .ReplaceChar(Constants.FORTY, charToAppend)
                .ReplaceChar(Constants.FIFTY, charToAppend)
                .ReplaceChar(Constants.SIXTY, charToAppend)
                .ReplaceChar(Constants.SEVENTY, charToAppend)
                .ReplaceChar(Constants.EIGHTY, charToAppend)
                .ReplaceChar(Constants.NINETY, charToAppend);
        }
    }
}
