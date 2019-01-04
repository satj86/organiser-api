using OAuth;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Organiser.Accounting.Crunch.ApiClient
{
    public class HttpClientFactory
    {
        public static HttpClient GetOAuth1HttpClient(OAuthRequest oAuthRequest)
        {
            var httpClient = new HttpClient();

            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("OAuth", oAuthRequest.GetAuthorizationHeader().Split(' ')[1]);
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            return httpClient;
        }
    }

}
