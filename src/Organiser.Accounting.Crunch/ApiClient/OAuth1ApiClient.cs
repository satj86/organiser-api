using Microsoft.Extensions.Logging;
using System.Net.Http;
using System.Threading.Tasks;

namespace Organiser.Accounting.Crunch.ApiClient
{
    public class OAuth1ApiClient
    {
        private readonly OAuth1RequestFactory _oAuthRequestFactory;
        private readonly ILogger<OAuth1ApiClient> _logger;

        public OAuth1ApiClient(OAuth1RequestFactory oAuthRequestFactory, ILogger<OAuth1ApiClient> logger)
        {
            _oAuthRequestFactory = oAuthRequestFactory;
            _logger = logger;
        }

        public async Task<T> Get<T>(string resourceUrlPath) where T : class, new()
        {
            var oauthRequest = _oAuthRequestFactory.CreateOAuthRequest(resourceUrlPath, "GET");

            using (var httpClient = HttpClientFactory.GetOAuth1HttpClient(oauthRequest))
            {
                var rawData = await httpClient.GetAsync(oauthRequest.RequestUrl);
                return await rawData.Content.ReadAsAsync<T>();
            }
        }
    }
}
