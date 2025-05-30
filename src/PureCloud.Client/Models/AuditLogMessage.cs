using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AuditLogMessage
/// </summary>

public partial class AuditLogMessage : IEquatable<AuditLogMessage>
{
    /// <summary>
    /// Level of this audit message, USER or SYSTEM.
    /// </summary>
    /// <value>Level of this audit message, USER or SYSTEM.</value>
    
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
        /// Enum User for "USER"
        /// </summary>
        [EnumMember(Value = "USER")]
        User,

        /// <summary>
        /// Enum System for "SYSTEM"
        /// </summary>
        [EnumMember(Value = "SYSTEM")]
        System,

        /// <summary>
        /// Enum GenesysInternal for "GENESYS_INTERNAL"
        /// </summary>
        [EnumMember(Value = "GENESYS_INTERNAL")]
        GenesysInternal
    }
    /// <summary>
    /// Status of the event being audited
    /// </summary>
    /// <value>Status of the event being audited</value>
    
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
        /// Enum Success for "SUCCESS"
        /// </summary>
        [EnumMember(Value = "SUCCESS")]
        Success,

        /// <summary>
        /// Enum Failure for "FAILURE"
        /// </summary>
        [EnumMember(Value = "FAILURE")]
        Failure,

        /// <summary>
        /// Enum Warning for "WARNING"
        /// </summary>
        [EnumMember(Value = "WARNING")]
        Warning
    }
    /// <summary>
    /// Level of this audit message, USER or SYSTEM.
    /// </summary>
    /// <value>Level of this audit message, USER or SYSTEM.</value>
    [JsonPropertyName("level")]
    public LevelEnum? Level { get; set; }
    /// <summary>
    /// Status of the event being audited
    /// </summary>
    /// <value>Status of the event being audited</value>
    [JsonPropertyName("status")]
    public StatusEnum? Status { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="AuditLogMessage" /> class.
    /// </summary>
    /// <param name="Id">Id of the audit message..</param>
    /// <param name="UserHomeOrgId">Home Organization Id associated with this audit message..</param>
    /// <param name="User">User associated with this audit message..</param>
    /// <param name="Client">Client associated with this audit message..</param>
    /// <param name="RemoteIp">List of IP addresses of systems that originated or handled the request..</param>
    /// <param name="ServiceName">Name of the service that logged this audit message..</param>
    /// <param name="Level">Level of this audit message, USER or SYSTEM..</param>
    /// <param name="EventDate">Date and time of when the audit message was logged. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="Message">Message describing the event being audited..</param>
    /// <param name="Action">Action that took place..</param>
    /// <param name="Entity">Entity that was impacted..</param>
    /// <param name="EntityType">Type of the entity that was impacted..</param>
    /// <param name="Status">Status of the event being audited.</param>
    /// <param name="Application">Name of the application used to perform the audit&#39;s action.</param>
    /// <param name="InitiatingAction">Id and action of the audit initiating the transaction.</param>
    /// <param name="TransactionInitiator">Whether the current audit is the initiator of the transaction.</param>
    /// <param name="PropertyChanges">List of properties that were changed and changes made to those properties..</param>
    /// <param name="Context">Additional context for this message..</param>
    /// <param name="EntityChanges">List of entities that were changed and changes made to those entities..</param>
    public AuditLogMessage(string Id = null, string UserHomeOrgId = null, DomainEntityRef User = null, AddressableEntityRef Client = null, List<string> RemoteIp = null, string ServiceName = null, LevelEnum? Level = null, DateTime? EventDate = null, MessageInfo Message = null, string Action = null, DomainEntityRef Entity = null, string EntityType = null, StatusEnum? Status = null, string Application = null, InitiatingAction InitiatingAction = null, bool? TransactionInitiator = null, List<PropertyChange> PropertyChanges = null, Dictionary<string, string> Context = null, List<EntityChange> EntityChanges = null)
    {
        this.Id = Id;
        this.UserHomeOrgId = UserHomeOrgId;
        this.User = User;
        this.Client = Client;
        this.RemoteIp = RemoteIp;
        this.ServiceName = ServiceName;
        this.Level = Level;
        this.EventDate = EventDate;
        this.Message = Message;
        this.Action = Action;
        this.Entity = Entity;
        this.EntityType = EntityType;
        this.Status = Status;
        this.Application = Application;
        this.InitiatingAction = InitiatingAction;
        this.TransactionInitiator = TransactionInitiator;
        this.PropertyChanges = PropertyChanges;
        this.Context = Context;
        this.EntityChanges = EntityChanges;

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
    [JsonPropertyName("remoteIp")]
    public List<string> RemoteIp { get; set; }



    /// <summary>
    /// Name of the service that logged this audit message.
    /// </summary>
    /// <value>Name of the service that logged this audit message.</value>
    [JsonPropertyName("serviceName")]
    public string ServiceName { get; set; }





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
    [JsonPropertyName("message")]
    public MessageInfo Message { get; set; }



    /// <summary>
    /// Action that took place.
    /// </summary>
    /// <value>Action that took place.</value>
    [JsonPropertyName("action")]
    public string Action { get; set; }



    /// <summary>
    /// Entity that was impacted.
    /// </summary>
    /// <value>Entity that was impacted.</value>
    [JsonPropertyName("entity")]
    public DomainEntityRef Entity { get; set; }



    /// <summary>
    /// Type of the entity that was impacted.
    /// </summary>
    /// <value>Type of the entity that was impacted.</value>
    [JsonPropertyName("entityType")]
    public string EntityType { get; set; }





    /// <summary>
    /// Name of the application used to perform the audit&#39;s action
    /// </summary>
    /// <value>Name of the application used to perform the audit&#39;s action</value>
    [JsonPropertyName("application")]
    public string Application { get; set; }



    /// <summary>
    /// Id and action of the audit initiating the transaction
    /// </summary>
    /// <value>Id and action of the audit initiating the transaction</value>
    [JsonPropertyName("initiatingAction")]
    public InitiatingAction InitiatingAction { get; set; }



    /// <summary>
    /// Whether the current audit is the initiator of the transaction
    /// </summary>
    /// <value>Whether the current audit is the initiator of the transaction</value>
    [JsonPropertyName("transactionInitiator")]
    public bool? TransactionInitiator { get; set; }



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
    /// List of entities that were changed and changes made to those entities.
    /// </summary>
    /// <value>List of entities that were changed and changes made to those entities.</value>
    [JsonPropertyName("entityChanges")]
    public List<EntityChange> EntityChanges { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AuditLogMessage {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  UserHomeOrgId: ").Append(UserHomeOrgId).Append("\n");
        sb.Append("  User: ").Append(User).Append("\n");
        sb.Append("  Client: ").Append(Client).Append("\n");
        sb.Append("  RemoteIp: ").Append(RemoteIp).Append("\n");
        sb.Append("  ServiceName: ").Append(ServiceName).Append("\n");
        sb.Append("  Level: ").Append(Level).Append("\n");
        sb.Append("  EventDate: ").Append(EventDate).Append("\n");
        sb.Append("  Message: ").Append(Message).Append("\n");
        sb.Append("  Action: ").Append(Action).Append("\n");
        sb.Append("  Entity: ").Append(Entity).Append("\n");
        sb.Append("  EntityType: ").Append(EntityType).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  Application: ").Append(Application).Append("\n");
        sb.Append("  InitiatingAction: ").Append(InitiatingAction).Append("\n");
        sb.Append("  TransactionInitiator: ").Append(TransactionInitiator).Append("\n");
        sb.Append("  PropertyChanges: ").Append(PropertyChanges).Append("\n");
        sb.Append("  Context: ").Append(Context).Append("\n");
        sb.Append("  EntityChanges: ").Append(EntityChanges).Append("\n");
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
        return Equals(obj as AuditLogMessage);
    }

    /// <summary>
    /// Returns true if AuditLogMessage instances are equal
    /// </summary>
    /// <param name="other">Instance of AuditLogMessage to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AuditLogMessage other)
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
                RemoteIp == other.RemoteIp ||
                RemoteIp != null &&
                RemoteIp.SequenceEqual(other.RemoteIp)
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
                EventDate == other.EventDate ||
                EventDate != null &&
                EventDate.Equals(other.EventDate)
            ) &&
            (
                Message == other.Message ||
                Message != null &&
                Message.Equals(other.Message)
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
                Status == other.Status ||
                Status != null &&
                Status.Equals(other.Status)
            ) &&
            (
                Application == other.Application ||
                Application != null &&
                Application.Equals(other.Application)
            ) &&
            (
                InitiatingAction == other.InitiatingAction ||
                InitiatingAction != null &&
                InitiatingAction.Equals(other.InitiatingAction)
            ) &&
            (
                TransactionInitiator == other.TransactionInitiator ||
                TransactionInitiator != null &&
                TransactionInitiator.Equals(other.TransactionInitiator)
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
            ) &&
            (
                EntityChanges == other.EntityChanges ||
                EntityChanges != null &&
                EntityChanges.SequenceEqual(other.EntityChanges)
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

            if (User != null)
            {
                hash = hash * 59 + User.GetHashCode();
            }

            if (Client != null)
            {
                hash = hash * 59 + Client.GetHashCode();
            }

            if (RemoteIp != null)
            {
                hash = hash * 59 + RemoteIp.GetHashCode();
            }

            if (ServiceName != null)
            {
                hash = hash * 59 + ServiceName.GetHashCode();
            }

            if (Level != null)
            {
                hash = hash * 59 + Level.GetHashCode();
            }

            if (EventDate != null)
            {
                hash = hash * 59 + EventDate.GetHashCode();
            }

            if (Message != null)
            {
                hash = hash * 59 + Message.GetHashCode();
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

            if (Status != null)
            {
                hash = hash * 59 + Status.GetHashCode();
            }

            if (Application != null)
            {
                hash = hash * 59 + Application.GetHashCode();
            }

            if (InitiatingAction != null)
            {
                hash = hash * 59 + InitiatingAction.GetHashCode();
            }

            if (TransactionInitiator != null)
            {
                hash = hash * 59 + TransactionInitiator.GetHashCode();
            }

            if (PropertyChanges != null)
            {
                hash = hash * 59 + PropertyChanges.GetHashCode();
            }

            if (Context != null)
            {
                hash = hash * 59 + Context.GetHashCode();
            }

            if (EntityChanges != null)
            {
                hash = hash * 59 + EntityChanges.GetHashCode();
            }

            return hash;
        }
    }
}
