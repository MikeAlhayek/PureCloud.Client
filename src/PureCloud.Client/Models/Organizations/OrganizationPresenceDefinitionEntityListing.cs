using PureCloud.Client.Models.Organizations;

namespace PureCloud.Client.Models;

public sealed class OrganizationPresenceDefinitionEntityListing
{
    public long? Total { get; set; }
    public IEnumerable<OrganizationPresenceDefinition> Entities { get; set; }
    public string SelfUri { get; set; }
}
