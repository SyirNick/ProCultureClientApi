using Newtonsoft.Json;

namespace ProCultureApiClient.Contracts
{
    /// <summary>
    /// Event information
    /// </summary>
    public class Session
    {
        public Session(string eventId, string organizationId, int date, string place, string parameters)
        { 
            EventId = eventId;
            OrganizationId = organizationId;
            Date = date;
            Place = place;
            Params = parameters;
        }

        /// <summary>
        /// PRO.Culture.RF event ID
        /// </summary>
        [JsonProperty(PropertyName = "Event_Id")]
        public string EventId { get; set; }

        /// <summary>
        /// PRO.Culture.RF organization ID
        /// </summary>
        [JsonProperty(PropertyName = "Organization_Id")]
        public string OrganizationId { get; set; }

        /// <summary>
        /// Date and time of event (unix timestamp)
        /// </summary>
        public int Date { get; set; }

        /// <summary>
        /// Address or description of event place
        /// </summary>
        public string Place { get; set; }

        /// <summary>
        /// Hall+Sector+Row+Place (Зал+Сектор+Ряд+Место)
        /// </summary>
        public string Params { get; set; }
    }
}
