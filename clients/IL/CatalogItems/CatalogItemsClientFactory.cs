using IL.Library.Amazon.SPAPI.SharedRuntime;
using System.Net.Http;

namespace IL.Library.Amazon.SPAPI.CatalogItems
{
    public partial class CatalogItemsClient
    {
        private readonly ISPAPIConfiguration _configuration;
        private readonly ITokenManagement _tokenManagement;

        public CatalogItemsClient(HttpClient client, ISPAPIConfiguration configuration, ITokenManagement tokenManagement) : this(client,false)
        {
            _configuration = configuration;
            _tokenManagement = tokenManagement;
        }
    } 
}


