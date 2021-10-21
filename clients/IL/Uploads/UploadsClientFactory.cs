using IL.Library.Amazon.SPAPI.SharedRuntime;
using System.Net.Http;

namespace IL.Library.Amazon.SPAPI.Uploads
{
    public partial class UploadsClient
    {
        private readonly SPAPIKeyPair _sPAPIKeyPair;
        private readonly ISPAPIConfiguration _configuration;
        private readonly ITokenManagement _tokenManagement;

        public UploadsClient(SPAPIKeyPair sPAPIKeyPair, HttpClient client, ISPAPIConfiguration configuration, ITokenManagement tokenManagement) : this(client,false)
        {
             _sPAPIKeyPair = sPAPIKeyPair;
            _configuration = configuration;
            _tokenManagement = tokenManagement;
        }

        public static IUploadsClient Create(SPAPIKeyPair sPAPIKeyPair, HttpClient httpClient, ISPAPIConfiguration configuration, ITokenManagement tokenManagement)
        {
            return new UploadsClient(sPAPIKeyPair, httpClient, configuration, tokenManagement);
        }
    } 
}


