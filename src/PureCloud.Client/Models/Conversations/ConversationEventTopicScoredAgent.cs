namespace PureCloud.Client.Models.Conversations;

public sealed class ConversationEventTopicScoredAgent
{
    /// <summary>
    /// A UriReference for a resource
    /// </summary>
    /// <value>A UriReference for a resource</value>
    public ConversationEventTopicUriReference Agent { get; set; }

    /// <summary>
    /// Agent&#39;s score for the current conversation, from 0 - 100, higher being better
    /// </summary>
    /// <value>Agent&#39;s score for the current conversation, from 0 - 100, higher being better</value>
    public long? Score { get; set; }
}
