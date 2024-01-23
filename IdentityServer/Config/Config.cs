using IdentityServer4.Models;
using System.Collections.Generic;

namespace IdentityServer.Config
{
    public class Config
    {
        public static IEnumerable<ApiScope> GetApiScopes()
        {
            return new List<ApiScope>
            {
                new ApiScope("api1", "My API")
            };

        }


        public static IEnumerable<ApiResource> GetApiResources()
        {
            return new List<ApiResource>
        {

            new ApiResource("api1", "My API")
        };
        }

        public static IEnumerable<Client> GetClient()
        {
            return new List<Client>
            {
                new Client
                {
                    ClientId = "client",

                    AllowedGrantTypes = GrantTypes.ClientCredentials,

                    ClientSecrets =
                    {
                        new Secret("secret".Sha256())
                    },

                    AllowedScopes = { "api1" },

                    AccessTokenLifetime = 7200
                }
            };
        }

        public static IEnumerable<IdentityResource> GetIdentityResources()
        {
            return new List<IdentityResource>
    {
        new IdentityResources.OpenId(),
        new IdentityResources.Profile(),
    };
        }

    }
}
