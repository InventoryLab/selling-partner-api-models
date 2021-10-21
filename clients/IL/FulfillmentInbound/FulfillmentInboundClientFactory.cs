using IL.Library.Amazon.SPAPI.SharedRuntime;
using System.Net.Http;

namespace IL.Library.Amazon.SPAPI.FulfillmentInbound
{
    public partial class FulfillmentInboundClient
    {
        private readonly SPAPIKeyPair _sPAPIKeyPair;
        private readonly ISPAPIConfiguration _configuration;
        private readonly ITokenManagement _tokenManagement;

        public FulfillmentInboundClient(SPAPIKeyPair sPAPIKeyPair, HttpClient client, ISPAPIConfiguration configuration, ITokenManagement tokenManagement) : this(client,false)
        {
             _sPAPIKeyPair = sPAPIKeyPair;
            _configuration = configuration;
            _tokenManagement = tokenManagement;
        }

        public static IFulfillmentInboundClient Create(SPAPIKeyPair sPAPIKeyPair, HttpClient httpClient, ISPAPIConfiguration configuration, ITokenManagement tokenManagement)
        {
            return new FulfillmentInboundClient(sPAPIKeyPair, httpClient, configuration, tokenManagement);
        }
    } 
}


