namespace PGPlatform.ManagementPortal.Infrastructure.Database.Consts;

internal static class PostgresCommandConsts
{
    internal const string CurrentTimeStamp = "CURRENT_TIMESTAMP";
    internal static string CurrentDate = "now()";
    internal const string GuidDefaultValue = "gen_random_uuid()";
    internal const string JsonDataType = "jsonb";
}
