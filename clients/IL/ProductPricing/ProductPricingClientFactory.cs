using IL.Library.Amazon.SPAPI.SharedRuntime;
using System.Net.Http;

namespace IL.Library.Amazon.SPAPI.ProductPricing
{
    public partial class ProductPricingClient
    {
        private readonly SPAPIKeyPair _sPAPIKeyPair;
        private readonly ISPAPIConfiguration _configuration;
        private readonly ITokenManagement _tokenManagement;

        public ProductPricingClient(SPAPIKeyPair sPAPIKeyPair, HttpClient client, ISPAPIConfiguration configuration, ITokenManagement tokenManagement) : this(client,false)
        {
             _sPAPIKeyPair = sPAPIKeyPair;
            _configuration = configuration;
            _tokenManagement = tokenManagement;
        }

        public static IProductPricingClient Create(SPAPIKeyPair sPAPIKeyPair, HttpClient httpClient, ISPAPIConfiguration configuration, ITokenManagement tokenManagement)
        {
            return new ProductPricingClient(sPAPIKeyPair, httpClient, configuration, tokenManagement);
        }
    } 
}


