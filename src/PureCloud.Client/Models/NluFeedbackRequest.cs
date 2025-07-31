using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// NluFeedbackRequest
/// </summary>

public sealed class NluFeedbackRequest 
{

    /// <summary>
    /// Initializes a new instance of the <see cref="NluFeedbackRequest" /> class.
    /// </summary>
    /// Initializes a new instance of the <see cref="NluFeedbackRequest" /> class.
    /// </summary>
    /// <param name="Text">The feedback text. (required).</param>
    /// <param name="Intents">Detected intent of the utterance (required).</param>
    /// <param name="VersionId">The domain version ID of the feedback. (required).</param>
    /// <param name="Language">The language of the version to which feedback is linked, e.g. en-us, de-de.</param>

    /// <summary>
    /// The feedback text.
    /// </summary>
    /// <value>The feedback text.</value>
    public string Text { get; set; }

    /// <summary>
    /// Detected intent of the utterance
    /// </summary>
    /// <value>Detected intent of the utterance</value>
    public IEnumerable<IntentFeedback> Intents { get; set; }

    /// <summary>
    /// The domain version ID of the feedback.
    /// </summary>
    /// <value>The domain version ID of the feedback.</value>
    public string VersionId { get; set; }

    /// <summary>
    /// The language of the version to which feedback is linked, e.g. en-us, de-de
    /// </summary>
    /// <value>The language of the version to which feedback is linked, e.g. en-us, de-de</value>
    public string Language { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>

    /// <summary>
    /// Returns true if objects are equal
    /// </summary>
    /// <param name="obj">Object to be compared</param>
    /// <returns>Boolean</returns>

    /// <summary>
    /// Returns true if NluFeedbackRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of NluFeedbackRequest to be compared</param>
    /// <returns>Boolean</returns>

    /// <summary>
    /// Gets the hash code
    /// </summary>
    /// <returns>Hash code</returns>
}
