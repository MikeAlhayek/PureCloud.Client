using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// RecordingMetadata
/// </summary>

public partial class RecordingMetadata : IEquatable<RecordingMetadata>
{
    /// <summary>
    /// The recording media subtype.
    /// </summary>
    /// <value>The recording media subtype.</value>
    
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
    /// The recording media subtype.
    /// </summary>
    /// <value>The recording media subtype.</value>
    [JsonPropertyName("mediaSubtype")]
    public MediaSubtypeEnum? MediaSubtype { get; set; }
    /// <summary>
    /// Represents the current file state for a recording. Examples: Uploading, Archived, etc
    /// </summary>
    /// <value>Represents the current file state for a recording. Examples: Uploading, Archived, etc</value>
    [JsonPropertyName("fileState")]
    public FileStateEnum? FileState { get; set; }
    /// <summary>
    /// The type of archive medium used. Example: CloudArchive
    /// </summary>
    /// <value>The type of archive medium used. Example: CloudArchive</value>
    [JsonPropertyName("archiveMedium")]
    public ArchiveMediumEnum? ArchiveMedium { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="RecordingMetadata" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="ConversationId">ConversationId.</param>
    /// <param name="Path">Path.</param>
    /// <param name="StartTime">The start time of the recording for screen recordings. Null for other types..</param>
    /// <param name="EndTime">EndTime.</param>
    /// <param name="Media">The type of media that the recording is. At the moment that could be audio, chat, email, or message..</param>
    /// <param name="MediaSubtype">The recording media subtype..</param>
    /// <param name="MediaSubject">The recording media subject..</param>
    /// <param name="Annotations">Annotations that belong to the recording. Populated when recording filestate is AVAILABLE..</param>
    /// <param name="FileState">Represents the current file state for a recording. Examples: Uploading, Archived, etc.</param>
    /// <param name="RestoreExpirationTime">The amount of time a restored recording will remain restored before being archived again. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="ArchiveDate">The date the recording will be archived. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="ArchiveMedium">The type of archive medium used. Example: CloudArchive.</param>
    /// <param name="DeleteDate">The date the recording will be deleted. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="ExportDate">The date the recording will be exported. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="ExportedDate">The date the recording was exported. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="MaxAllowedRestorationsForOrg">How many archive restorations the organization is allowed to have..</param>
    /// <param name="RemainingRestorationsAllowedForOrg">The remaining archive restorations the organization has..</param>
    /// <param name="SessionId">The session id represents an external resource id, such as email, call, chat, etc.</param>
    public RecordingMetadata(string Name = null, string ConversationId = null, string Path = null, string StartTime = null, string EndTime = null, string Media = null, MediaSubtypeEnum? MediaSubtype = null, string MediaSubject = null, List<Annotation> Annotations = null, FileStateEnum? FileState = null, DateTime? RestoreExpirationTime = null, DateTime? ArchiveDate = null, ArchiveMediumEnum? ArchiveMedium = null, DateTime? DeleteDate = null, DateTime? ExportDate = null, DateTime? ExportedDate = null, int? MaxAllowedRestorationsForOrg = null, int? RemainingRestorationsAllowedForOrg = null, string SessionId = null)
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
        this.FileState = FileState;
        this.RestoreExpirationTime = RestoreExpirationTime;
        this.ArchiveDate = ArchiveDate;
        this.ArchiveMedium = ArchiveMedium;
        this.DeleteDate = DeleteDate;
        this.ExportDate = ExportDate;
        this.ExportedDate = ExportedDate;
        this.MaxAllowedRestorationsForOrg = MaxAllowedRestorationsForOrg;
        this.RemainingRestorationsAllowedForOrg = RemainingRestorationsAllowedForOrg;
        this.SessionId = SessionId;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// Gets or Sets ConversationId
    /// </summary>
    [JsonPropertyName("conversationId")]
    public string ConversationId { get; set; }



    /// <summary>
    /// Gets or Sets Path
    /// </summary>
    [JsonPropertyName("path")]
    public string Path { get; set; }



    /// <summary>
    /// The start time of the recording for screen recordings. Null for other types.
    /// </summary>
    /// <value>The start time of the recording for screen recordings. Null for other types.</value>
    [JsonPropertyName("startTime")]
    public string StartTime { get; set; }



    /// <summary>
    /// Gets or Sets EndTime
    /// </summary>
    [JsonPropertyName("endTime")]
    public string EndTime { get; set; }



    /// <summary>
    /// The type of media that the recording is. At the moment that could be audio, chat, email, or message.
    /// </summary>
    /// <value>The type of media that the recording is. At the moment that could be audio, chat, email, or message.</value>
    [JsonPropertyName("media")]
    public string Media { get; set; }





    /// <summary>
    /// The recording media subject.
    /// </summary>
    /// <value>The recording media subject.</value>
    [JsonPropertyName("mediaSubject")]
    public string MediaSubject { get; set; }



    /// <summary>
    /// Annotations that belong to the recording. Populated when recording filestate is AVAILABLE.
    /// </summary>
    /// <value>Annotations that belong to the recording. Populated when recording filestate is AVAILABLE.</value>
    [JsonPropertyName("annotations")]
    public List<Annotation> Annotations { get; set; }





    /// <summary>
    /// The amount of time a restored recording will remain restored before being archived again. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The amount of time a restored recording will remain restored before being archived again. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("restoreExpirationTime")]
    public DateTime? RestoreExpirationTime { get; set; }



    /// <summary>
    /// The date the recording will be archived. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date the recording will be archived. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("archiveDate")]
    public DateTime? ArchiveDate { get; set; }





    /// <summary>
    /// The date the recording will be deleted. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date the recording will be deleted. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("deleteDate")]
    public DateTime? DeleteDate { get; set; }



    /// <summary>
    /// The date the recording will be exported. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date the recording will be exported. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("exportDate")]
    public DateTime? ExportDate { get; set; }



    /// <summary>
    /// The date the recording was exported. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date the recording was exported. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("exportedDate")]
    public DateTime? ExportedDate { get; set; }



    /// <summary>
    /// How many archive restorations the organization is allowed to have.
    /// </summary>
    /// <value>How many archive restorations the organization is allowed to have.</value>
    [JsonPropertyName("maxAllowedRestorationsForOrg")]
    public int? MaxAllowedRestorationsForOrg { get; set; }



    /// <summary>
    /// The remaining archive restorations the organization has.
    /// </summary>
    /// <value>The remaining archive restorations the organization has.</value>
    [JsonPropertyName("remainingRestorationsAllowedForOrg")]
    public int? RemainingRestorationsAllowedForOrg { get; set; }



    /// <summary>
    /// The session id represents an external resource id, such as email, call, chat, etc
    /// </summary>
    /// <value>The session id represents an external resource id, such as email, call, chat, etc</value>
    [JsonPropertyName("sessionId")]
    public string SessionId { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class RecordingMetadata {\n");

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
        sb.Append("  FileState: ").Append(FileState).Append("\n");
        sb.Append("  RestoreExpirationTime: ").Append(RestoreExpirationTime).Append("\n");
        sb.Append("  ArchiveDate: ").Append(ArchiveDate).Append("\n");
        sb.Append("  ArchiveMedium: ").Append(ArchiveMedium).Append("\n");
        sb.Append("  DeleteDate: ").Append(DeleteDate).Append("\n");
        sb.Append("  ExportDate: ").Append(ExportDate).Append("\n");
        sb.Append("  ExportedDate: ").Append(ExportedDate).Append("\n");
        sb.Append("  MaxAllowedRestorationsForOrg: ").Append(MaxAllowedRestorationsForOrg).Append("\n");
        sb.Append("  RemainingRestorationsAllowedForOrg: ").Append(RemainingRestorationsAllowedForOrg).Append("\n");
        sb.Append("  SessionId: ").Append(SessionId).Append("\n");
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
        return Equals(obj as RecordingMetadata);
    }

    /// <summary>
    /// Returns true if RecordingMetadata instances are equal
    /// </summary>
    /// <param name="other">Instance of RecordingMetadata to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(RecordingMetadata other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
            ) &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                ConversationId == other.ConversationId ||
                ConversationId != null &&
                ConversationId.Equals(other.ConversationId)
            ) &&
            (
                Path == other.Path ||
                Path != null &&
                Path.Equals(other.Path)
            ) &&
            (
                StartTime == other.StartTime ||
                StartTime != null &&
                StartTime.Equals(other.StartTime)
            ) &&
            (
                EndTime == other.EndTime ||
                EndTime != null &&
                EndTime.Equals(other.EndTime)
            ) &&
            (
                Media == other.Media ||
                Media != null &&
                Media.Equals(other.Media)
            ) &&
            (
                MediaSubtype == other.MediaSubtype ||
                MediaSubtype != null &&
                MediaSubtype.Equals(other.MediaSubtype)
            ) &&
            (
                MediaSubject == other.MediaSubject ||
                MediaSubject != null &&
                MediaSubject.Equals(other.MediaSubject)
            ) &&
            (
                Annotations == other.Annotations ||
                Annotations != null &&
                Annotations.SequenceEqual(other.Annotations)
            ) &&
            (
                FileState == other.FileState ||
                FileState != null &&
                FileState.Equals(other.FileState)
            ) &&
            (
                RestoreExpirationTime == other.RestoreExpirationTime ||
                RestoreExpirationTime != null &&
                RestoreExpirationTime.Equals(other.RestoreExpirationTime)
            ) &&
            (
                ArchiveDate == other.ArchiveDate ||
                ArchiveDate != null &&
                ArchiveDate.Equals(other.ArchiveDate)
            ) &&
            (
                ArchiveMedium == other.ArchiveMedium ||
                ArchiveMedium != null &&
                ArchiveMedium.Equals(other.ArchiveMedium)
            ) &&
            (
                DeleteDate == other.DeleteDate ||
                DeleteDate != null &&
                DeleteDate.Equals(other.DeleteDate)
            ) &&
            (
                ExportDate == other.ExportDate ||
                ExportDate != null &&
                ExportDate.Equals(other.ExportDate)
            ) &&
            (
                ExportedDate == other.ExportedDate ||
                ExportedDate != null &&
                ExportedDate.Equals(other.ExportedDate)
            ) &&
            (
                MaxAllowedRestorationsForOrg == other.MaxAllowedRestorationsForOrg ||
                MaxAllowedRestorationsForOrg != null &&
                MaxAllowedRestorationsForOrg.Equals(other.MaxAllowedRestorationsForOrg)
            ) &&
            (
                RemainingRestorationsAllowedForOrg == other.RemainingRestorationsAllowedForOrg ||
                RemainingRestorationsAllowedForOrg != null &&
                RemainingRestorationsAllowedForOrg.Equals(other.RemainingRestorationsAllowedForOrg)
            ) &&
            (
                SessionId == other.SessionId ||
                SessionId != null &&
                SessionId.Equals(other.SessionId)
            ) &&
            (
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
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
            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (ConversationId != null)
            {
                hash = hash * 59 + ConversationId.GetHashCode();
            }

            if (Path != null)
            {
                hash = hash * 59 + Path.GetHashCode();
            }

            if (StartTime != null)
            {
                hash = hash * 59 + StartTime.GetHashCode();
            }

            if (EndTime != null)
            {
                hash = hash * 59 + EndTime.GetHashCode();
            }

            if (Media != null)
            {
                hash = hash * 59 + Media.GetHashCode();
            }

            if (MediaSubtype != null)
            {
                hash = hash * 59 + MediaSubtype.GetHashCode();
            }

            if (MediaSubject != null)
            {
                hash = hash * 59 + MediaSubject.GetHashCode();
            }

            if (Annotations != null)
            {
                hash = hash * 59 + Annotations.GetHashCode();
            }

            if (FileState != null)
            {
                hash = hash * 59 + FileState.GetHashCode();
            }

            if (RestoreExpirationTime != null)
            {
                hash = hash * 59 + RestoreExpirationTime.GetHashCode();
            }

            if (ArchiveDate != null)
            {
                hash = hash * 59 + ArchiveDate.GetHashCode();
            }

            if (ArchiveMedium != null)
            {
                hash = hash * 59 + ArchiveMedium.GetHashCode();
            }

            if (DeleteDate != null)
            {
                hash = hash * 59 + DeleteDate.GetHashCode();
            }

            if (ExportDate != null)
            {
                hash = hash * 59 + ExportDate.GetHashCode();
            }

            if (ExportedDate != null)
            {
                hash = hash * 59 + ExportedDate.GetHashCode();
            }

            if (MaxAllowedRestorationsForOrg != null)
            {
                hash = hash * 59 + MaxAllowedRestorationsForOrg.GetHashCode();
            }

            if (RemainingRestorationsAllowedForOrg != null)
            {
                hash = hash * 59 + RemainingRestorationsAllowedForOrg.GetHashCode();
            }

            if (SessionId != null)
            {
                hash = hash * 59 + SessionId.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
