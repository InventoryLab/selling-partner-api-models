using IL.Library.Amazon.SPAPI.SharedRuntime;
using System.Net.Http;

namespace IL.Library.Amazon.SPAPI.Reports
{
    public partial class ReportsClient
    {
        private readonly SPAPIKeyPair _sPAPIKeyPair;
        private readonly ISPAPIConfiguration _configuration;
        private readonly ITokenManagement _tokenManagement;

        public ReportsClient(SPAPIKeyPair sPAPIKeyPair, HttpClient client, ISPAPIConfiguration configuration, ITokenManagement tokenManagement) : this(client,false)
        {
             _sPAPIKeyPair = sPAPIKeyPair;
            _configuration = configuration;
            _tokenManagement = tokenManagement;
        }

        public static IReportsClient Create(SPAPIKeyPair sPAPIKeyPair, HttpClient httpClient, ISPAPIConfiguration configuration, ITokenManagement tokenManagement)
        {
            return new ReportsClient(sPAPIKeyPair, httpClient, configuration, tokenManagement);
        }
    } 
}


