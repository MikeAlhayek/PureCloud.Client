namespace PureCloud.Client.Models;

public sealed class Conversation
{
    public string? Id { get; set; }
    public string? Name { get; set; }
    public int? Priority { get; set; }
    public string? State { get; set; }
    public string? SelfUri { get; set; }
}