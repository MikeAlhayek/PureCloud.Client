namespace PureCloud.Client.Models;

public sealed class LicenseUser
{
    public string Id { get; set; }
    public IEnumerable<LicenseDefinition> Licenses { get; set; }
    public string SelfUri { get; set; }
}
