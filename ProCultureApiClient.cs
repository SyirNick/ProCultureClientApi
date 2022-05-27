using Newtonsoft.Json;
using ProCultureApiClient.Contracts;
using RestSharp;

namespace ProCultureApiClient
{
    /// <summary>
    /// PRO.Culture.RF api wrapper with lazy singleton initialization. Usage:<br></br>
    /// ProCultureApiClient client = ProCultureApiClient.GetIntance;
    /// </summary>
    public sealed class ProCultureApiClient
    {
        private static readonly Lazy<ProCultureApiClient> _lazy =
            new Lazy<ProCultureApiClient>(() => new ProCultureApiClient());

        public static ProCultureApiClient GetInstance { get => _lazy.Value; }

        private ProCultureApiClient()
        {

        }

        /// <summary>
        /// Get or set base url for PRO.Culture.RF. For an example you can set a test environment there;<br></br>
        /// By default it equals <a href="https://pro.culture.ru/api/2.5">https://pro.culture.ru/api/2.5</a>
        /// </summary>
        public Uri BaseUrl { get; set; } = new Uri("https://pro.culture.ru/api/2.5");

        /// <summary>
        /// Get or set identifier exchange url for PRO.Culture.RF. For an example you can set a test environment there;<br></br>
        /// By default it equals <a href="https://pro.culture.ru/api/v2.5/pushka">https://pro.culture.ru/api/v2.5/pushka</a>
        /// </summary>
        public Uri IdExchangeUrl { get; set; } = new Uri("https://pro.culture.ru/api/v2.5/pushka");

        /// <summary>
        /// Get or set tickets url for PRO.Culture.RF. For an example you can set a test environment there;<br></br>
        /// By default it equals <a href="https://pushka.gosuslugi.ru/api/v1">https://pushka.gosuslugi.ru/api/v1</a>
        /// </summary>
        public Uri TicketsUrl { get; set; } = new Uri("https://pushka.gosuslugi.ru/api/v1");

        private RestRequest GetRestRequest(string resource, Method method) => new RestRequest(resource, method);

        #region Get event, event ids, link events

        /// <summary>
        /// Gets the Event by id, using api key;<br></br>
        /// Method: GET, "{BaseUrl}/events";<br></br>
        /// Reference: <a href="https://pro.culture.ru/new/api/documentation/export">https://pro.culture.ru/new/api/documentation/export</a>
        /// </summary>
        /// <param name="apiKey">Api key to access PRO.Culture.RF</param>
        /// <param name="eventId"></param>
        /// <returns>
        /// - Status code 200: instance of Event class;<br></br>
        /// - Status code 403: throws ProCultureException;<br></br>
        /// - Status code 500: throws ProCultureException;<br></br>
        /// - Failed to get answer: throws ProCultureException;<br></br>
        /// - Failed to deserialize: throws ProCultureException.
        /// </returns>
        public async Task<Event> GetEventById(string apiKey, int eventId) => await
            GetRestRequest("events", Method.Get)
                .AddParameter("apiKey", apiKey)
                .AddParameter("id", eventId)
                .ProceedAsync<Event>(BaseUrl);

        /// <summary>
        /// Link ticket system event ID to PRO.Culture.RF event ID;<br></br>
        /// Method: POST, "{IdExchangeUrl}/idexchange";<br></br>
        /// Reference: <a href="https://docs.culture.ru/exchange">https://docs.culture.ru/exchange</a>
        /// </summary>
        /// <param name="apiKey">Api key to access PRO.Culture.RF</param>
        /// <param name="request">Request that contains system event ID to PRO.Culture.RF event ID</param>
        /// <returns>
        /// - Status code 201: string "Created";<br></br>
        /// - Status code 400: throws ProCultureException;<br></br>
        /// - Status code 500: throws ProCultureException;<br></br>
        /// - Failed to get answer: throws ProCultureException.
        /// </returns>
        public async Task<string> LinkEventIds(string apiKey, LinkEventIdsRequest request) => await
            GetRestRequest("idexchange", Method.Post)
                .AddJsonBody(JsonConvert.SerializeObject(request))
                .ProceedAsync<string>(IdExchangeUrl);

