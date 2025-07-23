namespace PureCloud.Client.Models;

public sealed class Trigger
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string TopicName { get; set; }
    public TriggerTarget Target { get; set; }
    public long? Version { get; set; }
    public bool? Enabled { get; set; }
    public IEnumerable<MatchCriteria> MatchCriteria { get; set; }
    public int? EventTTLSeconds { get; set; }
    public int? DelayBySeconds { get; set; }
    public string Description { get; set; }
    public string SelfUri { get; set; }
}
