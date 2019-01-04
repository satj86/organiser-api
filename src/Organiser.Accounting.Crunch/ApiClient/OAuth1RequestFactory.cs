using OAuth;

namespace Organiser.Accounting.Crunch.ApiClient
{
    public class OAuth1RequestFactory
    {
        private readonly OAuth1Settings _oAuthSettings;

        public OAuth1RequestFactory(OAuth1Settings oAuthSettings)
        {
            _oAuthSettings = oAuthSettings;
        }

        public OAuthRequest CreateOAuthRequest(string resourceUrlPath, string method)
        {
            var oauthRequest = new OAuthRequest
            {
                Method = method.Trim().ToUpperInvariant(),
                Type = OAuthRequestType.ProtectedResource,
                SignatureMethod = OAuthSignatureMethod.HmacSha1,
                ConsumerKey = _oAuthSettings.ConsumerKey,
                ConsumerSecret = _oAuthSettings.ConsumerSecret,
                Token = _oAuthSettings.Token,
                TokenSecret = _oAuthSettings.TokenSecret,
                RequestUrl = _oAuthSettings.BaseUrl + resourceUrlPath,
            };

            return oauthRequest;
        }
    }
}
