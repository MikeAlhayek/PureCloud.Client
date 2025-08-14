namespace PureCloud.Client.Models;

public sealed class UpdateTriggerRequest
{
    public long? Version { get; set; }
    public bool? Enabled { get; set; }
    public TriggerTarget Target { get; set; }
    public IEnumerable<MatchCriteria> MatchCriteria { get; set; }
    public string Name { get; set; }
    public string TopicName { get; set; }
    public int? EventTTLSeconds { get; set; }
    public int? DelayBySeconds { get; set; }
    public string Description { get; set; }
}
