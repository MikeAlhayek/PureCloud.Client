namespace PureCloud.Client.Models;

public sealed class EmbeddedIntegration
{
    public bool? EnableWhitelist { get; set; }
    public IEnumerable<string> DomainWhitelist { get; set; }
}
