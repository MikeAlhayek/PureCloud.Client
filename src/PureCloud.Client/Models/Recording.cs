using PureCloud.Client.Models.Users;

namespace PureCloud.Client.Models;

/// <summary>
/// Recording
/// </summary>
public sealed class Recording
{
    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets ConversationId
    /// </summary>
    public string ConversationId { get; set; }

    /// <summary>
    /// Gets or Sets Path
    /// </summary>
    public string Path { get; set; }

    /// <summary>
    /// The start time of the recording. Null when there is no playable media.
    /// </summary>
    public string StartTime { get; set; }

    /// <summary>
    /// The end time of the recording. Null when there is no playable media.
    /// </summary>
    public string EndTime { get; set; }

    /// <summary>
    /// The media type of the recording. This could be audio, chat, messaging, email, or screen.
    /// </summary>
    public string Media { get; set; }

    /// <summary>
    /// The media subtype of the recording.
    /// </summary>
    public RecordingMediaSubtype? MediaSubtype { get; set; }

    /// <summary>
    /// Gets or Sets MediaSubject
    /// </summary>
    public string MediaSubject { get; set; }

    /// <summary>
    /// Annotations that belong to the recording.
    /// </summary>
    public IEnumerable<Annotation> Annotations { get; set; }

    /// <summary>
    /// Represents a chat transcript
    /// </summary>
    public IEnumerable<ChatMessage> Transcript { get; set; }

    /// <summary>
    /// Represents an email transcript
    /// </summary>
    public IEnumerable<RecordingEmailMessage> EmailTranscript { get; set; }

    /// <summary>
    /// Represents a messaging transcript
    /// </summary>
    public IEnumerable<RecordingMessagingMessage> MessagingTranscript { get; set; }

    /// <summary>
    /// Represents the current file state for a recording. Examples: Uploading, Archived, etc
    /// </summary>
    public RecordingFileState? FileState { get; set; }

    /// <summary>
    /// The amount of time a restored recording will remain restored before being archived again. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    public DateTime? RestoreExpirationTime { get; set; }

    /// <summary>
    /// The different mediaUris for the recording. Null when there is no playable media.
    /// </summary>
    public Dictionary<string, MediaResult> MediaUris { get; set; }

    /// <summary>
    /// Gets or Sets EstimatedTranscodeTimeMs
    /// </summary>
    public long? EstimatedTranscodeTimeMs { get; set; }

    /// <summary>
    /// Gets or Sets ActualTranscodeTimeMs
    /// </summary>
    public long? ActualTranscodeTimeMs { get; set; }

    /// <summary>
    /// The date the recording will be archived. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    public DateTime? ArchiveDate { get; set; }

    /// <summary>
    /// The type of archive medium used. Example: CloudArchive
    /// </summary>
    public RecordingArchiveMedium? ArchiveMedium { get; set; }

    /// <summary>
    /// The date the recording will be deleted. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    public DateTime? DeleteDate { get; set; }

    /// <summary>
    /// The date the recording will be exported. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    public DateTime? ExportDate { get; set; }

    /// <summary>
    /// The date the recording was exported. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    public DateTime? ExportedDate { get; set; }

    /// <summary>
    /// Duration of transcoded media in milliseconds
    /// </summary>
    public int? OutputDurationMs { get; set; }

    /// <summary>
    /// Size of transcoded media in bytes. 0 if there is no transcoded media.
    /// </summary>
    public int? OutputSizeInBytes { get; set; }

    /// <summary>
    /// How many archive restorations the organization is allowed to have.
    /// </summary>
    public int? MaxAllowedRestorationsForOrg { get; set; }

    /// <summary>
    /// The remaining archive restorations the organization has.
    /// </summary>
    public int? RemainingRestorationsAllowedForOrg { get; set; }

    /// <summary>
    /// The session id represents an external resource id, such as email, call, chat, etc
    /// </summary>
    public string SessionId { get; set; }

    /// <summary>
    /// The users participating in the conversation
    /// </summary>
    public IEnumerable<User> Users { get; set; }

    /// <summary>
    /// Role of the file recording. It can be either customer_experience or adhoc.
    /// </summary>
    public RecordingFileRole? RecordingFileRole { get; set; }

    /// <summary>
    /// Status of a recording that cannot be returned because of an error
    /// </summary>
    public RecordingErrorStatus? RecordingErrorStatus { get; set; }

    /// <summary>
    /// The start time of the full recording, before any segment access restrictions are applied. Null when there is no playable media. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    public DateTime? OriginalRecordingStartTime { get; set; }

    /// <summary>
    /// The creation time of the recording. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    public DateTime? CreationTime { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    public string SelfUri { get; set; }
}