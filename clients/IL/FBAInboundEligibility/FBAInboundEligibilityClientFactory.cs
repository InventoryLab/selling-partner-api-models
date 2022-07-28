using IL.Library.Amazon.SPAPI.SharedRuntime;
using System.Net.Http;

namespace IL.Library.Amazon.SPAPI.FBAInboundEligibility
{
    public partial class FBAInboundEligibilityClient
    {
        private readonly ISPAPIConfiguration _configuration;
        private readonly ITokenManagement _tokenManagement;

        public FBAInboundEligibilityClient(HttpClient client, ISPAPIConfiguration configuration, ITokenManagement tokenManagement) : this(client,false)
        {
            _configuration = configuration;
            _tokenManagement = tokenManagement;
        }
    } 
}


