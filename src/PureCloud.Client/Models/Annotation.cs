using PureCloud.Client.Models.Users;

namespace PureCloud.Client.Models;

/// <summary>
/// Annotation
/// </summary>
public sealed class Annotation
{
    /// <summary>
    /// Reason for a pause annotation. Valid values: Hold,SecurePause,FlowOrQueue,Pause
    /// </summary>
    public AnnotationReason? Reason { get; set; }

    /// <summary>
    /// Annotation id. All pause annotations on a recording will share an ID value, bookmark annotations will have unique IDs, and hold annotations will have randomly generated UUIDs (i.e. the ID will change at each request).
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    public string Type { get; set; }

    /// <summary>
    /// Offset of annotation in milliseconds.
    /// </summary>
    public long? Location { get; set; }

    /// <summary>
    /// Duration of annotation in milliseconds.
    /// </summary>
    public long? DurationMs { get; set; }

    /// <summary>
    /// Offset of annotation (milliseconds) from start of recording (after removing the cumulative duration of all pauses).
    /// </summary>
    public long? AbsoluteLocation { get; set; }

    /// <summary>
    /// Duration of annotation (milliseconds).
    /// </summary>
    public long? AbsoluteDurationMs { get; set; }

    /// <summary>
    /// Offset of annotation (milliseconds) from start of recording, adjusted for any recording cuts
    /// </summary>
    public long? RecordingLocation { get; set; }

    /// <summary>
    /// Duration of annotation (milliseconds), adjusted for any recording cuts.
    /// </summary>
    public long? RecordingDurationMs { get; set; }

    /// <summary>
    /// User that created this annotation (if any).
    /// </summary>
    public User User { get; set; }

    /// <summary>
    /// Text of annotation. Maximum character limit is 500.
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// List of annotations
    /// </summary>
    public IEnumerable<Annotation> Annotations { get; set; }

    /// <summary>
    /// Offset of annotation (milliseconds) from start of the recording before removing the cumulative duration of all pauses before this annotation
    /// </summary>
    public long? AnnotationLocation { get; set; }

    /// <summary>
    /// Offset of annotation (milliseconds) from start of recording without removing the cumulative duration of all pauses before this annotation
    /// </summary>
    public long? RealTimeLocation { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    public string SelfUri { get; set; }
}