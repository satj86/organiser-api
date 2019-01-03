using Microsoft.Extensions.Logging;
using OAuth;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Organiser.Accounting.Crunch
{
    public class CrunchApiClient
    {
        private readonly CrunchApiSettings _crunchApiSettings;
        private readonly ILogger<CrunchApiClient> _logger;

        public CrunchApiClient(CrunchApiSettings crunchApiSettings, ILogger<CrunchApiClient> logger)
        {
            _crunchApiSettings = crunchApiSettings;
            _logger = logger;
        }

        public async Task<T> Get<T>(string resourceUrlPath) where T : class, new ()
        {
            var oauthRequest = new OAuthRequest
            {
                Method = "GET",
                Type = OAuthRequestType.ProtectedResource,
                SignatureMethod = OAuthSignatureMethod.HmacSha1,
                ConsumerKey = _crunchApiSettings.ConsumerKey,
                ConsumerSecret = _crunchApiSettings.ConsumerSecret,
                Token = _crunchApiSettings.Token,
                TokenSecret = _crunchApiSettings.TokenSecret,
                RequestUrl = _crunchApiSettings.BaseUrl + resourceUrlPath,
            };

            var header = oauthRequest.GetAuthorizationHeader();

            _logger.LogWarning(header);

            using (var httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("OAuth", oauthRequest.GetAuthorizationHeader().Split(' ')[1]);
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var rawData = await httpClient.GetAsync(oauthRequest.RequestUrl);
                return await rawData.Content.ReadAsAsync<T>();
            }            
        }
    }
}
