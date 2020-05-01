/// <summary>
/// AKQA Web API Models namespace
/// </summary>
namespace AKQAWebAPI.Models
{
    /// <summary>
    /// Akqa Model
    /// </summary>
    public class AkqaRequestModel : AkqaBaseModel
    {
        /// <summary>
        /// Amount
        /// </summary>
        public decimal Amount
        {
            get
            {
                decimal amount = 0;
                decimal.TryParse(Number, out amount);
                return amount;
            }
        }
    }
}