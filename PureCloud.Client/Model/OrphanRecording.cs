using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model
{
    /// <summary>
    /// OrphanRecording
    /// </summary>
    [DataContract]
    public partial class OrphanRecording :  IEquatable<OrphanRecording>
    {
        /// <summary>
        /// Gets or Sets ProviderType
        /// </summary>
        [JsonConverter(typeof(JsonStringEnumConverter))]
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
        [JsonConverter(typeof(JsonStringEnumConverter))]
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
        /// Gets or Sets FileState
        /// </summary>
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
            Uploading
        }
        /// <summary>
        /// The status of the orphaned recording's conversation.
        /// </summary>
        /// <value>The status of the orphaned recording's conversation.</value>
        [JsonConverter(typeof(JsonStringEnumConverter))]
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
        [JsonConverter(typeof(JsonStringEnumConverter))]
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
        [DataMember(Name="providerType", EmitDefaultValue=false)]
        public ProviderTypeEnum? ProviderType { get; set; }
        /// <summary>
        /// Gets or Sets MediaType
        /// </summary>
        [DataMember(Name="mediaType", EmitDefaultValue=false)]
        public MediaTypeEnum? MediaType { get; set; }
        /// <summary>
        /// Gets or Sets MediaSubtype
        /// </summary>
        [DataMember(Name="mediaSubtype", EmitDefaultValue=false)]
        public MediaSubtypeEnum? MediaSubtype { get; set; }
        /// <summary>
        /// Gets or Sets FileState
        /// </summary>
        [DataMember(Name="fileState", EmitDefaultValue=false)]
        public FileStateEnum? FileState { get; set; }
        /// <summary>
        /// The status of the orphaned recording's conversation.
        /// </summary>
        /// <value>The status of the orphaned recording's conversation.</value>
        [DataMember(Name="orphanStatus", EmitDefaultValue=false)]
        public OrphanStatusEnum? OrphanStatus { get; set; }
        /// <summary>
        /// Gets or Sets Region
        /// </summary>
        [DataMember(Name="region", EmitDefaultValue=false)]
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
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="createdTime", EmitDefaultValue=false)]
        public DateTime? CreatedTime { get; set; }



        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="recoveredTime", EmitDefaultValue=false)]
        public DateTime? RecoveredTime { get; set; }





        /// <summary>
        /// Gets or Sets MediaSizeBytes
        /// </summary>
        [DataMember(Name="mediaSizeBytes", EmitDefaultValue=false)]
        public long? MediaSizeBytes { get; set; }







        /// <summary>
        /// Gets or Sets MediaSubject
        /// </summary>
        [DataMember(Name="mediaSubject", EmitDefaultValue=false)]
        public string MediaSubject { get; set; }





        /// <summary>
        /// Gets or Sets ProviderEndpoint
        /// </summary>
        [DataMember(Name="providerEndpoint", EmitDefaultValue=false)]
        public Endpoint ProviderEndpoint { get; set; }



        /// <summary>
        /// Gets or Sets Recording
        /// </summary>
        [DataMember(Name="recording", EmitDefaultValue=false)]
        public Recording Recording { get; set; }





        /// <summary>
        /// An identifier used during recovery operations by the supplying hybrid platform to track back and determine which interaction this recording is associated with
        /// </summary>
        /// <value>An identifier used during recovery operations by the supplying hybrid platform to track back and determine which interaction this recording is associated with</value>
        [DataMember(Name="sourceOrphaningId", EmitDefaultValue=false)]
        public string SourceOrphaningId { get; set; }





        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }


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
            return this.Equals(obj as OrphanRecording);
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
                return false;

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
                    this.CreatedTime == other.CreatedTime ||
                    this.CreatedTime != null &&
                    this.CreatedTime.Equals(other.CreatedTime)
                ) &&
                (
                    this.RecoveredTime == other.RecoveredTime ||
                    this.RecoveredTime != null &&
                    this.RecoveredTime.Equals(other.RecoveredTime)
                ) &&
                (
                    this.ProviderType == other.ProviderType ||
                    this.ProviderType != null &&
                    this.ProviderType.Equals(other.ProviderType)
                ) &&
                (
                    this.MediaSizeBytes == other.MediaSizeBytes ||
                    this.MediaSizeBytes != null &&
                    this.MediaSizeBytes.Equals(other.MediaSizeBytes)
                ) &&
                (
                    this.MediaType == other.MediaType ||
                    this.MediaType != null &&
                    this.MediaType.Equals(other.MediaType)
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
                    this.FileState == other.FileState ||
                    this.FileState != null &&
                    this.FileState.Equals(other.FileState)
                ) &&
                (
                    this.ProviderEndpoint == other.ProviderEndpoint ||
                    this.ProviderEndpoint != null &&
                    this.ProviderEndpoint.Equals(other.ProviderEndpoint)
                ) &&
                (
                    this.Recording == other.Recording ||
                    this.Recording != null &&
                    this.Recording.Equals(other.Recording)
                ) &&
                (
                    this.OrphanStatus == other.OrphanStatus ||
                    this.OrphanStatus != null &&
                    this.OrphanStatus.Equals(other.OrphanStatus)
                ) &&
                (
                    this.SourceOrphaningId == other.SourceOrphaningId ||
                    this.SourceOrphaningId != null &&
                    this.SourceOrphaningId.Equals(other.SourceOrphaningId)
                ) &&
                (
                    this.Region == other.Region ||
                    this.Region != null &&
                    this.Region.Equals(other.Region)
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
                    hash = hash * 59 + this.Id.GetHashCode();

                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                if (this.CreatedTime != null)
                    hash = hash * 59 + this.CreatedTime.GetHashCode();

                if (this.RecoveredTime != null)
                    hash = hash * 59 + this.RecoveredTime.GetHashCode();

                if (this.ProviderType != null)
                    hash = hash * 59 + this.ProviderType.GetHashCode();

                if (this.MediaSizeBytes != null)
                    hash = hash * 59 + this.MediaSizeBytes.GetHashCode();

                if (this.MediaType != null)
                    hash = hash * 59 + this.MediaType.GetHashCode();

                if (this.MediaSubtype != null)
                    hash = hash * 59 + this.MediaSubtype.GetHashCode();

                if (this.MediaSubject != null)
                    hash = hash * 59 + this.MediaSubject.GetHashCode();

                if (this.FileState != null)
                    hash = hash * 59 + this.FileState.GetHashCode();

                if (this.ProviderEndpoint != null)
                    hash = hash * 59 + this.ProviderEndpoint.GetHashCode();

                if (this.Recording != null)
                    hash = hash * 59 + this.Recording.GetHashCode();

                if (this.OrphanStatus != null)
                    hash = hash * 59 + this.OrphanStatus.GetHashCode();

                if (this.SourceOrphaningId != null)
                    hash = hash * 59 + this.SourceOrphaningId.GetHashCode();

                if (this.Region != null)
                    hash = hash * 59 + this.Region.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
