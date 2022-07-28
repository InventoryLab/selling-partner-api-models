using IL.Library.Amazon.SPAPI.SharedRuntime;
using System.Net.Http;

namespace IL.Library.Amazon.SPAPI.Orders
{
    public partial class OrdersClient
    {
        private readonly SPAPIUserKeyPair _sPAPIUserKeyPair;
        private readonly ISPAPIConfiguration _configuration;
        private readonly ITokenManagement _tokenManagement;

        public OrdersClient(SPAPIUserKeyPair sPAPIUserKeyPair, HttpClient client, ISPAPIConfiguration configuration, ITokenManagement tokenManagement) : this(client,false)
        {
             _sPAPIUserKeyPair = sPAPIUserKeyPair;
            _configuration = configuration;
            _tokenManagement = tokenManagement;
        }

        public static IOrdersClient Create(SPAPIUserKeyPair sPAPIUserKeyPair, HttpClient httpClient, ISPAPIConfiguration configuration, ITokenManagement tokenManagement)
        {
            return new OrdersClient(sPAPIUserKeyPair, httpClient, configuration, tokenManagement);
        }
    } 
}


