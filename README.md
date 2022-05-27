# ProCultureClientApi
Wrapper for PRO.Culture.RF api.

***Version 1.0.0:***

General usage: ProCultureApiClient client = ProCultureApiClient.GetIntance.

Methods: 

1) Event linking

- GetEventById: gets the event by id, using api key;
- LinkEventIds: link ticket system event ID to PRO.Culture.RF event ID;
- GetEventId: get event ID by ticket system INN and ticket system event ID;

2) Ticket sales

- RegisterTicket: add information about ticket that has been purchased with Pushkin Card to the PRO.Culture.RF registry;
- GetTicketInfoById: gets information about ticket with ticket ID;
- RefundTicket: refunds ticket by ticket ID;
- AddVisitInfo: add visit information to the ticket by its ID;

3) Ticket controllers

- GetTicketControllerInfo: gets information about event by barcode (or QR-code) and event ID;
- AddVisitInfo: add visit information to the ticket by event ID and ticket barcode (or QR-code);
