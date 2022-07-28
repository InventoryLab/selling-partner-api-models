using IL.Library.Amazon.SPAPI.SharedRuntime;
using System.Net.Http;

namespace IL.Library.Amazon.SPAPI.ListingsRestrictions
{
    public partial class ListingsRestrictionsClient
    {
        private readonly SPAPIUserKeyPair _sPAPIUserKeyPair;
        private readonly ISPAPIConfiguration _configuration;
        private readonly ITokenManagement _tokenManagement;

        public ListingsRestrictionsClient(SPAPIUserKeyPair sPAPIUserKeyPair, HttpClient client, ISPAPIConfiguration configuration, ITokenManagement tokenManagement) : this(client,false)
        {
             _sPAPIUserKeyPair = sPAPIUserKeyPair;
            _configuration = configuration;
            _tokenManagement = tokenManagement;
        }

        public static IListingsRestrictionsClient Create(SPAPIUserKeyPair sPAPIUserKeyPair, HttpClient httpClient, ISPAPIConfiguration configuration, ITokenManagement tokenManagement)
        {
            return new ListingsRestrictionsClient(sPAPIUserKeyPair, httpClient, configuration, tokenManagement);
        }
    } 
}


