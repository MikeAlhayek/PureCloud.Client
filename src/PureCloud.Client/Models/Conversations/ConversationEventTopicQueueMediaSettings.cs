namespace PureCloud.Client.Models.Conversations;

/// <summary>
/// Represents the queue setting for this media.
/// </summary>

public sealed class ConversationEventTopicQueueMediaSettings
{
    /// <summary>
    /// Specifies how long the agent has to answer an interaction before being marked as not responding.
    /// </summary>
    /// <value>Specifies how long the agent has to answer an interaction before being marked as not responding.</value>
    public long? AlertingTimeoutSeconds { get; set; }

    /// <summary>
    /// Specifies the duration of the alerting sound to be played for auto answered interactions.
    /// </summary>
    /// <value>Specifies the duration of the alerting sound to be played for auto answered interactions.</value>
    public double? AutoAnswerAlertToneSeconds { get; set; }

    /// <summary>
    /// Specifies the duration of the alerting sound to be played for manually answered interactions
    /// </summary>
    /// <value>Specifies the duration of the alerting sound to be played for manually answered interactions</value>
    public double? ManualAnswerAlertToneSeconds { get; set; }

    /// <summary>
    /// Flag to indicate if auto answer is enabled for the given media type or media subtype.
    /// </summary>
    /// <value>Flag to indicate if auto answer is enabled for the given media type or media subtype.</value>
    public bool? EnableAutoAnswer { get; set; }
}
