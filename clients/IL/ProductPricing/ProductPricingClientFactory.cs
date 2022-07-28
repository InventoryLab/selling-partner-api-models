using IL.Library.Amazon.SPAPI.SharedRuntime;
using System.Net.Http;

namespace IL.Library.Amazon.SPAPI.ProductPricing
{
    public partial class ProductPricingClient
    {
        private readonly SPAPIUserKeyPair _sPAPIUserKeyPair;
        private readonly ISPAPIConfiguration _configuration;
        private readonly ITokenManagement _tokenManagement;

        public ProductPricingClient(SPAPIUserKeyPair sPAPIUserKeyPair, HttpClient client, ISPAPIConfiguration configuration, ITokenManagement tokenManagement) : this(client,false)
        {
             _sPAPIUserKeyPair = sPAPIUserKeyPair;
            _configuration = configuration;
            _tokenManagement = tokenManagement;
        }

        public static IProductPricingClient Create(SPAPIUserKeyPair sPAPIUserKeyPair, HttpClient httpClient, ISPAPIConfiguration configuration, ITokenManagement tokenManagement)
        {
            return new ProductPricingClient(sPAPIUserKeyPair, httpClient, configuration, tokenManagement);
        }
    } 
}


