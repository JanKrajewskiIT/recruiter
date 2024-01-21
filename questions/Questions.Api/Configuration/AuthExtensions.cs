using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using Swashbuckle.AspNetCore.SwaggerUI;
using System.Text;

namespace Questions.Api.Configuration;

internal static class AuthExtensions
{
    public const string KeycloakConfigurationKey = "Keycloak";

    private const string Audience = "account";
    private const string BearerFormat = "JWT";
    private const string Scheme = JwtBearerDefaults.AuthenticationScheme;

    public static IServiceCollection AddAuth( this IServiceCollection services, KeycloakOptions keycloakOptions )
    {
        services
            .AddAuthentication( Scheme )
            .AddJwtBearer( options =>
            {
                options.Authority = keycloakOptions.AuthorityUrl;
                options.Audience = Audience;
                options.RequireHttpsMetadata = false;
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = keycloakOptions.AuthorityUrl,
                    ValidAudience = Audience,
                    ClockSkew = TokenValidationParameters.DefaultClockSkew,
                    IssuerSigningKey = new SymmetricSecurityKey( Encoding.UTF8.GetBytes( keycloakOptions.ClientSecret ) )
                };
            } );


        services.AddAuthorization();

        return services;
    }

    public static SwaggerGenOptions AddSwaggerAuth( this SwaggerGenOptions options, KeycloakOptions keycloakOptions )
    {
        options.AddSecurityDefinition( Scheme, new OpenApiSecurityScheme
        {
            In = ParameterLocation.Header,
            Type = SecuritySchemeType.OAuth2,
            Scheme = Scheme,
            BearerFormat = BearerFormat,
            Reference = new OpenApiReference
            {
                Type = ReferenceType.SecurityScheme,
                Id = Scheme
            },
            Flows = new OpenApiOAuthFlows
            {
                Implicit = new OpenApiOAuthFlow
                {
                    AuthorizationUrl = keycloakOptions.AuthorizationUrl
                }
            },
        } );

        options.AddSecurityRequirement( new OpenApiSecurityRequirement
        {
            {
                new OpenApiSecurityScheme
                {
                    Reference = new OpenApiReference
                    {
                        Type = ReferenceType.SecurityScheme,
                        Id = Scheme,
                    },
                    In = ParameterLocation.Header,
                    Name = Scheme,
                    Scheme = Scheme,
                },
                Array.Empty<string>()
            }
        } );

        return options;
    }

    public static IApplicationBuilder UseAuth( this IApplicationBuilder app )
    {
        app.UseAuthentication();
        app.UseAuthorization();

        return app;
    }

    public static SwaggerUIOptions UseSwaggerAuth( this SwaggerUIOptions options, KeycloakOptions keycloakOptions )
    {
        options.OAuthClientId( keycloakOptions.ClientId );
        options.OAuthClientSecret( keycloakOptions.ClientSecret );
        options.OAuthRealm( keycloakOptions.Realm );

        return options;
    }
}
