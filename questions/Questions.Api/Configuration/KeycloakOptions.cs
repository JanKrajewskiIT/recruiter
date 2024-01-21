using Microsoft.AspNetCore.Authentication.JwtBearer;
using System.ComponentModel.DataAnnotations;

namespace Questions.Api.Configuration;

internal record KeycloakOptions(
     [Required] string Authority,
     [Required] string Realm,
     [Required] string ClientId,
     [Required] string ClientSecret)
{
    public string AuthorityUrl => $"{Authority}/realms/{Realm}";

    public Uri AuthorizationUrl => new($"{AuthorityUrl}/protocol/openid-connect/auth");
}