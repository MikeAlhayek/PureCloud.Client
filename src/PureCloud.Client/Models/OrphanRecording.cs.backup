using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// OrphanRecording
/// </summary>

public partial class OrphanRecording : IEquatable<OrphanRecording>
{
    /// <summary>
    /// Gets or Sets ProviderType
    /// </summary>
    
    public enum ProviderTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Edge for "EDGE"
        /// </summary>
        [EnumMember(Value = "EDGE")]
        Edge,

        /// <summary>
        /// Enum Chat for "CHAT"
        /// </summary>
        [EnumMember(Value = "CHAT")]
        Chat,

        /// <summary>
        /// Enum Email for "EMAIL"
        /// </summary>
        [EnumMember(Value = "EMAIL")]
        Email,

        /// <summary>
        /// Enum ScreenRecording for "SCREEN_RECORDING"
        /// </summary>
        [EnumMember(Value = "SCREEN_RECORDING")]
        ScreenRecording,

        /// <summary>
        /// Enum Pureengage for "PUREENGAGE"
        /// </summary>
        [EnumMember(Value = "PUREENGAGE")]
        Pureengage,

        /// <summary>
        /// Enum Pureconnect for "PURECONNECT"
        /// </summary>
        [EnumMember(Value = "PURECONNECT")]
        Pureconnect
    }
    /// <summary>
    /// Gets or Sets MediaType
    /// </summary>
    
    public enum MediaTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Call for "CALL"
        /// </summary>
        [EnumMember(Value = "CALL")]
        Call,

        /// <summary>
        /// Enum Chat for "CHAT"
        /// </summary>
        [EnumMember(Value = "CHAT")]
        Chat,

        /// <summary>
        /// Enum Email for "EMAIL"
        /// </summary>
        [EnumMember(Value = "EMAIL")]
        Email,

        /// <summary>
        /// Enum Screen for "SCREEN"
        /// </summary>
        [EnumMember(Value = "SCREEN")]
        Screen
    }
    /// <summary>
    /// Gets or Sets MediaSubtype
    /// </summary>
    
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
    /// Gets or Sets FileState
    /// </summary>
    
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
        Uploading
    }
    /// <summary>
    /// The status of the orphaned recording's conversation.
    /// </summary>
    /// <value>The status of the orphaned recording's conversation.</value>
    
    public enum OrphanStatusEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum NoConversation for "NO_CONVERSATION"
        /// </summary>
        [EnumMember(Value = "NO_CONVERSATION")]
        NoConversation,

        /// <summary>
        /// Enum UnknownConversation for "UNKNOWN_CONVERSATION"
        /// </summary>
        [EnumMember(Value = "UNKNOWN_CONVERSATION")]
        UnknownConversation,

        /// <summary>
        /// Enum ConversationNotComplete for "CONVERSATION_NOT_COMPLETE"
        /// </summary>
        [EnumMember(Value = "CONVERSATION_NOT_COMPLETE")]
        ConversationNotComplete,

        /// <summary>
        /// Enum ConversationNotEvaluated for "CONVERSATION_NOT_EVALUATED"
        /// </summary>
        [EnumMember(Value = "CONVERSATION_NOT_EVALUATED")]
        ConversationNotEvaluated,

        /// <summary>
        /// Enum Evaluated for "EVALUATED"
        /// </summary>
        [EnumMember(Value = "EVALUATED")]
        Evaluated
    }
    /// <summary>
    /// Gets or Sets Region
    /// </summary>
    
    public enum RegionEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Afsouth1 for "af-south-1"
        /// </summary>
        [EnumMember(Value = "af-south-1")]
        Afsouth1,

        /// <summary>
        /// Enum Apeast1 for "ap-east-1"
        /// </summary>
        [EnumMember(Value = "ap-east-1")]
        Apeast1,

        /// <summary>
        /// Enum Apnortheast1 for "ap-northeast-1"
        /// </summary>
        [EnumMember(Value = "ap-northeast-1")]
        Apnortheast1,

        /// <summary>
        /// Enum Apnortheast2 for "ap-northeast-2"
        /// </summary>
        [EnumMember(Value = "ap-northeast-2")]
        Apnortheast2,

        /// <summary>
        /// Enum Apnortheast3 for "ap-northeast-3"
        /// </summary>
        [EnumMember(Value = "ap-northeast-3")]
        Apnortheast3,

        /// <summary>
        /// Enum Apsouth1 for "ap-south-1"
        /// </summary>
        [EnumMember(Value = "ap-south-1")]
        Apsouth1,

        /// <summary>
        /// Enum Apsoutheast1 for "ap-southeast-1"
        /// </summary>
        [EnumMember(Value = "ap-southeast-1")]
        Apsoutheast1,

        /// <summary>
        /// Enum Apsoutheast2 for "ap-southeast-2"
        /// </summary>
        [EnumMember(Value = "ap-southeast-2")]
        Apsoutheast2,

        /// <summary>
        /// Enum Apsoutheast3 for "ap-southeast-3"
        /// </summary>
        [EnumMember(Value = "ap-southeast-3")]
        Apsoutheast3,

        /// <summary>
        /// Enum Cacentral1 for "ca-central-1"
        /// </summary>
        [EnumMember(Value = "ca-central-1")]
        Cacentral1,

        /// <summary>
        /// Enum Eucentral1 for "eu-central-1"
        /// </summary>
        [EnumMember(Value = "eu-central-1")]
        Eucentral1,

        /// <summary>
        /// Enum Eucentral2 for "eu-central-2"
        /// </summary>
        [EnumMember(Value = "eu-central-2")]
        Eucentral2,

        /// <summary>
        /// Enum Euwest1 for "eu-west-1"
        /// </summary>
        [EnumMember(Value = "eu-west-1")]
        Euwest1,

        /// <summary>
        /// Enum Euwest2 for "eu-west-2"
        /// </summary>
        [EnumMember(Value = "eu-west-2")]
        Euwest2,

        /// <summary>
        /// Enum Euwest3 for "eu-west-3"
        /// </summary>
        [EnumMember(Value = "eu-west-3")]
        Euwest3,

        /// <summary>
        /// Enum Mecentral1 for "me-central-1"
        /// </summary>
        [EnumMember(Value = "me-central-1")]
        Mecentral1,

        /// <summary>
        /// Enum Saeast1 for "sa-east-1"
        /// </summary>
        [EnumMember(Value = "sa-east-1")]
        Saeast1,

        /// <summary>
        /// Enum Useast1 for "us-east-1"
        /// </summary>
        [EnumMember(Value = "us-east-1")]
        Useast1,

        /// <summary>
        /// Enum Uswest2 for "us-west-2"
        /// </summary>
        [EnumMember(Value = "us-west-2")]
        Uswest2
    }
    /// <summary>
    /// Gets or Sets ProviderType
    /// </summary>
    [JsonPropertyName("providerType")]
    public ProviderTypeEnum? ProviderType { get; set; }
    /// <summary>
    /// Gets or Sets MediaType
    /// </summary>
    [JsonPropertyName("mediaType")]
    public MediaTypeEnum? MediaType { get; set; }
    /// <summary>
    /// Gets or Sets MediaSubtype
    /// </summary>
    [JsonPropertyName("mediaSubtype")]
    public MediaSubtypeEnum? MediaSubtype { get; set; }
    /// <summary>
    /// Gets or Sets FileState
    /// </summary>
    [JsonPropertyName("fileState")]
    public FileStateEnum? FileState { get; set; }
    /// <summary>
    /// The status of the orphaned recording's conversation.
    /// </summary>
    /// <value>The status of the orphaned recording's conversation.</value>
    [JsonPropertyName("orphanStatus")]
    public OrphanStatusEnum? OrphanStatus { get; set; }
    /// <summary>
    /// Gets or Sets Region
    /// </summary>
    [JsonPropertyName("region")]
    public RegionEnum? Region { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="OrphanRecording" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="CreatedTime">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="RecoveredTime">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="ProviderType">ProviderType.</param>
    /// <param name="MediaSizeBytes">MediaSizeBytes.</param>
    /// <param name="MediaType">MediaType.</param>
    /// <param name="MediaSubtype">MediaSubtype.</param>
    /// <param name="MediaSubject">MediaSubject.</param>
    /// <param name="FileState">FileState.</param>
    /// <param name="ProviderEndpoint">ProviderEndpoint.</param>
    /// <param name="Recording">Recording.</param>
    /// <param name="OrphanStatus">The status of the orphaned recording&#39;s conversation..</param>
    /// <param name="SourceOrphaningId">An identifier used during recovery operations by the supplying hybrid platform to track back and determine which interaction this recording is associated with.</param>
    /// <param name="Region">Region.</param>
    public OrphanRecording(string Name = null, DateTime? CreatedTime = null, DateTime? RecoveredTime = null, ProviderTypeEnum? ProviderType = null, long? MediaSizeBytes = null, MediaTypeEnum? MediaType = null, MediaSubtypeEnum? MediaSubtype = null, string MediaSubject = null, FileStateEnum? FileState = null, Endpoint ProviderEndpoint = null, Recording Recording = null, OrphanStatusEnum? OrphanStatus = null, string SourceOrphaningId = null, RegionEnum? Region = null)
    {
        this.Name = Name;
        this.CreatedTime = CreatedTime;
        this.RecoveredTime = RecoveredTime;
        this.ProviderType = ProviderType;
        this.MediaSizeBytes = MediaSizeBytes;
        this.MediaType = MediaType;
        this.MediaSubtype = MediaSubtype;
        this.MediaSubject = MediaSubject;
        this.FileState = FileState;
        this.ProviderEndpoint = ProviderEndpoint;
        this.Recording = Recording;
        this.OrphanStatus = OrphanStatus;
        this.SourceOrphaningId = SourceOrphaningId;
        this.Region = Region;

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
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("createdTime")]
    public DateTime? CreatedTime { get; set; }



    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("recoveredTime")]
    public DateTime? RecoveredTime { get; set; }





    /// <summary>
    /// Gets or Sets MediaSizeBytes
    /// </summary>
    [JsonPropertyName("mediaSizeBytes")]
    public long? MediaSizeBytes { get; set; }







    /// <summary>
    /// Gets or Sets MediaSubject
    /// </summary>
    [JsonPropertyName("mediaSubject")]
    public string MediaSubject { get; set; }





    /// <summary>
    /// Gets or Sets ProviderEndpoint
    /// </summary>
    [JsonPropertyName("providerEndpoint")]
    public Endpoint ProviderEndpoint { get; set; }



    /// <summary>
    /// Gets or Sets Recording
    /// </summary>
    [JsonPropertyName("recording")]
    public Recording Recording { get; set; }





    /// <summary>
    /// An identifier used during recovery operations by the supplying hybrid platform to track back and determine which interaction this recording is associated with
    /// </summary>
    /// <value>An identifier used during recovery operations by the supplying hybrid platform to track back and determine which interaction this recording is associated with</value>
    [JsonPropertyName("sourceOrphaningId")]
    public string SourceOrphaningId { get; set; }





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
        sb.Append("class OrphanRecording {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  CreatedTime: ").Append(CreatedTime).Append("\n");
        sb.Append("  RecoveredTime: ").Append(RecoveredTime).Append("\n");
        sb.Append("  ProviderType: ").Append(ProviderType).Append("\n");
        sb.Append("  MediaSizeBytes: ").Append(MediaSizeBytes).Append("\n");
        sb.Append("  MediaType: ").Append(MediaType).Append("\n");
        sb.Append("  MediaSubtype: ").Append(MediaSubtype).Append("\n");
        sb.Append("  MediaSubject: ").Append(MediaSubject).Append("\n");
        sb.Append("  FileState: ").Append(FileState).Append("\n");
        sb.Append("  ProviderEndpoint: ").Append(ProviderEndpoint).Append("\n");
        sb.Append("  Recording: ").Append(Recording).Append("\n");
        sb.Append("  OrphanStatus: ").Append(OrphanStatus).Append("\n");
        sb.Append("  SourceOrphaningId: ").Append(SourceOrphaningId).Append("\n");
        sb.Append("  Region: ").Append(Region).Append("\n");
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
        return Equals(obj as OrphanRecording);
    }

    /// <summary>
    /// Returns true if OrphanRecording instances are equal
    /// </summary>
    /// <param name="other">Instance of OrphanRecording to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(OrphanRecording other)
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
                CreatedTime == other.CreatedTime ||
                CreatedTime != null &&
                CreatedTime.Equals(other.CreatedTime)
            ) &&
            (
                RecoveredTime == other.RecoveredTime ||
                RecoveredTime != null &&
                RecoveredTime.Equals(other.RecoveredTime)
            ) &&
            (
                ProviderType == other.ProviderType ||
                ProviderType != null &&
                ProviderType.Equals(other.ProviderType)
            ) &&
            (
                MediaSizeBytes == other.MediaSizeBytes ||
                MediaSizeBytes != null &&
                MediaSizeBytes.Equals(other.MediaSizeBytes)
            ) &&
            (
                MediaType == other.MediaType ||
                MediaType != null &&
                MediaType.Equals(other.MediaType)
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
                FileState == other.FileState ||
                FileState != null &&
                FileState.Equals(other.FileState)
            ) &&
            (
                ProviderEndpoint == other.ProviderEndpoint ||
                ProviderEndpoint != null &&
                ProviderEndpoint.Equals(other.ProviderEndpoint)
            ) &&
            (
                Recording == other.Recording ||
                Recording != null &&
                Recording.Equals(other.Recording)
            ) &&
            (
                OrphanStatus == other.OrphanStatus ||
                OrphanStatus != null &&
                OrphanStatus.Equals(other.OrphanStatus)
            ) &&
            (
                SourceOrphaningId == other.SourceOrphaningId ||
                SourceOrphaningId != null &&
                SourceOrphaningId.Equals(other.SourceOrphaningId)
            ) &&
            (
                Region == other.Region ||
                Region != null &&
                Region.Equals(other.Region)
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

            if (CreatedTime != null)
            {
                hash = hash * 59 + CreatedTime.GetHashCode();
            }

            if (RecoveredTime != null)
            {
                hash = hash * 59 + RecoveredTime.GetHashCode();
            }

            if (ProviderType != null)
            {
                hash = hash * 59 + ProviderType.GetHashCode();
            }

            if (MediaSizeBytes != null)
            {
                hash = hash * 59 + MediaSizeBytes.GetHashCode();
            }

            if (MediaType != null)
            {
                hash = hash * 59 + MediaType.GetHashCode();
            }

            if (MediaSubtype != null)
            {
                hash = hash * 59 + MediaSubtype.GetHashCode();
            }

            if (MediaSubject != null)
            {
                hash = hash * 59 + MediaSubject.GetHashCode();
            }

            if (FileState != null)
            {
                hash = hash * 59 + FileState.GetHashCode();
            }

            if (ProviderEndpoint != null)
            {
                hash = hash * 59 + ProviderEndpoint.GetHashCode();
            }

            if (Recording != null)
            {
                hash = hash * 59 + Recording.GetHashCode();
            }

            if (OrphanStatus != null)
            {
                hash = hash * 59 + OrphanStatus.GetHashCode();
            }

            if (SourceOrphaningId != null)
            {
                hash = hash * 59 + SourceOrphaningId.GetHashCode();
            }

            if (Region != null)
            {
                hash = hash * 59 + Region.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
