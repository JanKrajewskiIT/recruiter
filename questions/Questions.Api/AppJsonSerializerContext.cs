using Questions.Application.Models;
using System.Text.Json.Serialization;

namespace Questions.Api;

[JsonSerializable( typeof( Todo[] ) )]
[JsonSerializable( typeof( Category[] ) )]
internal partial class AppJsonSerializerContext : JsonSerializerContext
{

}