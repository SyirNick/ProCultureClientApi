using Newtonsoft.Json;
using ProCultureApiClient.Contracts;
using RestSharp;

namespace ProCultureApiClient
{
    internal static class Extensions
    {
        internal async static Task<T> ProceedAsync<T>(this RestRequest request, Uri baseUrl)
        { 
            var response = await new RestClient(baseUrl).ExecuteAsync(request);

            if (response == null)
                throw new ProCultureException("Response was null");

            if (!response.IsSuccessful)
            {
                var message = JsonConvert.DeserializeObject<ProCultureErrorResponse>(response.Content ?? String.Empty)?.UserMessage ?? String.Empty;

                if (String.IsNullOrEmpty(message))
                {
                    var shortError = JsonConvert.DeserializeObject<ProCultureShortErrorResponse>(response.Content ?? String.Empty);
                    message = $"Error code: {shortError?.Code ?? String.Empty}, error message: {shortError?.Description ?? String.Empty}";
                }

                throw new ProCultureException(message);
            }

            var t = JsonConvert.DeserializeObject<T>(response.Content ?? String.Empty);

            if (t == null)
                throw new ProCultureException($"Failed to deserialize. Type: {typeof(T).Name}, object: {response.Content}");

            return t;
        }
    }
}
