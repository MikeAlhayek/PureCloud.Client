namespace PureCloud.Client.Models;

public sealed class MessageMediaSettings
{
    /// <summary>
    /// Indicates if auto-answer is enabled for the given media type or subtype (default is false).  Subtype settings take precedence over media type settings.
    /// </summary>
    /// <value>Indicates if auto-answer is enabled for the given media type or subtype (default is false).  Subtype settings take precedence over media type settings.</value>
    public bool? EnableAutoAnswer { get; set; }

    /// <summary>
    /// The alerting timeout for the media type, in seconds
    /// </summary>
    /// <value>The alerting timeout for the media type, in seconds</value>
    public int? AlertingTimeoutSeconds { get; set; }

    /// <summary>
    /// The targeted service level for the media type
    /// </summary>
    /// <value>The targeted service level for the media type</value>
    public ServiceLevel ServiceLevel { get; set; }

    /// <summary>
    /// How long to play the alerting tone for an auto-answer interaction
    /// </summary>
    /// <value>How long to play the alerting tone for an auto-answer interaction</value>
    public double? AutoAnswerAlertToneSeconds { get; set; }

    /// <summary>
    /// How long to play the alerting tone for a manual-answer interaction
    /// </summary>
    /// <value>How long to play the alerting tone for a manual-answer interaction</value>
    public double? ManualAnswerAlertToneSeconds { get; set; }

    /// <summary>
    /// Map of media subtype to media subtype specific settings.
    /// </summary>
    /// <value>Map of media subtype to media subtype specific settings.</value>
    public Dictionary<string, BaseMediaSettings> SubTypeSettings { get; set; }
}
