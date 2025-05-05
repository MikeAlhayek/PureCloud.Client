using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// QualityAuditLogMessage
/// </summary>

public partial class QualityAuditLogMessage : IEquatable<QualityAuditLogMessage>
{
    /// <summary>
    /// Name of the service that logged this audit message.
    /// </summary>
    /// <value>Name of the service that logged this audit message.</value>
    
    public enum ServiceNameEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Recordingservice for "RecordingService"
        /// </summary>
        [EnumMember(Value = "RecordingService")]
        Recordingservice,

        /// <summary>
        /// Enum Recordingplaybackservice for "RecordingPlaybackService"
        /// </summary>
        [EnumMember(Value = "RecordingPlaybackService")]
        Recordingplaybackservice,

        /// <summary>
        /// Enum Qualityservice for "QualityService"
        /// </summary>
        [EnumMember(Value = "QualityService")]
        Qualityservice
    }
    /// <summary>
    /// The level of this audit message.
    /// </summary>
    /// <value>The level of this audit message.</value>
    
    public enum LevelEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum User for "User"
        /// </summary>
        [EnumMember(Value = "User")]
        User,

        /// <summary>
        /// Enum System for "System"
        /// </summary>
        [EnumMember(Value = "System")]
        System,

        /// <summary>
        /// Enum GenesysInternal for "GENESYS_INTERNAL"
        /// </summary>
        [EnumMember(Value = "GENESYS_INTERNAL")]
        GenesysInternal
    }
    /// <summary>
    /// The status of the action of this audit message.
    /// </summary>
    /// <value>The status of the action of this audit message.</value>
    
    public enum StatusEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Success for "Success"
        /// </summary>
        [EnumMember(Value = "Success")]
        Success,

        /// <summary>
        /// Enum Failure for "Failure"
        /// </summary>
        [EnumMember(Value = "Failure")]
        Failure,

        /// <summary>
        /// Enum Warning for "Warning"
        /// </summary>
        [EnumMember(Value = "Warning")]
        Warning
    }
    /// <summary>
    /// Action that took place.
    /// </summary>
    /// <value>Action that took place.</value>
    
    public enum ActionEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Read for "Read"
        /// </summary>
        [EnumMember(Value = "Read")]
        Read,

        /// <summary>
        /// Enum Create for "Create"
        /// </summary>
        [EnumMember(Value = "Create")]
        Create,

        /// <summary>
        /// Enum Update for "Update"
        /// </summary>
        [EnumMember(Value = "Update")]
        Update,

        /// <summary>
        /// Enum Delete for "Delete"
        /// </summary>
        [EnumMember(Value = "Delete")]
        Delete,

        /// <summary>
        /// Enum Abandon for "Abandon"
        /// </summary>
        [EnumMember(Value = "Abandon")]
        Abandon,

        /// <summary>
        /// Enum Archive for "Archive"
        /// </summary>
        [EnumMember(Value = "Archive")]
        Archive,

        /// <summary>
        /// Enum Export for "Export"
        /// </summary>
        [EnumMember(Value = "Export")]
        Export,

        /// <summary>
        /// Enum Download for "Download"
        /// </summary>
        [EnumMember(Value = "Download")]
        Download,

        /// <summary>
        /// Enum Restorerequest for "RestoreRequest"
        /// </summary>
        [EnumMember(Value = "RestoreRequest")]
        Restorerequest,

        /// <summary>
        /// Enum Restorecomplete for "RestoreComplete"
        /// </summary>
        [EnumMember(Value = "RestoreComplete")]
        Restorecomplete,

        /// <summary>
        /// Enum Applyprotection for "ApplyProtection"
        /// </summary>
        [EnumMember(Value = "ApplyProtection")]
        Applyprotection,

        /// <summary>
        /// Enum Revokeprotection for "RevokeProtection"
        /// </summary>
        [EnumMember(Value = "RevokeProtection")]
        Revokeprotection,

        /// <summary>
        /// Enum Updateretention for "UpdateRetention"
        /// </summary>
        [EnumMember(Value = "UpdateRetention")]
        Updateretention
    }
    /// <summary>
    /// Type of the entity that was impacted.
    /// </summary>
    /// <value>Type of the entity that was impacted.</value>
    
    public enum EntityTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Recording for "Recording"
        /// </summary>
        [EnumMember(Value = "Recording")]
        Recording,

        /// <summary>
        /// Enum Evaluation for "Evaluation"
        /// </summary>
        [EnumMember(Value = "Evaluation")]
        Evaluation,

        /// <summary>
        /// Enum Calibration for "Calibration"
        /// </summary>
        [EnumMember(Value = "Calibration")]
        Calibration,

        /// <summary>
        /// Enum Annotation for "Annotation"
        /// </summary>
        [EnumMember(Value = "Annotation")]
        Annotation,

        /// <summary>
        /// Enum Screenrecording for "ScreenRecording"
        /// </summary>
        [EnumMember(Value = "ScreenRecording")]
        Screenrecording,

        /// <summary>
        /// Enum Survey for "Survey"
        /// </summary>
        [EnumMember(Value = "Survey")]
        Survey
    }
    /// <summary>
    /// Name of the service that logged this audit message.
    /// </summary>
    /// <value>Name of the service that logged this audit message.</value>
    [JsonPropertyName("serviceName")]
    public ServiceNameEnum? ServiceName { get; set; }
    /// <summary>
    /// The level of this audit message.
    /// </summary>
    /// <value>The level of this audit message.</value>
    [JsonPropertyName("level")]
    public LevelEnum? Level { get; set; }
    /// <summary>
    /// The status of the action of this audit message.
    /// </summary>
    /// <value>The status of the action of this audit message.</value>
    [JsonPropertyName("status")]
    public StatusEnum? Status { get; set; }
    /// <summary>
    /// Action that took place.
    /// </summary>
    /// <value>Action that took place.</value>
    [JsonPropertyName("action")]
    public ActionEnum? Action { get; set; }
    /// <summary>
    /// Type of the entity that was impacted.
    /// </summary>
    /// <value>Type of the entity that was impacted.</value>
    [JsonPropertyName("entityType")]
    public EntityTypeEnum? EntityType { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="QualityAuditLogMessage" /> class.
    /// </summary>
    /// <param name="Id">Id of the audit message..</param>
    /// <param name="UserHomeOrgId">Home Organization Id associated with this audit message..</param>
    /// <param name="UserTrusteeOrgId">Trustee Organization Id if this audit message is from trustee access..</param>
    /// <param name="User">User associated with this audit message..</param>
    /// <param name="Client">Client associated with this audit message..</param>
    /// <param name="RemoteIps">List of IP addresses of systems that originated or handled the request..</param>
    /// <param name="ServiceName">Name of the service that logged this audit message..</param>
    /// <param name="Level">The level of this audit message..</param>
    /// <param name="Status">The status of the action of this audit message..</param>
    /// <param name="EventDate">Date and time of when the audit message was logged. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="MessageInfo">Message describing the event being audited..</param>
    /// <param name="Action">Action that took place..</param>
    /// <param name="Entity">Entity that was impacted..</param>
    /// <param name="EntityType">Type of the entity that was impacted..</param>
    /// <param name="PropertyChanges">List of properties that were changed and changes made to those properties..</param>
    /// <param name="Context">Additional context for this message..</param>
    public QualityAuditLogMessage(string Id = null, string UserHomeOrgId = null, string UserTrusteeOrgId = null, DomainEntityRef User = null, AddressableEntityRef Client = null, List<string> RemoteIps = null, ServiceNameEnum? ServiceName = null, LevelEnum? Level = null, StatusEnum? Status = null, DateTime? EventDate = null, MessageInfo MessageInfo = null, ActionEnum? Action = null, DomainEntityRef Entity = null, EntityTypeEnum? EntityType = null, List<PropertyChange> PropertyChanges = null, Dictionary<string, string> Context = null)
    {
        this.Id = Id;
        this.UserHomeOrgId = UserHomeOrgId;
        this.UserTrusteeOrgId = UserTrusteeOrgId;
        this.User = User;
        this.Client = Client;
        this.RemoteIps = RemoteIps;
        this.ServiceName = ServiceName;
        this.Level = Level;
        this.Status = Status;
        this.EventDate = EventDate;
        this.MessageInfo = MessageInfo;
        this.Action = Action;
        this.Entity = Entity;
        this.EntityType = EntityType;
        this.PropertyChanges = PropertyChanges;
        this.Context = Context;

    }



    /// <summary>
    /// Id of the audit message.
    /// </summary>
    /// <value>Id of the audit message.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// Home Organization Id associated with this audit message.
    /// </summary>
    /// <value>Home Organization Id associated with this audit message.</value>
    [JsonPropertyName("userHomeOrgId")]
    public string UserHomeOrgId { get; set; }



    /// <summary>
    /// Trustee Organization Id if this audit message is from trustee access.
    /// </summary>
    /// <value>Trustee Organization Id if this audit message is from trustee access.</value>
    [JsonPropertyName("userTrusteeOrgId")]
    public string UserTrusteeOrgId { get; set; }



    /// <summary>
    /// User associated with this audit message.
    /// </summary>
    /// <value>User associated with this audit message.</value>
    [JsonPropertyName("user")]
    public DomainEntityRef User { get; set; }



    /// <summary>
    /// Client associated with this audit message.
    /// </summary>
    /// <value>Client associated with this audit message.</value>
    [JsonPropertyName("client")]
    public AddressableEntityRef Client { get; set; }



    /// <summary>
    /// List of IP addresses of systems that originated or handled the request.
    /// </summary>
    /// <value>List of IP addresses of systems that originated or handled the request.</value>
    [JsonPropertyName("remoteIps")]
    public List<string> RemoteIps { get; set; }









    /// <summary>
    /// Date and time of when the audit message was logged. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date and time of when the audit message was logged. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("eventDate")]
    public DateTime? EventDate { get; set; }



    /// <summary>
    /// Message describing the event being audited.
    /// </summary>
    /// <value>Message describing the event being audited.</value>
    [JsonPropertyName("messageInfo")]
    public MessageInfo MessageInfo { get; set; }





    /// <summary>
    /// Entity that was impacted.
    /// </summary>
    /// <value>Entity that was impacted.</value>
    [JsonPropertyName("entity")]
    public DomainEntityRef Entity { get; set; }





    /// <summary>
    /// List of properties that were changed and changes made to those properties.
    /// </summary>
    /// <value>List of properties that were changed and changes made to those properties.</value>
    [JsonPropertyName("propertyChanges")]
    public List<PropertyChange> PropertyChanges { get; set; }



    /// <summary>
    /// Additional context for this message.
    /// </summary>
    /// <value>Additional context for this message.</value>
    [JsonPropertyName("context")]
    public Dictionary<string, string> Context { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class QualityAuditLogMessage {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  UserHomeOrgId: ").Append(UserHomeOrgId).Append("\n");
        sb.Append("  UserTrusteeOrgId: ").Append(UserTrusteeOrgId).Append("\n");
        sb.Append("  User: ").Append(User).Append("\n");
        sb.Append("  Client: ").Append(Client).Append("\n");
        sb.Append("  RemoteIps: ").Append(RemoteIps).Append("\n");
        sb.Append("  ServiceName: ").Append(ServiceName).Append("\n");
        sb.Append("  Level: ").Append(Level).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  EventDate: ").Append(EventDate).Append("\n");
        sb.Append("  MessageInfo: ").Append(MessageInfo).Append("\n");
        sb.Append("  Action: ").Append(Action).Append("\n");
        sb.Append("  Entity: ").Append(Entity).Append("\n");
        sb.Append("  EntityType: ").Append(EntityType).Append("\n");
        sb.Append("  PropertyChanges: ").Append(PropertyChanges).Append("\n");
        sb.Append("  Context: ").Append(Context).Append("\n");
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
        return Equals(obj as QualityAuditLogMessage);
    }

    /// <summary>
    /// Returns true if QualityAuditLogMessage instances are equal
    /// </summary>
    /// <param name="other">Instance of QualityAuditLogMessage to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(QualityAuditLogMessage other)
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
                UserHomeOrgId == other.UserHomeOrgId ||
                UserHomeOrgId != null &&
                UserHomeOrgId.Equals(other.UserHomeOrgId)
            ) &&
            (
                UserTrusteeOrgId == other.UserTrusteeOrgId ||
                UserTrusteeOrgId != null &&
                UserTrusteeOrgId.Equals(other.UserTrusteeOrgId)
            ) &&
            (
                User == other.User ||
                User != null &&
                User.Equals(other.User)
            ) &&
            (
                Client == other.Client ||
                Client != null &&
                Client.Equals(other.Client)
            ) &&
            (
                RemoteIps == other.RemoteIps ||
                RemoteIps != null &&
                RemoteIps.SequenceEqual(other.RemoteIps)
            ) &&
            (
                ServiceName == other.ServiceName ||
                ServiceName != null &&
                ServiceName.Equals(other.ServiceName)
            ) &&
            (
                Level == other.Level ||
                Level != null &&
                Level.Equals(other.Level)
            ) &&
            (
                Status == other.Status ||
                Status != null &&
                Status.Equals(other.Status)
            ) &&
            (
                EventDate == other.EventDate ||
                EventDate != null &&
                EventDate.Equals(other.EventDate)
            ) &&
            (
                MessageInfo == other.MessageInfo ||
                MessageInfo != null &&
                MessageInfo.Equals(other.MessageInfo)
            ) &&
            (
                Action == other.Action ||
                Action != null &&
                Action.Equals(other.Action)
            ) &&
            (
                Entity == other.Entity ||
                Entity != null &&
                Entity.Equals(other.Entity)
            ) &&
            (
                EntityType == other.EntityType ||
                EntityType != null &&
                EntityType.Equals(other.EntityType)
            ) &&
            (
                PropertyChanges == other.PropertyChanges ||
                PropertyChanges != null &&
                PropertyChanges.SequenceEqual(other.PropertyChanges)
            ) &&
            (
                Context == other.Context ||
                Context != null &&
                Context.SequenceEqual(other.Context)
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

            if (UserHomeOrgId != null)
            {
                hash = hash * 59 + UserHomeOrgId.GetHashCode();
            }

            if (UserTrusteeOrgId != null)
            {
                hash = hash * 59 + UserTrusteeOrgId.GetHashCode();
            }

            if (User != null)
            {
                hash = hash * 59 + User.GetHashCode();
            }

            if (Client != null)
            {
                hash = hash * 59 + Client.GetHashCode();
            }

            if (RemoteIps != null)
            {
                hash = hash * 59 + RemoteIps.GetHashCode();
            }

            if (ServiceName != null)
            {
                hash = hash * 59 + ServiceName.GetHashCode();
            }

            if (Level != null)
            {
                hash = hash * 59 + Level.GetHashCode();
            }

            if (Status != null)
            {
                hash = hash * 59 + Status.GetHashCode();
            }

            if (EventDate != null)
            {
                hash = hash * 59 + EventDate.GetHashCode();
            }

            if (MessageInfo != null)
            {
                hash = hash * 59 + MessageInfo.GetHashCode();
            }

            if (Action != null)
            {
                hash = hash * 59 + Action.GetHashCode();
            }

            if (Entity != null)
            {
                hash = hash * 59 + Entity.GetHashCode();
            }

            if (EntityType != null)
            {
                hash = hash * 59 + EntityType.GetHashCode();
            }

            if (PropertyChanges != null)
            {
                hash = hash * 59 + PropertyChanges.GetHashCode();
            }

            if (Context != null)
            {
                hash = hash * 59 + Context.GetHashCode();
            }

            return hash;
        }
    }
}
