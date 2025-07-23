using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class AuthzDivision
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public bool? HomeDivision { get; set; }
    public Dictionary<string, long?> ObjectCounts { get; set; }
    public string SelfUri { get; set; }
}
