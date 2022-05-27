namespace ProCultureApiClient.Contracts
{
    /// <summary>
    /// Class for linking ticket system event ID and PRO.Culture.RF event id
    /// </summary>
    public class LinkEventIdsRequest
    {
        public LinkEventIdsRequest(string systemInn, string systemEventId, string proEventId, EventStatus status)
        { 
            SystemInn = systemInn;
            SystemEventId = systemEventId;
            ProEventId = proEventId;
            Status = status;
        }

        /// <summary>
        /// Ticket organization INN
        /// </summary>
        public string SystemInn { get; set; }

        /// <summary>
        /// Ticket system event ID
        /// </summary>
        public string SystemEventId { get; set; }

        /// <summary>
        /// PRO.Culture.RF event ID
        /// </summary>
        public string ProEventId { get; set; }

        /// <summary>
        /// Event status
        /// </summary>
        public EventStatus Status { get; set; }
    }
}
