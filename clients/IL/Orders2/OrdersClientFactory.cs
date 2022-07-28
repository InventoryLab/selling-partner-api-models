using IL.Library.Amazon.SPAPI.SharedRuntime;
using System.Net.Http;

namespace IL.Library.Amazon.SPAPI.Orders
{
    public partial class OrdersClient
    {
        private readonly SPAPIKeyPair _sPAPIKeyPair;
        private readonly ISPAPIConfiguration _configuration;
        private readonly ITokenManagement _tokenManagement;

        public OrdersClient(SPAPIKeyPair sPAPIKeyPair, HttpClient client, ISPAPIConfiguration configuration, ITokenManagement tokenManagement) : this(client,false)
        {
             _sPAPIKeyPair = sPAPIKeyPair;
            _configuration = configuration;
            _tokenManagement = tokenManagement;
        }

        public static IOrdersClient Create(SPAPIKeyPair sPAPIKeyPair, HttpClient httpClient, ISPAPIConfiguration configuration, ITokenManagement tokenManagement)
        {
            return new OrdersClient(sPAPIKeyPair, httpClient, configuration, tokenManagement);
        }
    } 
}


