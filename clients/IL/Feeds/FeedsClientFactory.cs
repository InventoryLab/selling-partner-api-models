using IL.Library.Amazon.SPAPI.SharedRuntime;
using System.Net.Http;

namespace IL.Library.Amazon.SPAPI.Feeds
{
    public partial class FeedsClient
    {
        private readonly SPAPIUserKeyPair _sPAPIUserKeyPair;
        private readonly ISPAPIConfiguration _configuration;
        private readonly ITokenManagement _tokenManagement;

        public FeedsClient(SPAPIUserKeyPair sPAPIUserKeyPair, HttpClient client, ISPAPIConfiguration configuration, ITokenManagement tokenManagement) : this(client,false)
        {
             _sPAPIUserKeyPair = sPAPIUserKeyPair;
            _configuration = configuration;
            _tokenManagement = tokenManagement;
        }

        public static IFeedsClient Create(SPAPIUserKeyPair sPAPIUserKeyPair, HttpClient httpClient, ISPAPIConfiguration configuration, ITokenManagement tokenManagement)
        {
            return new FeedsClient(sPAPIUserKeyPair, httpClient, configuration, tokenManagement);
        }
    } 
}


