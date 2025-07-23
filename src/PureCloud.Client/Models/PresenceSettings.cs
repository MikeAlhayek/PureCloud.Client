namespace PureCloud.Client.Models;

public sealed class PresenceSettings
{
    public string Id { get; set; }
    public string Name { get; set; }
    public RestorePresenceSettings RestorePresenceSettings { get; set; }
    public string SelfUri { get; set; }
}
