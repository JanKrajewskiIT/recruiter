using Organizer.Domain.Enums;

namespace Organizer.Domain.Entities;

public class KeyValueListEntity
{
    public required DictionaryKey Key { get; init; }

    public IList<string> Values { get; init; } = [];
}
