using System.ComponentModel.DataAnnotations;

namespace Extensions.Api.Configuration;

public record KeycloakOptions(
     [Required] string Authority,
     [Required] string Realm,
     [Required] string ClientId,
     [Required] string ClientSecret )
{
    public KeycloakOptions() : this( null!, null!, null!, null! ) { }

    public string AuthorityUrl => $"{Authority}/realms/{Realm}";

    public Uri AuthorizationUrl => new( $"{AuthorityUrl}/protocol/openid-connect/auth" );
}