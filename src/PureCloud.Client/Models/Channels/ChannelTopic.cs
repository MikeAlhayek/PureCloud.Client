namespace PureCloud.Client.Models;

public sealed class ChannelTopic
{
    /// <summary>
    /// Gets or Sets State
    /// </summary>
    public ChannelTopicState? State { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets RejectionReason
    /// </summary>
    public string RejectionReason { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; private set; }
}
