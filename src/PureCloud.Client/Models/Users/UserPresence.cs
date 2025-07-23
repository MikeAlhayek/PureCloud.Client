namespace PureCloud.Client.Models.Users;

public sealed class UserPresence
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Source { get; set; }
    public string SourceId { get; set; }
    public bool? Primary { get; set; }
    public PresenceDefinition PresenceDefinition { get; set; }
    public string Message { get; set; }
    public DateTime? ModifiedDate { get; set; }
    public string SelfUri { get; set; }
}
