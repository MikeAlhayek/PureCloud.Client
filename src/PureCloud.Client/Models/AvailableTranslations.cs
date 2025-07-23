namespace PureCloud.Client.Models;

public sealed class AvailableTranslations
{
    public IEnumerable<string> OrgSpecific { get; set; }

    public IEnumerable<string> Builtin { get; set; }
}
