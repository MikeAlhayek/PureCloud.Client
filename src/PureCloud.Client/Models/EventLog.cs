using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// EventLog
/// </summary>

public partial class EventLog : IEquatable<EventLog>
{
    /// <summary>
    /// Gets or Sets Level
    /// </summary>
    
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
        /// Enum Info for "INFO"
        /// </summary>
        [EnumMember(Value = "INFO")]
        Info,

        /// <summary>
        /// Enum Warning for "WARNING"
        /// </summary>
        [EnumMember(Value = "WARNING")]
        Warning,

        /// <summary>
        /// Enum Error for "ERROR"
        /// </summary>
        [EnumMember(Value = "ERROR")]
        Error
    }
    /// <summary>
    /// Gets or Sets Category
    /// </summary>
    
    public enum CategoryEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Callback for "CALLBACK"
        /// </summary>
        [EnumMember(Value = "CALLBACK")]
        Callback,

        /// <summary>
        /// Enum CallRestriction for "CALL_RESTRICTION"
        /// </summary>
        [EnumMember(Value = "CALL_RESTRICTION")]
        CallRestriction,

        /// <summary>
        /// Enum CallRule for "CALL_RULE"
        /// </summary>
        [EnumMember(Value = "CALL_RULE")]
        CallRule,

        /// <summary>
        /// Enum Campaign for "CAMPAIGN"
        /// </summary>
        [EnumMember(Value = "CAMPAIGN")]
        Campaign,

        /// <summary>
        /// Enum CampaignRule for "CAMPAIGN_RULE"
        /// </summary>
        [EnumMember(Value = "CAMPAIGN_RULE")]
        CampaignRule,

        /// <summary>
        /// Enum Contact for "CONTACT"
        /// </summary>
        [EnumMember(Value = "CONTACT")]
        Contact,

        /// <summary>
        /// Enum ContactListFilter for "CONTACT_LIST_FILTER"
        /// </summary>
        [EnumMember(Value = "CONTACT_LIST_FILTER")]
        ContactListFilter,

        /// <summary>
        /// Enum DigitalRule for "DIGITAL_RULE"
        /// </summary>
        [EnumMember(Value = "DIGITAL_RULE")]
        DigitalRule,

        /// <summary>
        /// Enum DncList for "DNC_LIST"
        /// </summary>
        [EnumMember(Value = "DNC_LIST")]
        DncList,

        /// <summary>
        /// Enum EntityLimit for "ENTITY_LIMIT"
        /// </summary>
        [EnumMember(Value = "ENTITY_LIMIT")]
        EntityLimit,

        /// <summary>
        /// Enum ImportError for "IMPORT_ERROR"
        /// </summary>
        [EnumMember(Value = "IMPORT_ERROR")]
        ImportError,

        /// <summary>
        /// Enum MessageRestriction for "MESSAGE_RESTRICTION"
        /// </summary>
        [EnumMember(Value = "MESSAGE_RESTRICTION")]
        MessageRestriction,

        /// <summary>
        /// Enum MessagingCampaign for "MESSAGING_CAMPAIGN"
        /// </summary>
        [EnumMember(Value = "MESSAGING_CAMPAIGN")]
        MessagingCampaign,

        /// <summary>
        /// Enum ImportTemplate for "IMPORT_TEMPLATE"
        /// </summary>
        [EnumMember(Value = "IMPORT_TEMPLATE")]
        ImportTemplate,

        /// <summary>
        /// Enum OrganizationConfiguration for "ORGANIZATION_CONFIGURATION"
        /// </summary>
        [EnumMember(Value = "ORGANIZATION_CONFIGURATION")]
        OrganizationConfiguration,

        /// <summary>
        /// Enum Schedule for "SCHEDULE"
        /// </summary>
        [EnumMember(Value = "SCHEDULE")]
        Schedule,

        /// <summary>
        /// Enum MessagingCampaignSchedule for "MESSAGING_CAMPAIGN_SCHEDULE"
        /// </summary>
        [EnumMember(Value = "MESSAGING_CAMPAIGN_SCHEDULE")]
        MessagingCampaignSchedule,

        /// <summary>
        /// Enum EmailCampaignSchedule for "EMAIL_CAMPAIGN_SCHEDULE"
        /// </summary>
        [EnumMember(Value = "EMAIL_CAMPAIGN_SCHEDULE")]
        EmailCampaignSchedule
    }
    /// <summary>
    /// Gets or Sets Level
    /// </summary>
    [JsonPropertyName("level")]
    public LevelEnum? Level { get; set; }
    /// <summary>
    /// Gets or Sets Category
    /// </summary>
    [JsonPropertyName("category")]
    public CategoryEnum? Category { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="EventLog" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="ErrorEntity">ErrorEntity.</param>
    /// <param name="RelatedEntity">RelatedEntity.</param>
    /// <param name="Timestamp">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="Level">Level.</param>
    /// <param name="Category">Category.</param>
    /// <param name="CorrelationId">CorrelationId.</param>
    /// <param name="EventMessage">EventMessage.</param>
    public EventLog(string Name = null, DomainEntityRef ErrorEntity = null, DomainEntityRef RelatedEntity = null, DateTime? Timestamp = null, LevelEnum? Level = null, CategoryEnum? Category = null, string CorrelationId = null, EventMessage EventMessage = null)
    {
        this.Name = Name;
        this.ErrorEntity = ErrorEntity;
        this.RelatedEntity = RelatedEntity;
        this.Timestamp = Timestamp;
        this.Level = Level;
        this.Category = Category;
        this.CorrelationId = CorrelationId;
        this.EventMessage = EventMessage;

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
    /// Gets or Sets ErrorEntity
    /// </summary>
    [JsonPropertyName("errorEntity")]
    public DomainEntityRef ErrorEntity { get; set; }



    /// <summary>
    /// Gets or Sets RelatedEntity
    /// </summary>
    [JsonPropertyName("relatedEntity")]
    public DomainEntityRef RelatedEntity { get; set; }



    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("timestamp")]
    public DateTime? Timestamp { get; set; }







    /// <summary>
    /// Gets or Sets CorrelationId
    /// </summary>
    [JsonPropertyName("correlationId")]
    public string CorrelationId { get; set; }



    /// <summary>
    /// Gets or Sets EventMessage
    /// </summary>
    [JsonPropertyName("eventMessage")]
    public EventMessage EventMessage { get; set; }



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
        sb.Append("class EventLog {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  ErrorEntity: ").Append(ErrorEntity).Append("\n");
        sb.Append("  RelatedEntity: ").Append(RelatedEntity).Append("\n");
        sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
        sb.Append("  Level: ").Append(Level).Append("\n");
        sb.Append("  Category: ").Append(Category).Append("\n");
        sb.Append("  CorrelationId: ").Append(CorrelationId).Append("\n");
        sb.Append("  EventMessage: ").Append(EventMessage).Append("\n");
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
        return Equals(obj as EventLog);
    }

    /// <summary>
    /// Returns true if EventLog instances are equal
    /// </summary>
    /// <param name="other">Instance of EventLog to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(EventLog other)
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
                ErrorEntity == other.ErrorEntity ||
                ErrorEntity != null &&
                ErrorEntity.Equals(other.ErrorEntity)
            ) &&
            (
                RelatedEntity == other.RelatedEntity ||
                RelatedEntity != null &&
                RelatedEntity.Equals(other.RelatedEntity)
            ) &&
            (
                Timestamp == other.Timestamp ||
                Timestamp != null &&
                Timestamp.Equals(other.Timestamp)
            ) &&
            (
                Level == other.Level ||
                Level != null &&
                Level.Equals(other.Level)
            ) &&
            (
                Category == other.Category ||
                Category != null &&
                Category.Equals(other.Category)
            ) &&
            (
                CorrelationId == other.CorrelationId ||
                CorrelationId != null &&
                CorrelationId.Equals(other.CorrelationId)
            ) &&
            (
                EventMessage == other.EventMessage ||
                EventMessage != null &&
                EventMessage.Equals(other.EventMessage)
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

            if (ErrorEntity != null)
            {
                hash = hash * 59 + ErrorEntity.GetHashCode();
            }

            if (RelatedEntity != null)
            {
                hash = hash * 59 + RelatedEntity.GetHashCode();
            }

            if (Timestamp != null)
            {
                hash = hash * 59 + Timestamp.GetHashCode();
            }

            if (Level != null)
            {
                hash = hash * 59 + Level.GetHashCode();
            }

            if (Category != null)
            {
                hash = hash * 59 + Category.GetHashCode();
            }

            if (CorrelationId != null)
            {
                hash = hash * 59 + CorrelationId.GetHashCode();
            }

            if (EventMessage != null)
            {
                hash = hash * 59 + EventMessage.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
