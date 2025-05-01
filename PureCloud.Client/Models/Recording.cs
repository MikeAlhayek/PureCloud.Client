using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Recording
/// </summary>
[DataContract]
public partial class Recording : IEquatable<Recording>
{
    /// <summary>
    /// The media subtype of the recording.
    /// </summary>
    /// <value>The media subtype of the recording.</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum MediaSubtypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Trunk for "Trunk"
        /// </summary>
        [EnumMember(Value = "Trunk")]
        Trunk,

        /// <summary>
        /// Enum Station for "Station"
        /// </summary>
        [EnumMember(Value = "Station")]
        Station,

        /// <summary>
        /// Enum Consult for "Consult"
        /// </summary>
        [EnumMember(Value = "Consult")]
        Consult,

        /// <summary>
        /// Enum Screen for "Screen"
        /// </summary>
        [EnumMember(Value = "Screen")]
        Screen
    }
    /// <summary>
    /// Represents the current file state for a recording. Examples: Uploading, Archived, etc
    /// </summary>
    /// <value>Represents the current file state for a recording. Examples: Uploading, Archived, etc</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum FileStateEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Archived for "ARCHIVED"
        /// </summary>
        [EnumMember(Value = "ARCHIVED")]
        Archived,

        /// <summary>
        /// Enum Available for "AVAILABLE"
        /// </summary>
        [EnumMember(Value = "AVAILABLE")]
        Available,

        /// <summary>
        /// Enum Deleted for "DELETED"
        /// </summary>
        [EnumMember(Value = "DELETED")]
        Deleted,

        /// <summary>
        /// Enum Restored for "RESTORED"
        /// </summary>
        [EnumMember(Value = "RESTORED")]
        Restored,

        /// <summary>
        /// Enum Restoring for "RESTORING"
        /// </summary>
        [EnumMember(Value = "RESTORING")]
        Restoring,

        /// <summary>
        /// Enum Uploading for "UPLOADING"
        /// </summary>
        [EnumMember(Value = "UPLOADING")]
        Uploading,

        /// <summary>
        /// Enum Error for "ERROR"
        /// </summary>
        [EnumMember(Value = "ERROR")]
        Error
    }
    /// <summary>
    /// The type of archive medium used. Example: CloudArchive
    /// </summary>
    /// <value>The type of archive medium used. Example: CloudArchive</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ArchiveMediumEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Cloudarchive for "CLOUDARCHIVE"
        /// </summary>
        [EnumMember(Value = "CLOUDARCHIVE")]
        Cloudarchive
    }
    /// <summary>
    /// Role of the file recording. It can be either customer_experience or adhoc.
    /// </summary>
    /// <value>Role of the file recording. It can be either customer_experience or adhoc.</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RecordingFileRoleEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum CustomerExperience for "CUSTOMER_EXPERIENCE"
        /// </summary>
        [EnumMember(Value = "CUSTOMER_EXPERIENCE")]
        CustomerExperience,

        /// <summary>
        /// Enum Adhoc for "ADHOC"
        /// </summary>
        [EnumMember(Value = "ADHOC")]
        Adhoc
    }
    /// <summary>
    /// Status of a recording that cannot be returned because of an error
    /// </summary>
    /// <value>Status of a recording that cannot be returned because of an error</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RecordingErrorStatusEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum EmailTranscriptTooLarge for "EMAIL_TRANSCRIPT_TOO_LARGE"
        /// </summary>
        [EnumMember(Value = "EMAIL_TRANSCRIPT_TOO_LARGE")]
        EmailTranscriptTooLarge
    }
    /// <summary>
    /// The media subtype of the recording.
    /// </summary>
    /// <value>The media subtype of the recording.</value>
    [DataMember(Name = "mediaSubtype", EmitDefaultValue = false)]
    public MediaSubtypeEnum? MediaSubtype { get; set; }
    /// <summary>
    /// Represents the current file state for a recording. Examples: Uploading, Archived, etc
    /// </summary>
    /// <value>Represents the current file state for a recording. Examples: Uploading, Archived, etc</value>
    [DataMember(Name = "fileState", EmitDefaultValue = false)]
    public FileStateEnum? FileState { get; set; }
    /// <summary>
    /// The type of archive medium used. Example: CloudArchive
    /// </summary>
    /// <value>The type of archive medium used. Example: CloudArchive</value>
    [DataMember(Name = "archiveMedium", EmitDefaultValue = false)]
    public ArchiveMediumEnum? ArchiveMedium { get; set; }
    /// <summary>
    /// Role of the file recording. It can be either customer_experience or adhoc.
    /// </summary>
    /// <value>Role of the file recording. It can be either customer_experience or adhoc.</value>
    [DataMember(Name = "recordingFileRole", EmitDefaultValue = false)]
    public RecordingFileRoleEnum? RecordingFileRole { get; set; }
    /// <summary>
    /// Status of a recording that cannot be returned because of an error
    /// </summary>
    /// <value>Status of a recording that cannot be returned because of an error</value>
    [DataMember(Name = "recordingErrorStatus", EmitDefaultValue = false)]
    public RecordingErrorStatusEnum? RecordingErrorStatus { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="Recording" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="ConversationId">ConversationId.</param>
    /// <param name="Path">Path.</param>
    /// <param name="StartTime">The start time of the recording. Null when there is no playable media..</param>
    /// <param name="EndTime">The end time of the recording. Null when there is no playable media..</param>
    /// <param name="Media">The media type of the recording. This could be audio, chat, messaging, email, or screen..</param>
    /// <param name="MediaSubtype">The media subtype of the recording..</param>
    /// <param name="MediaSubject">The media subject of the recording..</param>
    /// <param name="Annotations">Annotations that belong to the recording..</param>
    /// <param name="Transcript">Represents a chat transcript.</param>
    /// <param name="EmailTranscript">Represents an email transcript.</param>
    /// <param name="MessagingTranscript">Represents a messaging transcript.</param>
    /// <param name="FileState">Represents the current file state for a recording. Examples: Uploading, Archived, etc.</param>
    /// <param name="RestoreExpirationTime">The amount of time a restored recording will remain restored before being archived again. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="MediaUris">The different mediaUris for the recording. Null when there is no playable media..</param>
    /// <param name="EstimatedTranscodeTimeMs">EstimatedTranscodeTimeMs.</param>
    /// <param name="ActualTranscodeTimeMs">ActualTranscodeTimeMs.</param>
    /// <param name="ArchiveDate">The date the recording will be archived. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="ArchiveMedium">The type of archive medium used. Example: CloudArchive.</param>
    /// <param name="DeleteDate">The date the recording will be deleted. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="ExportDate">The date the recording will be exported. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="ExportedDate">The date the recording was exported. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="OutputDurationMs">Duration of transcoded media in milliseconds.</param>
    /// <param name="OutputSizeInBytes">Size of transcoded media in bytes. 0 if there is no transcoded media..</param>
    /// <param name="MaxAllowedRestorationsForOrg">How many archive restorations the organization is allowed to have..</param>
    /// <param name="RemainingRestorationsAllowedForOrg">The remaining archive restorations the organization has..</param>
    /// <param name="SessionId">The session id represents an external resource id, such as email, call, chat, etc.</param>
    /// <param name="Users">The users participating in the conversation.</param>
    /// <param name="RecordingFileRole">Role of the file recording. It can be either customer_experience or adhoc..</param>
    /// <param name="RecordingErrorStatus">Status of a recording that cannot be returned because of an error.</param>
    /// <param name="OriginalRecordingStartTime">The start time of the full recording, before any segment access restrictions are applied. Null when there is no playable media. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="CreationTime">The creation time of the recording. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    public Recording(string Name = null, string ConversationId = null, string Path = null, string StartTime = null, string EndTime = null, string Media = null, MediaSubtypeEnum? MediaSubtype = null, string MediaSubject = null, List<Annotation> Annotations = null, List<ChatMessage> Transcript = null, List<RecordingEmailMessage> EmailTranscript = null, List<RecordingMessagingMessage> MessagingTranscript = null, FileStateEnum? FileState = null, DateTime? RestoreExpirationTime = null, Dictionary<string, MediaResult> MediaUris = null, long? EstimatedTranscodeTimeMs = null, long? ActualTranscodeTimeMs = null, DateTime? ArchiveDate = null, ArchiveMediumEnum? ArchiveMedium = null, DateTime? DeleteDate = null, DateTime? ExportDate = null, DateTime? ExportedDate = null, int? OutputDurationMs = null, int? OutputSizeInBytes = null, int? MaxAllowedRestorationsForOrg = null, int? RemainingRestorationsAllowedForOrg = null, string SessionId = null, List<User> Users = null, RecordingFileRoleEnum? RecordingFileRole = null, RecordingErrorStatusEnum? RecordingErrorStatus = null, DateTime? OriginalRecordingStartTime = null, DateTime? CreationTime = null)
    {
        this.Name = Name;
        this.ConversationId = ConversationId;
        this.Path = Path;
        this.StartTime = StartTime;
        this.EndTime = EndTime;
        this.Media = Media;
        this.MediaSubtype = MediaSubtype;
        this.MediaSubject = MediaSubject;
        this.Annotations = Annotations;
        this.Transcript = Transcript;
        this.EmailTranscript = EmailTranscript;
        this.MessagingTranscript = MessagingTranscript;
        this.FileState = FileState;
        this.RestoreExpirationTime = RestoreExpirationTime;
        this.MediaUris = MediaUris;
        this.EstimatedTranscodeTimeMs = EstimatedTranscodeTimeMs;
        this.ActualTranscodeTimeMs = ActualTranscodeTimeMs;
        this.ArchiveDate = ArchiveDate;
        this.ArchiveMedium = ArchiveMedium;
        this.DeleteDate = DeleteDate;
        this.ExportDate = ExportDate;
        this.ExportedDate = ExportedDate;
        this.OutputDurationMs = OutputDurationMs;
        this.OutputSizeInBytes = OutputSizeInBytes;
        this.MaxAllowedRestorationsForOrg = MaxAllowedRestorationsForOrg;
        this.RemainingRestorationsAllowedForOrg = RemainingRestorationsAllowedForOrg;
        this.SessionId = SessionId;
        this.Users = Users;
        this.RecordingFileRole = RecordingFileRole;
        this.RecordingErrorStatus = RecordingErrorStatus;
        this.OriginalRecordingStartTime = OriginalRecordingStartTime;
        this.CreationTime = CreationTime;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; private set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }



    /// <summary>
    /// Gets or Sets ConversationId
    /// </summary>
    [DataMember(Name = "conversationId", EmitDefaultValue = false)]
    public string ConversationId { get; set; }



    /// <summary>
    /// Gets or Sets Path
    /// </summary>
    [DataMember(Name = "path", EmitDefaultValue = false)]
    public string Path { get; set; }



    /// <summary>
    /// The start time of the recording. Null when there is no playable media.
    /// </summary>
    /// <value>The start time of the recording. Null when there is no playable media.</value>
    [DataMember(Name = "startTime", EmitDefaultValue = false)]
    public string StartTime { get; set; }



    /// <summary>
    /// The end time of the recording. Null when there is no playable media.
    /// </summary>
    /// <value>The end time of the recording. Null when there is no playable media.</value>
    [DataMember(Name = "endTime", EmitDefaultValue = false)]
    public string EndTime { get; set; }



    /// <summary>
    /// The media type of the recording. This could be audio, chat, messaging, email, or screen.
    /// </summary>
    /// <value>The media type of the recording. This could be audio, chat, messaging, email, or screen.</value>
    [DataMember(Name = "media", EmitDefaultValue = false)]
    public string Media { get; set; }





    /// <summary>
    /// The media subject of the recording.
    /// </summary>
    /// <value>The media subject of the recording.</value>
    [DataMember(Name = "mediaSubject", EmitDefaultValue = false)]
    public string MediaSubject { get; set; }



    /// <summary>
    /// Annotations that belong to the recording.
    /// </summary>
    /// <value>Annotations that belong to the recording.</value>
    [DataMember(Name = "annotations", EmitDefaultValue = false)]
    public List<Annotation> Annotations { get; set; }



    /// <summary>
    /// Represents a chat transcript
    /// </summary>
    /// <value>Represents a chat transcript</value>
    [DataMember(Name = "transcript", EmitDefaultValue = false)]
    public List<ChatMessage> Transcript { get; set; }



    /// <summary>
    /// Represents an email transcript
    /// </summary>
    /// <value>Represents an email transcript</value>
    [DataMember(Name = "emailTranscript", EmitDefaultValue = false)]
    public List<RecordingEmailMessage> EmailTranscript { get; set; }



    /// <summary>
    /// Represents a messaging transcript
    /// </summary>
    /// <value>Represents a messaging transcript</value>
    [DataMember(Name = "messagingTranscript", EmitDefaultValue = false)]
    public List<RecordingMessagingMessage> MessagingTranscript { get; set; }





    /// <summary>
    /// The amount of time a restored recording will remain restored before being archived again. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The amount of time a restored recording will remain restored before being archived again. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "restoreExpirationTime", EmitDefaultValue = false)]
    public DateTime? RestoreExpirationTime { get; set; }



    /// <summary>
    /// The different mediaUris for the recording. Null when there is no playable media.
    /// </summary>
    /// <value>The different mediaUris for the recording. Null when there is no playable media.</value>
    [DataMember(Name = "mediaUris", EmitDefaultValue = false)]
    public Dictionary<string, MediaResult> MediaUris { get; set; }



    /// <summary>
    /// Gets or Sets EstimatedTranscodeTimeMs
    /// </summary>
    [DataMember(Name = "estimatedTranscodeTimeMs", EmitDefaultValue = false)]
    public long? EstimatedTranscodeTimeMs { get; set; }



    /// <summary>
    /// Gets or Sets ActualTranscodeTimeMs
    /// </summary>
    [DataMember(Name = "actualTranscodeTimeMs", EmitDefaultValue = false)]
    public long? ActualTranscodeTimeMs { get; set; }



    /// <summary>
    /// The date the recording will be archived. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date the recording will be archived. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "archiveDate", EmitDefaultValue = false)]
    public DateTime? ArchiveDate { get; set; }





    /// <summary>
    /// The date the recording will be deleted. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date the recording will be deleted. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "deleteDate", EmitDefaultValue = false)]
    public DateTime? DeleteDate { get; set; }



    /// <summary>
    /// The date the recording will be exported. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date the recording will be exported. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "exportDate", EmitDefaultValue = false)]
    public DateTime? ExportDate { get; set; }



    /// <summary>
    /// The date the recording was exported. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date the recording was exported. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "exportedDate", EmitDefaultValue = false)]
    public DateTime? ExportedDate { get; set; }



    /// <summary>
    /// Duration of transcoded media in milliseconds
    /// </summary>
    /// <value>Duration of transcoded media in milliseconds</value>
    [DataMember(Name = "outputDurationMs", EmitDefaultValue = false)]
    public int? OutputDurationMs { get; set; }



    /// <summary>
    /// Size of transcoded media in bytes. 0 if there is no transcoded media.
    /// </summary>
    /// <value>Size of transcoded media in bytes. 0 if there is no transcoded media.</value>
    [DataMember(Name = "outputSizeInBytes", EmitDefaultValue = false)]
    public int? OutputSizeInBytes { get; set; }



    /// <summary>
    /// How many archive restorations the organization is allowed to have.
    /// </summary>
    /// <value>How many archive restorations the organization is allowed to have.</value>
    [DataMember(Name = "maxAllowedRestorationsForOrg", EmitDefaultValue = false)]
    public int? MaxAllowedRestorationsForOrg { get; set; }



    /// <summary>
    /// The remaining archive restorations the organization has.
    /// </summary>
    /// <value>The remaining archive restorations the organization has.</value>
    [DataMember(Name = "remainingRestorationsAllowedForOrg", EmitDefaultValue = false)]
    public int? RemainingRestorationsAllowedForOrg { get; set; }



    /// <summary>
    /// The session id represents an external resource id, such as email, call, chat, etc
    /// </summary>
    /// <value>The session id represents an external resource id, such as email, call, chat, etc</value>
    [DataMember(Name = "sessionId", EmitDefaultValue = false)]
    public string SessionId { get; set; }



    /// <summary>
    /// The users participating in the conversation
    /// </summary>
    /// <value>The users participating in the conversation</value>
    [DataMember(Name = "users", EmitDefaultValue = false)]
    public List<User> Users { get; set; }







    /// <summary>
    /// The start time of the full recording, before any segment access restrictions are applied. Null when there is no playable media. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The start time of the full recording, before any segment access restrictions are applied. Null when there is no playable media. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "originalRecordingStartTime", EmitDefaultValue = false)]
    public DateTime? OriginalRecordingStartTime { get; set; }



    /// <summary>
    /// The creation time of the recording. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The creation time of the recording. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "creationTime", EmitDefaultValue = false)]
    public DateTime? CreationTime { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [DataMember(Name = "selfUri", EmitDefaultValue = false)]
    public string SelfUri { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class Recording {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
        sb.Append("  Path: ").Append(Path).Append("\n");
        sb.Append("  StartTime: ").Append(StartTime).Append("\n");
        sb.Append("  EndTime: ").Append(EndTime).Append("\n");
        sb.Append("  Media: ").Append(Media).Append("\n");
        sb.Append("  MediaSubtype: ").Append(MediaSubtype).Append("\n");
        sb.Append("  MediaSubject: ").Append(MediaSubject).Append("\n");
        sb.Append("  Annotations: ").Append(Annotations).Append("\n");
        sb.Append("  Transcript: ").Append(Transcript).Append("\n");
        sb.Append("  EmailTranscript: ").Append(EmailTranscript).Append("\n");
        sb.Append("  MessagingTranscript: ").Append(MessagingTranscript).Append("\n");
        sb.Append("  FileState: ").Append(FileState).Append("\n");
        sb.Append("  RestoreExpirationTime: ").Append(RestoreExpirationTime).Append("\n");
        sb.Append("  MediaUris: ").Append(MediaUris).Append("\n");
        sb.Append("  EstimatedTranscodeTimeMs: ").Append(EstimatedTranscodeTimeMs).Append("\n");
        sb.Append("  ActualTranscodeTimeMs: ").Append(ActualTranscodeTimeMs).Append("\n");
        sb.Append("  ArchiveDate: ").Append(ArchiveDate).Append("\n");
        sb.Append("  ArchiveMedium: ").Append(ArchiveMedium).Append("\n");
        sb.Append("  DeleteDate: ").Append(DeleteDate).Append("\n");
        sb.Append("  ExportDate: ").Append(ExportDate).Append("\n");
        sb.Append("  ExportedDate: ").Append(ExportedDate).Append("\n");
        sb.Append("  OutputDurationMs: ").Append(OutputDurationMs).Append("\n");
        sb.Append("  OutputSizeInBytes: ").Append(OutputSizeInBytes).Append("\n");
        sb.Append("  MaxAllowedRestorationsForOrg: ").Append(MaxAllowedRestorationsForOrg).Append("\n");
        sb.Append("  RemainingRestorationsAllowedForOrg: ").Append(RemainingRestorationsAllowedForOrg).Append("\n");
        sb.Append("  SessionId: ").Append(SessionId).Append("\n");
        sb.Append("  Users: ").Append(Users).Append("\n");
        sb.Append("  RecordingFileRole: ").Append(RecordingFileRole).Append("\n");
        sb.Append("  RecordingErrorStatus: ").Append(RecordingErrorStatus).Append("\n");
        sb.Append("  OriginalRecordingStartTime: ").Append(OriginalRecordingStartTime).Append("\n");
        sb.Append("  CreationTime: ").Append(CreationTime).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }


    /// <summary>
    /// Returns true if objects are equal
    /// </summary>
    /// <param name="obj">Object to be compared</param>
    /// <returns>Boolean</returns>
    public override bool Equals(object obj)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        return this.Equals(obj as Recording);
    }

    /// <summary>
    /// Returns true if Recording instances are equal
    /// </summary>
    /// <param name="other">Instance of Recording to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Recording other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                this.Id == other.Id ||
                this.Id != null &&
                this.Id.Equals(other.Id)
            ) &&
            (
                this.Name == other.Name ||
                this.Name != null &&
                this.Name.Equals(other.Name)
            ) &&
            (
                this.ConversationId == other.ConversationId ||
                this.ConversationId != null &&
                this.ConversationId.Equals(other.ConversationId)
            ) &&
            (
                this.Path == other.Path ||
                this.Path != null &&
                this.Path.Equals(other.Path)
            ) &&
            (
                this.StartTime == other.StartTime ||
                this.StartTime != null &&
                this.StartTime.Equals(other.StartTime)
            ) &&
            (
                this.EndTime == other.EndTime ||
                this.EndTime != null &&
                this.EndTime.Equals(other.EndTime)
            ) &&
            (
                this.Media == other.Media ||
                this.Media != null &&
                this.Media.Equals(other.Media)
            ) &&
            (
                this.MediaSubtype == other.MediaSubtype ||
                this.MediaSubtype != null &&
                this.MediaSubtype.Equals(other.MediaSubtype)
            ) &&
            (
                this.MediaSubject == other.MediaSubject ||
                this.MediaSubject != null &&
                this.MediaSubject.Equals(other.MediaSubject)
            ) &&
            (
                this.Annotations == other.Annotations ||
                this.Annotations != null &&
                this.Annotations.SequenceEqual(other.Annotations)
            ) &&
            (
                this.Transcript == other.Transcript ||
                this.Transcript != null &&
                this.Transcript.SequenceEqual(other.Transcript)
            ) &&
            (
                this.EmailTranscript == other.EmailTranscript ||
                this.EmailTranscript != null &&
                this.EmailTranscript.SequenceEqual(other.EmailTranscript)
            ) &&
            (
                this.MessagingTranscript == other.MessagingTranscript ||
                this.MessagingTranscript != null &&
                this.MessagingTranscript.SequenceEqual(other.MessagingTranscript)
            ) &&
            (
                this.FileState == other.FileState ||
                this.FileState != null &&
                this.FileState.Equals(other.FileState)
            ) &&
            (
                this.RestoreExpirationTime == other.RestoreExpirationTime ||
                this.RestoreExpirationTime != null &&
                this.RestoreExpirationTime.Equals(other.RestoreExpirationTime)
            ) &&
            (
                this.MediaUris == other.MediaUris ||
                this.MediaUris != null &&
                this.MediaUris.SequenceEqual(other.MediaUris)
            ) &&
            (
                this.EstimatedTranscodeTimeMs == other.EstimatedTranscodeTimeMs ||
                this.EstimatedTranscodeTimeMs != null &&
                this.EstimatedTranscodeTimeMs.Equals(other.EstimatedTranscodeTimeMs)
            ) &&
            (
                this.ActualTranscodeTimeMs == other.ActualTranscodeTimeMs ||
                this.ActualTranscodeTimeMs != null &&
                this.ActualTranscodeTimeMs.Equals(other.ActualTranscodeTimeMs)
            ) &&
            (
                this.ArchiveDate == other.ArchiveDate ||
                this.ArchiveDate != null &&
                this.ArchiveDate.Equals(other.ArchiveDate)
            ) &&
            (
                this.ArchiveMedium == other.ArchiveMedium ||
                this.ArchiveMedium != null &&
                this.ArchiveMedium.Equals(other.ArchiveMedium)
            ) &&
            (
                this.DeleteDate == other.DeleteDate ||
                this.DeleteDate != null &&
                this.DeleteDate.Equals(other.DeleteDate)
            ) &&
            (
                this.ExportDate == other.ExportDate ||
                this.ExportDate != null &&
                this.ExportDate.Equals(other.ExportDate)
            ) &&
            (
                this.ExportedDate == other.ExportedDate ||
                this.ExportedDate != null &&
                this.ExportedDate.Equals(other.ExportedDate)
            ) &&
            (
                this.OutputDurationMs == other.OutputDurationMs ||
                this.OutputDurationMs != null &&
                this.OutputDurationMs.Equals(other.OutputDurationMs)
            ) &&
            (
                this.OutputSizeInBytes == other.OutputSizeInBytes ||
                this.OutputSizeInBytes != null &&
                this.OutputSizeInBytes.Equals(other.OutputSizeInBytes)
            ) &&
            (
                this.MaxAllowedRestorationsForOrg == other.MaxAllowedRestorationsForOrg ||
                this.MaxAllowedRestorationsForOrg != null &&
                this.MaxAllowedRestorationsForOrg.Equals(other.MaxAllowedRestorationsForOrg)
            ) &&
            (
                this.RemainingRestorationsAllowedForOrg == other.RemainingRestorationsAllowedForOrg ||
                this.RemainingRestorationsAllowedForOrg != null &&
                this.RemainingRestorationsAllowedForOrg.Equals(other.RemainingRestorationsAllowedForOrg)
            ) &&
            (
                this.SessionId == other.SessionId ||
                this.SessionId != null &&
                this.SessionId.Equals(other.SessionId)
            ) &&
            (
                this.Users == other.Users ||
                this.Users != null &&
                this.Users.SequenceEqual(other.Users)
            ) &&
            (
                this.RecordingFileRole == other.RecordingFileRole ||
                this.RecordingFileRole != null &&
                this.RecordingFileRole.Equals(other.RecordingFileRole)
            ) &&
            (
                this.RecordingErrorStatus == other.RecordingErrorStatus ||
                this.RecordingErrorStatus != null &&
                this.RecordingErrorStatus.Equals(other.RecordingErrorStatus)
            ) &&
            (
                this.OriginalRecordingStartTime == other.OriginalRecordingStartTime ||
                this.OriginalRecordingStartTime != null &&
                this.OriginalRecordingStartTime.Equals(other.OriginalRecordingStartTime)
            ) &&
            (
                this.CreationTime == other.CreationTime ||
                this.CreationTime != null &&
                this.CreationTime.Equals(other.CreationTime)
            ) &&
            (
                this.SelfUri == other.SelfUri ||
                this.SelfUri != null &&
                this.SelfUri.Equals(other.SelfUri)
            );
    }

    /// <summary>
    /// Gets the hash code
    /// </summary>
    /// <returns>Hash code</returns>
    public override int GetHashCode()
    {
        // credit: http://stackoverflow.com/a/263416/677735
        unchecked // Overflow is fine, just wrap
        {
            int hash = 41;
            // Suitable nullity checks etc, of course :)
            if (this.Id != null)
            {
                hash = hash * 59 + this.Id.GetHashCode();
            }

            if (this.Name != null)
            {
                hash = hash * 59 + this.Name.GetHashCode();
            }

            if (this.ConversationId != null)
            {
                hash = hash * 59 + this.ConversationId.GetHashCode();
            }

            if (this.Path != null)
            {
                hash = hash * 59 + this.Path.GetHashCode();
            }

            if (this.StartTime != null)
            {
                hash = hash * 59 + this.StartTime.GetHashCode();
            }

            if (this.EndTime != null)
            {
                hash = hash * 59 + this.EndTime.GetHashCode();
            }

            if (this.Media != null)
            {
                hash = hash * 59 + this.Media.GetHashCode();
            }

            if (this.MediaSubtype != null)
            {
                hash = hash * 59 + this.MediaSubtype.GetHashCode();
            }

            if (this.MediaSubject != null)
            {
                hash = hash * 59 + this.MediaSubject.GetHashCode();
            }

            if (this.Annotations != null)
            {
                hash = hash * 59 + this.Annotations.GetHashCode();
            }

            if (this.Transcript != null)
            {
                hash = hash * 59 + this.Transcript.GetHashCode();
            }

            if (this.EmailTranscript != null)
            {
                hash = hash * 59 + this.EmailTranscript.GetHashCode();
            }

            if (this.MessagingTranscript != null)
            {
                hash = hash * 59 + this.MessagingTranscript.GetHashCode();
            }

            if (this.FileState != null)
            {
                hash = hash * 59 + this.FileState.GetHashCode();
            }

            if (this.RestoreExpirationTime != null)
            {
                hash = hash * 59 + this.RestoreExpirationTime.GetHashCode();
            }

            if (this.MediaUris != null)
            {
                hash = hash * 59 + this.MediaUris.GetHashCode();
            }

            if (this.EstimatedTranscodeTimeMs != null)
            {
                hash = hash * 59 + this.EstimatedTranscodeTimeMs.GetHashCode();
            }

            if (this.ActualTranscodeTimeMs != null)
            {
                hash = hash * 59 + this.ActualTranscodeTimeMs.GetHashCode();
            }

            if (this.ArchiveDate != null)
            {
                hash = hash * 59 + this.ArchiveDate.GetHashCode();
            }

            if (this.ArchiveMedium != null)
            {
                hash = hash * 59 + this.ArchiveMedium.GetHashCode();
            }

            if (this.DeleteDate != null)
            {
                hash = hash * 59 + this.DeleteDate.GetHashCode();
            }

            if (this.ExportDate != null)
            {
                hash = hash * 59 + this.ExportDate.GetHashCode();
            }

            if (this.ExportedDate != null)
            {
                hash = hash * 59 + this.ExportedDate.GetHashCode();
            }

            if (this.OutputDurationMs != null)
            {
                hash = hash * 59 + this.OutputDurationMs.GetHashCode();
            }

            if (this.OutputSizeInBytes != null)
            {
                hash = hash * 59 + this.OutputSizeInBytes.GetHashCode();
            }

            if (this.MaxAllowedRestorationsForOrg != null)
            {
                hash = hash * 59 + this.MaxAllowedRestorationsForOrg.GetHashCode();
            }

            if (this.RemainingRestorationsAllowedForOrg != null)
            {
                hash = hash * 59 + this.RemainingRestorationsAllowedForOrg.GetHashCode();
            }

            if (this.SessionId != null)
            {
                hash = hash * 59 + this.SessionId.GetHashCode();
            }

            if (this.Users != null)
            {
                hash = hash * 59 + this.Users.GetHashCode();
            }

            if (this.RecordingFileRole != null)
            {
                hash = hash * 59 + this.RecordingFileRole.GetHashCode();
            }

            if (this.RecordingErrorStatus != null)
            {
                hash = hash * 59 + this.RecordingErrorStatus.GetHashCode();
            }

            if (this.OriginalRecordingStartTime != null)
            {
                hash = hash * 59 + this.OriginalRecordingStartTime.GetHashCode();
            }

            if (this.CreationTime != null)
            {
                hash = hash * 59 + this.CreationTime.GetHashCode();
            }

            if (this.SelfUri != null)
            {
                hash = hash * 59 + this.SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