        /// <summary>
        /// Get event id by ticket system INN and ticket system event ID;<br></br>
        /// Method: GET, "{IdExchangeUrl}/idexchange/{request.systemInn}/{request.SystemEventId}";<br></br>
        /// Reference: <a href="https://docs.culture.ru/exchange">https://docs.culture.ru/exchange</a>
        /// </summary>
        /// <param name="apiKey">Api key to access PRO.Culture.RF</param>
        /// <param name="request">Request that contains ticket system INN and ticket system event ID</param>
        /// <returns>
        /// - Status code 200: instance of GetEventIdResponse class;<br></br>
        /// - Status code 400: throws ProCultureException;<br></br>
        /// - Status code 500: throws ProCultureException;<br></br>
        /// - Failed to get answer: throws ProCultureException;<br></br>
        /// - Failed to deserialize: throws ProCultureException.
        /// </returns>
        public async Task<GetEventIdResponse> GetEventId(string apiKey, GetEventIdRequest request) => await
            GetRestRequest($"idexchange/{request.SystemInn}/{request.SystemEventId}", Method.Get)
                .AddParameter("apiKey", apiKey)
                .ProceedAsync<GetEventIdResponse>(IdExchangeUrl);

        #endregion

        #region Ticket sales

        /// <summary>
        /// Add information about ticket that has been purchased with Pushkin Card to the PRO.Culture.RF registry;<br></br>
        /// Method: POST, "{TicketsUrl}/tickets";<br></br>
        /// Reference: <a href="https://docs.culture.ru/tickets">https://docs.culture.ru/tickets</a>
        /// </summary>
        /// <param name="apiKey">Api key to access PRO.Culture.RF</param>
        /// <param name="request">Request that contains information about ticket</param>
        /// <returns>
        /// - Status code 201: instance of RegisterTicketResponse class;<br></br>
        /// - Status code 400: throws ProCultureException;<br></br>
        /// - Status code 500: throws ProCultureException;<br></br>
        /// - Failed to get answer: throws ProCultureException;<br></br>
        /// - Failed to deserialize: throws ProCultureException.
        /// </returns>
        public async Task<RegisterTicketResponse> RegisterTicket(string apiKey, RegisterTicketRequest request) => await
            GetRestRequest("tickets", Method.Post)
                .AddBody(JsonConvert.SerializeObject(request))
                .ProceedAsync<RegisterTicketResponse>(TicketsUrl);

        /// <summary>
        /// Gets information about ticket with ticket ID;<br></br>
        /// Method: GET, "{TicketsUrl}/tickets/{ticketId}";<br></br>
        /// Reference: <a href="https://docs.culture.ru/tickets">https://docs.culture.ru/tickets</a>
        /// </summary>
        /// <param name="apiKey">Api key to access PRO.Culture.RF</param>
        /// <param name="ticketId">PRO.Culture.RF ticket ID</param>
        /// <returns>
        /// - Status code 200: instance of GetTicketInfoResponse class;<br></br>
        /// - Status code 400: throws ProCultureException;<br></br>
        /// - Status code 500: throws ProCultureException;<br></br>
        /// - Failed to get answer: throws ProCultureException;<br></br>
        /// - Failed to deserialize: throws ProCultureException.
        /// </returns>
        public async Task<GetTicketInfoResponse> GetTicketInfoById(string apiKey, string ticketId) => await
            GetRestRequest($"tickets/{ticketId}", Method.Get)
                .AddParameter("apikey", apiKey)
                .ProceedAsync<GetTicketInfoResponse>(TicketsUrl);

        /// <summary>
        /// Refunds ticket;<br></br>
        /// Method: PUT, "{TicketsUrl}/tickets/{ticketId}/refund";<br></br>
        /// Reference: <a href="https://docs.culture.ru/tickets">https://docs.culture.ru/tickets</a>
        /// </summary>
        /// <param name="apikey">Api key to access PRO.Culture.RF</param>
        /// <param name="ticketId">PRO.Culture.RF ticket ID</param>
        /// <param name="request">Request that contains information about ticket refund</param>
        /// <returns>
        /// - Status code 200: instance of RefundTicketResponse class;<br></br>
        /// - Status code 400: throws ProCultureException;<br></br>
        /// - Status code 500: throws ProCultureException;<br></br>
        /// - Failed to get answer: throws ProCultureException;<br></br>
        /// - Failed to deserialize: throws ProCultureException.
        /// </returns>
        public async Task<RefundTicketResponse> RefundTicket(string apikey, string ticketId, RefundTicketRequest request) => await
            GetRestRequest($"tickets/{ticketId}/refund", Method.Put)
                .AddParameter("apiKey", apikey)
                .AddJsonBody(JsonConvert.SerializeObject(request))
                .ProceedAsync<RefundTicketResponse>(TicketsUrl);

