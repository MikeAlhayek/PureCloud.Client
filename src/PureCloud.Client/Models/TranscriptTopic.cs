namespace PureCloud.Client.Models;

/// <summary>
/// TranscriptTopic
/// </summary>

public sealed class TranscriptTopic
{
    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    public string Id { get; set; }

    /// <summary>
    /// The name of the object.
    /// </summary>
    /// <value>The name of the object.</value>
    public string Name { get; set; }

    /// <summary>
    /// The phrase which detected the topic. 
    /// </summary>
    /// <value>The phrase which detected the topic. </value>
    public string TopicPhrase { get; set; }

    /// <summary>
    /// The transcript phrase which detected the topic.
    /// </summary>
    /// <value>The transcript phrase which detected the topic.</value>
    public string TranscriptPhrase { get; set; }

    /// <summary>
    /// The detection confidence of the topic.
    /// </summary>
    /// <value>The detection confidence of the topic.</value>
    public int? Confidence { get; set; }

    /// <summary>
    /// The start time of the topic phrase.
    /// </summary>
    /// <value>The start time of the topic phrase.</value>
    public long? StartTimeMilliseconds { get; set; }

    /// <summary>
    /// Gets or Sets Duration
    /// </summary>
    public TopicDuration Duration { get; set; }

    /// <summary>
    /// Location of the phrase
    /// </summary>
    /// <value>Location of the phrase</value>
    public TopicOffset Offset { get; set; }

    /// <summary>
    /// Location of the phrase in the recording in milliseconds
    /// </summary>
    /// <value>Location of the phrase in the recording in milliseconds</value>
    public long? RecordingLocation { get; set; }
}
