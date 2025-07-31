using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// NluFeedbackResponse
/// </summary>

public sealed class NluFeedbackResponse 
{
    /// <summary>
    /// Initializes a new instance of the <see cref="NluFeedbackResponse" /> class.
    /// </summary>
    /// <param name="Text">The feedback text..</param>
    /// <param name="Intents">Detected intent of the utterance.</param>
    /// <param name="Language">The language of the version to which feedback is linked, e.g. en-us, de-de.</param>

    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    public string Id { get; set; }

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
    /// The domain version of the feedback.
    /// </summary>
    /// <value>The domain version of the feedback.</value>
    public NluDomainVersion Version { get; set; }

    /// <summary>
    /// The date when the feedback was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date when the feedback was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateCreated { get; set; }

    /// <summary>
    /// The language of the version to which feedback is linked, e.g. en-us, de-de
    /// </summary>
    /// <value>The language of the version to which feedback is linked, e.g. en-us, de-de</value>
    public string Language { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }

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
    /// Returns true if NluFeedbackResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of NluFeedbackResponse to be compared</param>
    /// <returns>Boolean</returns>

    /// <summary>
    /// Gets the hash code
    /// </summary>
    /// <returns>Hash code</returns>
}
