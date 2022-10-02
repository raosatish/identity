// Copyright (c) Duende Software. All rights reserved.
// See LICENSE in the project root for license information.


using IdentityModel;
using System.Security.Claims;
using System.Text.Json;
using Duende.IdentityServer;
using Duende.IdentityServer.Test;

namespace identity;

public class TestUsers
{
    public static List<TestUser> Users
    {
        get
        {
            var address = new
            {
                street_address = "One Hacker Way",
                locality = "Heidelberg",
                postal_code = 69118,
                country = "Germany"
            };
                
            return new List<TestUser>
            {
                new TestUser
                {
                    SubjectId = "1",
                    Username = "srao",
                    Password = "password",
                    Claims =
                    {
                        new Claim(JwtClaimTypes.Name, "Satish Rao"),
                        new Claim(JwtClaimTypes.GivenName, "Satish"),
                        new Claim(JwtClaimTypes.FamilyName, "Rao"),
                        new Claim(JwtClaimTypes.Email, "raosatish@yahoo.com"),
                        new Claim(JwtClaimTypes.EmailVerified, "true", ClaimValueTypes.Boolean),
                        new Claim(JwtClaimTypes.Address, JsonSerializer.Serialize(address), IdentityServerConstants.ClaimValueTypes.Json)
                    }
                },
                new TestUser
                {
                    SubjectId = "2",
                    Username = "hrao",
                    Password = "password",
                    Claims =
                    {
                        new Claim(JwtClaimTypes.Name, "Hemalatha Rao"),
                        new Claim(JwtClaimTypes.GivenName, "Hemalatha"),
                        new Claim(JwtClaimTypes.FamilyName, "Rao"),
                        new Claim(JwtClaimTypes.Email, "raohemalatha@yahoo.com"),
                        new Claim(JwtClaimTypes.EmailVerified, "true", ClaimValueTypes.Boolean),
                        new Claim(JwtClaimTypes.Address, JsonSerializer.Serialize(address), IdentityServerConstants.ClaimValueTypes.Json)
                    }
                }
            };
        }
    }
}