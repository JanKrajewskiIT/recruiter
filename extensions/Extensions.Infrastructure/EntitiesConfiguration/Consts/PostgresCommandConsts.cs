namespace Extensions.Infrastructure.EntitiesConfiguration.Consts;

public static class PostgresCommandConsts
{
    public const string CurrentTimeStamp = "CURRENT_TIMESTAMP";
    public const string CurrentDate = "now()";
    public const string GuidDefaultValue = "gen_random_uuid()";
    public const string JsonDataType = "jsonb";
}
