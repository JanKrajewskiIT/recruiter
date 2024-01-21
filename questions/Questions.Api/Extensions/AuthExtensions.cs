using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using Swashbuckle.AspNetCore.SwaggerUI;

namespace Questions.Api.Extensions;

internal static class AuthExtensions
{
    private const string Realm = "recruiter";
    private const string Audience = "account"; 
    private const string ClientId = "recruiter";
    private const string AuthorityUrl = $"http://localhost:9002/realms/{Realm}";
    private const string AuthorizationUrl = $"{AuthorityUrl}/protocol/openid-connect/auth";
    private const string Scheme = JwtBearerDefaults.AuthenticationScheme;


    public static IServiceCollection AddAuth( this IServiceCollection services )
    {
        services
            .AddAuthentication( Scheme )
            .AddJwtBearer( options =>
            {
                options.Authority = AuthorityUrl;
                options.Audience = Audience;
                options.RequireHttpsMetadata = false;
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = false,
                    ValidIssuer = AuthorityUrl,
                    ValidAudience = Audience,
                    ClockSkew = TimeSpan.Zero,
                };
            } );


        services.AddAuthorization();

        return services;
    }

    public static SwaggerGenOptions AddSwaggerAuth( this SwaggerGenOptions options )
    {
        options.AddSecurityDefinition( Scheme, new OpenApiSecurityScheme
        {
            In = ParameterLocation.Header,
            Type = SecuritySchemeType.OAuth2,
            Scheme = Scheme,
            BearerFormat = "JWT",
            Reference = new OpenApiReference
            {
                Type = ReferenceType.SecurityScheme,
                Id = Scheme
            },
            Flows = new OpenApiOAuthFlows 
            { 
                Implicit = new OpenApiOAuthFlow 
                { 
                    AuthorizationUrl = new Uri( AuthorizationUrl )
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

    public static SwaggerUIOptions UseSwaggerAuth( this SwaggerUIOptions options )
    {
        options.OAuthClientId( ClientId );
        options.OAuthRealm( Realm );

        return options;
    }
}
