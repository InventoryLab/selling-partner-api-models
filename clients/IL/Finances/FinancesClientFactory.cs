using IL.Library.Amazon.SPAPI.SharedRuntime;
using System.Net.Http;

namespace IL.Library.Amazon.SPAPI.Finances
{
    public partial class FinancesClient
    {
        private readonly SPAPIUserKeyPair _sPAPIUserKeyPair;
        private readonly ISPAPIConfiguration _configuration;
        private readonly ITokenManagement _tokenManagement;

        public FinancesClient(SPAPIUserKeyPair sPAPIUserKeyPair, HttpClient client, ISPAPIConfiguration configuration, ITokenManagement tokenManagement) : this(client,false)
        {
             _sPAPIUserKeyPair = sPAPIUserKeyPair;
            _configuration = configuration;
            _tokenManagement = tokenManagement;
        }

        public static IFinancesClient Create(SPAPIUserKeyPair sPAPIUserKeyPair, HttpClient httpClient, ISPAPIConfiguration configuration, ITokenManagement tokenManagement)
        {
            return new FinancesClient(sPAPIUserKeyPair, httpClient, configuration, tokenManagement);
        }
    } 
}


