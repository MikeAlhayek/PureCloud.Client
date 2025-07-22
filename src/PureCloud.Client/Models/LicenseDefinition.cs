namespace PureCloud.Client.Models;

public sealed class LicenseDefinition
{
    public string Id { get; set; }
    public string Description { get; set; }
    public Permissions Permissions { get; set; }
    public IEnumerable<AddressableLicenseDefinition> Prerequisites { get; set; }
    public IEnumerable<LicenseDefinition> Comprises { get; set; }
    public string SelfUri { get; set; }
}
