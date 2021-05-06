using IL.Library.Amazon.SPAPI.SharedRuntime;
using System.Net.Http;

namespace IL.Library.Amazon.SPAPI.Finances
{

    public partial class FinancesClient
    {
        private readonly ISPAPIConfiguration _configuration;
        private readonly IAccessTokenCredentials _accessTokenCredentials;

        public FinancesClient(HttpClient client, ISPAPIConfiguration configuration, IAccessTokenCredentials accessTokenCredentials) : this(client,false)
        {
            _configuration = configuration;
            _accessTokenCredentials = accessTokenCredentials;
        }

        public void PrepareRequest(HttpRequestMessage request)
        {
            AuthUtil.AddAuthorizationHeaders(new HttpRequestMessage().Headers, request, _configuration, _accessTokenCredentials);
        }

        public static IFinancesClient Create(HttpClient httpClient, ISPAPIConfiguration configuration, IAccessTokenCredentials accessTokenCredentials)
        {
            return new FinancesClient(httpClient, configuration, accessTokenCredentials);
        }
    } 
}


