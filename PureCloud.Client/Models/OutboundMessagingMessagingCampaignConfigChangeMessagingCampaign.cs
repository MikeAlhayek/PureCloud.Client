using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// OutboundMessagingMessagingCampaignConfigChangeMessagingCampaign
/// </summary>
[DataContract]
public partial class OutboundMessagingMessagingCampaignConfigChangeMessagingCampaign : IEquatable<OutboundMessagingMessagingCampaignConfigChangeMessagingCampaign>
{
    /// <summary>
    /// Gets or Sets CampaignStatus
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum CampaignStatusEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum On for "on"
        /// </summary>
        [EnumMember(Value = "on")]
        On,

        /// <summary>
        /// Enum Off for "off"
        /// </summary>
        [EnumMember(Value = "off")]
        Off,

        /// <summary>
        /// Enum Complete for "complete"
        /// </summary>
        [EnumMember(Value = "complete")]
        Complete,

        /// <summary>
        /// Enum Stopping for "stopping"
        /// </summary>
        [EnumMember(Value = "stopping")]
        Stopping,

        /// <summary>
        /// Enum Invalid for "invalid"
        /// </summary>
        [EnumMember(Value = "invalid")]
        Invalid
    }
    /// <summary>
    /// Gets or Sets CampaignStatus
    /// </summary>
    [DataMember(Name = "campaignStatus", EmitDefaultValue = false)]
    public CampaignStatusEnum? CampaignStatus { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="OutboundMessagingMessagingCampaignConfigChangeMessagingCampaign" /> class.
    /// </summary>
    /// <param name="CampaignStatus">CampaignStatus.</param>
    /// <param name="CallableTimeSet">CallableTimeSet.</param>
    /// <param name="ContactList">A UriReference for a resource.</param>
    /// <param name="DncLists">The dnc lists to check before sending a message for this messaging campaign..</param>
    /// <param name="ContactListFilters">The contact list filters to check before sending a message for this messaging campaign..</param>
    /// <param name="AlwaysRunning">Whether this messaging campaign is always running..</param>
    /// <param name="ContactSorts">The order in which to sort contacts for dialing, based on up to four columns..</param>
    /// <param name="MessagesPerMinute">How many messages this messaging campaign will send per minute..</param>
    /// <param name="RuleSets">RuleSets.</param>
    /// <param name="SmsConfig">SmsConfig.</param>
    /// <param name="EmailConfig">EmailConfig.</param>
    /// <param name="WhatsAppConfig">WhatsAppConfig.</param>
    /// <param name="Errors">A list of current error conditions associated with this messaging campaign.</param>
    /// <param name="Id">The globally unique identifier for the object..</param>
    /// <param name="Name">The UI-visible name of the object.</param>
    /// <param name="DateCreated">Creation time of the entity.</param>
    /// <param name="DateModified">Last modified time of the entity.</param>
    /// <param name="Version">Required for updates, must match the version number of the most recent update.</param>
    /// <param name="Division">A UriReference for a resource.</param>
    public OutboundMessagingMessagingCampaignConfigChangeMessagingCampaign(CampaignStatusEnum? CampaignStatus = null, OutboundMessagingMessagingCampaignConfigChangeUriReference CallableTimeSet = null, OutboundMessagingMessagingCampaignConfigChangeUriReference ContactList = null, List<OutboundMessagingMessagingCampaignConfigChangeUriReference> DncLists = null, List<OutboundMessagingMessagingCampaignConfigChangeUriReference> ContactListFilters = null, bool? AlwaysRunning = null, List<OutboundMessagingMessagingCampaignConfigChangeContactSort> ContactSorts = null, long? MessagesPerMinute = null, List<OutboundMessagingMessagingCampaignConfigChangeUriReference> RuleSets = null, OutboundMessagingMessagingCampaignConfigChangeSmsConfig SmsConfig = null, OutboundMessagingMessagingCampaignConfigChangeEmailConfig EmailConfig = null, OutboundMessagingMessagingCampaignConfigChangeWhatsAppConfig WhatsAppConfig = null, List<OutboundMessagingMessagingCampaignConfigChangeErrorDetail> Errors = null, string Id = null, string Name = null, DateTime? DateCreated = null, DateTime? DateModified = null, long? Version = null, OutboundMessagingMessagingCampaignConfigChangeUriReference Division = null)
    {
        this.CampaignStatus = CampaignStatus;
        this.CallableTimeSet = CallableTimeSet;
        this.ContactList = ContactList;
        this.DncLists = DncLists;
        this.ContactListFilters = ContactListFilters;
        this.AlwaysRunning = AlwaysRunning;
        this.ContactSorts = ContactSorts;
        this.MessagesPerMinute = MessagesPerMinute;
        this.RuleSets = RuleSets;
        this.SmsConfig = SmsConfig;
        this.EmailConfig = EmailConfig;
        this.WhatsAppConfig = WhatsAppConfig;
        this.Errors = Errors;
        this.Id = Id;
        this.Name = Name;
        this.DateCreated = DateCreated;
        this.DateModified = DateModified;
        this.Version = Version;
        this.Division = Division;

    }





    /// <summary>
    /// Gets or Sets CallableTimeSet
    /// </summary>
    [DataMember(Name = "callableTimeSet", EmitDefaultValue = false)]
    public OutboundMessagingMessagingCampaignConfigChangeUriReference CallableTimeSet { get; set; }



    /// <summary>
    /// A UriReference for a resource
    /// </summary>
    /// <value>A UriReference for a resource</value>
    [DataMember(Name = "contactList", EmitDefaultValue = false)]
    public OutboundMessagingMessagingCampaignConfigChangeUriReference ContactList { get; set; }



    /// <summary>
    /// The dnc lists to check before sending a message for this messaging campaign.
    /// </summary>
    /// <value>The dnc lists to check before sending a message for this messaging campaign.</value>
    [DataMember(Name = "dncLists", EmitDefaultValue = false)]
    public List<OutboundMessagingMessagingCampaignConfigChangeUriReference> DncLists { get; set; }



    /// <summary>
    /// The contact list filters to check before sending a message for this messaging campaign.
    /// </summary>
    /// <value>The contact list filters to check before sending a message for this messaging campaign.</value>
    [DataMember(Name = "contactListFilters", EmitDefaultValue = false)]
    public List<OutboundMessagingMessagingCampaignConfigChangeUriReference> ContactListFilters { get; set; }



    /// <summary>
    /// Whether this messaging campaign is always running.
    /// </summary>
    /// <value>Whether this messaging campaign is always running.</value>
    [DataMember(Name = "alwaysRunning", EmitDefaultValue = false)]
    public bool? AlwaysRunning { get; set; }



    /// <summary>
    /// The order in which to sort contacts for dialing, based on up to four columns.
    /// </summary>
    /// <value>The order in which to sort contacts for dialing, based on up to four columns.</value>
    [DataMember(Name = "contactSorts", EmitDefaultValue = false)]
    public List<OutboundMessagingMessagingCampaignConfigChangeContactSort> ContactSorts { get; set; }



    /// <summary>
    /// How many messages this messaging campaign will send per minute.
    /// </summary>
    /// <value>How many messages this messaging campaign will send per minute.</value>
    [DataMember(Name = "messagesPerMinute", EmitDefaultValue = false)]
    public long? MessagesPerMinute { get; set; }



    /// <summary>
    /// Gets or Sets RuleSets
    /// </summary>
    [DataMember(Name = "ruleSets", EmitDefaultValue = false)]
    public List<OutboundMessagingMessagingCampaignConfigChangeUriReference> RuleSets { get; set; }



    /// <summary>
    /// Gets or Sets SmsConfig
    /// </summary>
    [DataMember(Name = "smsConfig", EmitDefaultValue = false)]
    public OutboundMessagingMessagingCampaignConfigChangeSmsConfig SmsConfig { get; set; }



    /// <summary>
    /// Gets or Sets EmailConfig
    /// </summary>
    [DataMember(Name = "emailConfig", EmitDefaultValue = false)]
    public OutboundMessagingMessagingCampaignConfigChangeEmailConfig EmailConfig { get; set; }



    /// <summary>
    /// Gets or Sets WhatsAppConfig
    /// </summary>
    [DataMember(Name = "whatsAppConfig", EmitDefaultValue = false)]
    public OutboundMessagingMessagingCampaignConfigChangeWhatsAppConfig WhatsAppConfig { get; set; }



    /// <summary>
    /// A list of current error conditions associated with this messaging campaign
    /// </summary>
    /// <value>A list of current error conditions associated with this messaging campaign</value>
    [DataMember(Name = "errors", EmitDefaultValue = false)]
    public List<OutboundMessagingMessagingCampaignConfigChangeErrorDetail> Errors { get; set; }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }



    /// <summary>
    /// The UI-visible name of the object
    /// </summary>
    /// <value>The UI-visible name of the object</value>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }



    /// <summary>
    /// Creation time of the entity
    /// </summary>
    /// <value>Creation time of the entity</value>
    [DataMember(Name = "dateCreated", EmitDefaultValue = false)]
    public DateTime? DateCreated { get; set; }



    /// <summary>
    /// Last modified time of the entity
    /// </summary>
    /// <value>Last modified time of the entity</value>
    [DataMember(Name = "dateModified", EmitDefaultValue = false)]
    public DateTime? DateModified { get; set; }



    /// <summary>
    /// Required for updates, must match the version number of the most recent update
    /// </summary>
    /// <value>Required for updates, must match the version number of the most recent update</value>
    [DataMember(Name = "version", EmitDefaultValue = false)]
    public long? Version { get; set; }



    /// <summary>
    /// A UriReference for a resource
    /// </summary>
    /// <value>A UriReference for a resource</value>
    [DataMember(Name = "division", EmitDefaultValue = false)]
    public OutboundMessagingMessagingCampaignConfigChangeUriReference Division { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class OutboundMessagingMessagingCampaignConfigChangeMessagingCampaign {\n");

        sb.Append("  CampaignStatus: ").Append(CampaignStatus).Append("\n");
        sb.Append("  CallableTimeSet: ").Append(CallableTimeSet).Append("\n");
        sb.Append("  ContactList: ").Append(ContactList).Append("\n");
        sb.Append("  DncLists: ").Append(DncLists).Append("\n");
        sb.Append("  ContactListFilters: ").Append(ContactListFilters).Append("\n");
        sb.Append("  AlwaysRunning: ").Append(AlwaysRunning).Append("\n");
        sb.Append("  ContactSorts: ").Append(ContactSorts).Append("\n");
        sb.Append("  MessagesPerMinute: ").Append(MessagesPerMinute).Append("\n");
        sb.Append("  RuleSets: ").Append(RuleSets).Append("\n");
        sb.Append("  SmsConfig: ").Append(SmsConfig).Append("\n");
        sb.Append("  EmailConfig: ").Append(EmailConfig).Append("\n");
        sb.Append("  WhatsAppConfig: ").Append(WhatsAppConfig).Append("\n");
        sb.Append("  Errors: ").Append(Errors).Append("\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  DateModified: ").Append(DateModified).Append("\n");
        sb.Append("  Version: ").Append(Version).Append("\n");
        sb.Append("  Division: ").Append(Division).Append("\n");
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
        return Equals(obj as OutboundMessagingMessagingCampaignConfigChangeMessagingCampaign);
    }

    /// <summary>
    /// Returns true if OutboundMessagingMessagingCampaignConfigChangeMessagingCampaign instances are equal
    /// </summary>
    /// <param name="other">Instance of OutboundMessagingMessagingCampaignConfigChangeMessagingCampaign to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(OutboundMessagingMessagingCampaignConfigChangeMessagingCampaign other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                CampaignStatus == other.CampaignStatus ||
                CampaignStatus != null &&
                CampaignStatus.Equals(other.CampaignStatus)
            ) &&
            (
                CallableTimeSet == other.CallableTimeSet ||
                CallableTimeSet != null &&
                CallableTimeSet.Equals(other.CallableTimeSet)
            ) &&
            (
                ContactList == other.ContactList ||
                ContactList != null &&
                ContactList.Equals(other.ContactList)
            ) &&
            (
                DncLists == other.DncLists ||
                DncLists != null &&
                DncLists.SequenceEqual(other.DncLists)
            ) &&
            (
                ContactListFilters == other.ContactListFilters ||
                ContactListFilters != null &&
                ContactListFilters.SequenceEqual(other.ContactListFilters)
            ) &&
            (
                AlwaysRunning == other.AlwaysRunning ||
                AlwaysRunning != null &&
                AlwaysRunning.Equals(other.AlwaysRunning)
            ) &&
            (
                ContactSorts == other.ContactSorts ||
                ContactSorts != null &&
                ContactSorts.SequenceEqual(other.ContactSorts)
            ) &&
            (
                MessagesPerMinute == other.MessagesPerMinute ||
                MessagesPerMinute != null &&
                MessagesPerMinute.Equals(other.MessagesPerMinute)
            ) &&
            (
                RuleSets == other.RuleSets ||
                RuleSets != null &&
                RuleSets.SequenceEqual(other.RuleSets)
            ) &&
            (
                SmsConfig == other.SmsConfig ||
                SmsConfig != null &&
                SmsConfig.Equals(other.SmsConfig)
            ) &&
            (
                EmailConfig == other.EmailConfig ||
                EmailConfig != null &&
                EmailConfig.Equals(other.EmailConfig)
            ) &&
            (
                WhatsAppConfig == other.WhatsAppConfig ||
                WhatsAppConfig != null &&
                WhatsAppConfig.Equals(other.WhatsAppConfig)
            ) &&
            (
                Errors == other.Errors ||
                Errors != null &&
                Errors.SequenceEqual(other.Errors)
            ) &&
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
                DateCreated == other.DateCreated ||
                DateCreated != null &&
                DateCreated.Equals(other.DateCreated)
            ) &&
            (
                DateModified == other.DateModified ||
                DateModified != null &&
                DateModified.Equals(other.DateModified)
            ) &&
            (
                Version == other.Version ||
                Version != null &&
                Version.Equals(other.Version)
            ) &&
            (
                Division == other.Division ||
                Division != null &&
                Division.Equals(other.Division)
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
            if (CampaignStatus != null)
            {
                hash = hash * 59 + CampaignStatus.GetHashCode();
            }

            if (CallableTimeSet != null)
            {
                hash = hash * 59 + CallableTimeSet.GetHashCode();
            }

            if (ContactList != null)
            {
                hash = hash * 59 + ContactList.GetHashCode();
            }

            if (DncLists != null)
            {
                hash = hash * 59 + DncLists.GetHashCode();
            }

            if (ContactListFilters != null)
            {
                hash = hash * 59 + ContactListFilters.GetHashCode();
            }

            if (AlwaysRunning != null)
            {
                hash = hash * 59 + AlwaysRunning.GetHashCode();
            }

            if (ContactSorts != null)
            {
                hash = hash * 59 + ContactSorts.GetHashCode();
            }

            if (MessagesPerMinute != null)
            {
                hash = hash * 59 + MessagesPerMinute.GetHashCode();
            }

            if (RuleSets != null)
            {
                hash = hash * 59 + RuleSets.GetHashCode();
            }

            if (SmsConfig != null)
            {
                hash = hash * 59 + SmsConfig.GetHashCode();
            }

            if (EmailConfig != null)
            {
                hash = hash * 59 + EmailConfig.GetHashCode();
            }

            if (WhatsAppConfig != null)
            {
                hash = hash * 59 + WhatsAppConfig.GetHashCode();
            }

            if (Errors != null)
            {
                hash = hash * 59 + Errors.GetHashCode();
            }

            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (DateCreated != null)
            {
                hash = hash * 59 + DateCreated.GetHashCode();
            }

            if (DateModified != null)
            {
                hash = hash * 59 + DateModified.GetHashCode();
            }

            if (Version != null)
            {
                hash = hash * 59 + Version.GetHashCode();
            }

            if (Division != null)
            {
                hash = hash * 59 + Division.GetHashCode();
            }

            return hash;
        }
    }
}
