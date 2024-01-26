using Questions.Domain.Enums;

namespace Questions.Domain.Entities;

public class KeyValueListEntity
{
    public required DictionaryKey Key { get; init; }

    public IList<string> Values { get; init; } = [];
}
