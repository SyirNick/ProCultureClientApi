using Newtonsoft.Json;

namespace ProCultureApiClient.Contracts
{
    /// <summary>
    /// Wrapper for a visitor instance
    /// </summary>
    public class Visitor
    {
        public Visitor(string fullName, string firstName, string middleName, string lastName)
        { 
            FullName = fullName;
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
        }

        /// <summary>
        /// Full name, FIO
        /// </summary>
        [JsonProperty(PropertyName = "Full_Name")]
        public string FullName { get; set; }

        /// <summary>
        /// First name (for an example, Ivan)
        /// </summary>
        [JsonProperty(PropertyName = "First_Name")]
        public string FirstName { get; set; }

        /// <summary>
        /// Middle name (for an example, Ivanovich)
        /// </summary>
        [JsonProperty(PropertyName = "Middle_Name")]
        public string MiddleName { get; set; }

        /// <summary>
        /// Last name (for an example, Ivanov)
        /// </summary>
        [JsonProperty(PropertyName = "Last_Name")]
        public string LastName { get; set; }
    }
}
