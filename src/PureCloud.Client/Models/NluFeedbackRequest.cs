namespace PureCloud.Client.Models;

/// <summary>
/// NluFeedbackRequest
/// </summary>
public sealed class NluFeedbackRequest
{
    /// <summary>
    /// NluFeedbackRequest
    /// </summary>
    public string? Text { get; set; }

    /// <summary>
    /// Detected intent of the utterance
    /// </summary>
    public IEnumerable<IntentFeedback> Intents { get; set; }

    /// <summary>
    /// The domain version ID of the feedback.
    /// </summary>
    public string? VersionId { get; set; }

    /// <summary>
    /// The language of the version to which feedback is linked, e.g. en-us, de-de
    /// </summary>
    public string? Language { get; set; }
}
