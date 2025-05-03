namespace PureCloud.Client.Models.Users;

public sealed class UserSearchContext
{
    public HashSet<string> Expands { get; set; }

    public string IntegrationPresenceSource { get; set; }

    public string State { get; set; }
}
