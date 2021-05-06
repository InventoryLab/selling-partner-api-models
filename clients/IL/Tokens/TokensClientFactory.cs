using IL.Library.Amazon.SPAPI.SharedRuntime;
using System.Net.Http;

namespace IL.Library.Amazon.SPAPI.Tokens
{

    public partial class TokensClient
    {
        private readonly ISPAPIConfiguration _configuration;
        private readonly IAccessTokenCredentials _accessTokenCredentials;

        public TokensClient(HttpClient client, ISPAPIConfiguration configuration, IAccessTokenCredentials accessTokenCredentials) : this(client,false)
        {
            _configuration = configuration;
            _accessTokenCredentials = accessTokenCredentials;
        }

        public void PrepareRequest(HttpRequestMessage request)
        {
            AuthUtil.AddAuthorizationHeaders(new HttpRequestMessage().Headers, request, _configuration, _accessTokenCredentials);
        }

        public static ITokensClient Create(HttpClient httpClient, ISPAPIConfiguration configuration, IAccessTokenCredentials accessTokenCredentials)
        {
            return new TokensClient(httpClient, configuration, accessTokenCredentials);
        }
    } 
}


