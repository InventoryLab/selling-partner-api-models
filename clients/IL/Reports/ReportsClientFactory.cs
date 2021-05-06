using IL.Library.Amazon.SPAPI.SharedRuntime;
using System.Net.Http;

namespace IL.Library.Amazon.SPAPI.Reports
{

    public partial class ReportsClient
    {
        private readonly ISPAPIConfiguration _configuration;
        private readonly IAccessTokenCredentials _accessTokenCredentials;

        public ReportsClient(HttpClient client, ISPAPIConfiguration configuration, IAccessTokenCredentials accessTokenCredentials) : this(client,false)
        {
            _configuration = configuration;
            _accessTokenCredentials = accessTokenCredentials;
        }

        public void PrepareRequest(HttpRequestMessage request)
        {
            AuthUtil.AddAuthorizationHeaders(new HttpRequestMessage().Headers, request, _configuration, _accessTokenCredentials);
        }

        public static IReportsClient Create(HttpClient httpClient, ISPAPIConfiguration configuration, IAccessTokenCredentials accessTokenCredentials)
        {
            return new ReportsClient(httpClient, configuration, accessTokenCredentials);
        }
    } 
}


