/// <summary>
/// AKQA Utilities Extensions namespace
/// </summary>
namespace AKQA.Utilities.Extensions
{
    using AKQA.Utilities.Constants;

    /// <summary>
    /// Currency Extension
    /// </summary>
    public static class CurrencyExtension
    {
        /// <summary>
        /// Replace Char
        /// </summary>
        /// <param name="amount">Amount in string</param>
        /// <param name="replace">Character to replaced</param>
        /// <param name="with">Character to repleace</param>
        /// <returns>Replaced string</returns>
        public static string ReplaceChar(this string amount, string replace, string with)
        {
            return amount.Replace($"{replace}{Constants.Space}", $"{replace}{with}");
        }
    }
}