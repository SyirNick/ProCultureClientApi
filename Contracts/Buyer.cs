using Newtonsoft.Json;

namespace ProCultureApiClient.Contracts
{
    /// <summary>
    /// Information about buyer
    /// </summary>
    public class Buyer
    {
        public Buyer(string mobilePhone)
        { 
            MobilePhone = mobilePhone;
        }

        /// <summary>
        /// Buyer mobile phone
        /// </summary>
        [JsonProperty(PropertyName = "Mobile_Phone")]
        public string MobilePhone { get; set; }
    }
}
