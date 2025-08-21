namespace PureCloud.Client.Models;

public sealed class OrgWhitelistSettings
{
    public bool? EnableWhitelist { get; set; }
    public IEnumerable<string> DomainWhitelist { get; set; }
}