        /// <summary>
        /// Add visit information to the ticket by its ID;<br></br>
        /// Method: PUT, "{TicketsUrl}/tickets/{ticketId}/visit";<br></br>
        /// Reference: <a href="https://docs.culture.ru/tickets">https://docs.culture.ru/tickets</a>
        /// </summary>
        /// <param name="apiKey">Api key to access PRO.Culture.RF</param>
        /// <param name="ticketId">PRO.Culture.RF ticket ID</param>
        /// <param name="request">Request that contains information about ticket visit</param>
        /// <returns>
        /// - Status code 200: instance of VisitTicketResponse class;<br></br>
        /// - Status code 400: throws ProCultureException;<br></br>
        /// - Status code 500: throws ProCultureException;<br></br>
        /// - Failed to get answer: throws ProCultureException;<br></br>
        /// - Failed to deserialize: throws ProCultureException.
        /// </returns>
        public async Task<VisitTicketResponse> AddVisitInfo(string apiKey, string ticketId, VisitTicketRequest request) => await
            GetRestRequest($"tickets/{ticketId}/visit", Method.Put)
                .AddParameter("apiKey", apiKey)
                .AddJsonBody(JsonConvert.SerializeObject(request))
                .ProceedAsync<VisitTicketResponse>(TicketsUrl);

        #endregion

        #region Ticket controllers

        /// <summary>
        /// Gets information about event by barcode (or QR-Code) and event ID;<br></br>
        /// Method: GET, "{TicketsUrl}/events/{eventId}/tickets/{barcode}";<br></br>
        /// Reference: <a href="https://docs.culture.ru/tickets">https://docs.culture.ru/tickets</a>
        /// </summary>
        /// <param name="apikey">Api key to access PRO.Culture.RF</param>
        /// <param name="eventId">PRO.Culture.RF event ID</param>
        /// <param name="barcode">Ticket barcode</param>
        /// <returns></returns>
        /// <returns>
        /// - Status code 200: instance of GetTicketControllerResponse class;<br></br>
        /// - Status code 400: throws ProCultureException;<br></br>
        /// - Status code 500: throws ProCultureException;<br></br>
        /// - Failed to get answer: throws ProCultureException;<br></br>
        /// - Failed to deserialize: throws ProCultureException.
        /// </returns>
        public async Task<GetTicketControllerResponse> GetTicketControllerInfo(string apikey, string eventId, string barcode) => await
            GetRestRequest($"events/{eventId}/tickets/{barcode}", Method.Get)
                .AddParameter("apiKey", apikey)
                .ProceedAsync<GetTicketControllerResponse>(TicketsUrl);

        /// <summary>
        /// Add visit information to the ticket by event id and ticket barcode;<br></br>
        /// Method: PUT, "{TicketsUrl}/events/{eventId}/tickets/{barcode}/visit";<br></br>
        /// Reference: <a href="https://docs.culture.ru/tickets">https://docs.culture.ru/tickets</a>
        /// </summary>
        /// <param name="apiKey">Api key to access PRO.Culture.RF</param>
        /// <param name="eventId">PRO.Culture.RF event ID</param>
        /// <param name="request">Request that contains information about ticket visit</param>
        /// <returns>
        /// - Status code 200: instance of VisitTicketResponse class;<br></br>
        /// - Status code 400: throws ProCultureException;<br></br>
        /// - Status code 500: throws ProCultureException;<br></br>
        /// - Failed to get answer: throws ProCultureException;<br></br>
        /// - Failed to deserialize: throws ProCultureException.
        /// </returns>
        public async Task<VisitTicketResponse> AddVisitInfo(string apiKey, string eventId, string barcode, VisitTicketRequest request) => await
            GetRestRequest($"events/{eventId}/tickets/{barcode}/visit", Method.Put)
                .AddParameter("apiKey", apiKey)
                .AddJsonBody(JsonConvert.SerializeObject(request))
                .ProceedAsync<VisitTicketResponse>(TicketsUrl);

        #endregion
    }
}