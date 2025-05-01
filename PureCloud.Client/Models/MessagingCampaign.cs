using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// MessagingCampaign
/// </summary>
[DataContract]
public partial class MessagingCampaign : IEquatable<MessagingCampaign>
{
    /// <summary>
    /// The current status of the messaging campaign. A messaging campaign may be turned 'on' or 'off'.
    /// </summary>
    /// <value>The current status of the messaging campaign. A messaging campaign may be turned 'on' or 'off'.</value>
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
        /// Enum Stopping for "stopping"
        /// </summary>
        [EnumMember(Value = "stopping")]
        Stopping,

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
        /// Enum Invalid for "invalid"
        /// </summary>
        [EnumMember(Value = "invalid")]
        Invalid,

        /// <summary>
        /// Enum ForcedOff for "forced_off"
        /// </summary>
        [EnumMember(Value = "forced_off")]
        ForcedOff,

        /// <summary>
        /// Enum ForcedStopping for "forced_stopping"
        /// </summary>
        [EnumMember(Value = "forced_stopping")]
        ForcedStopping
    }
    /// <summary>
    /// The current status of the messaging campaign. A messaging campaign may be turned 'on' or 'off'.
    /// </summary>
    /// <value>The current status of the messaging campaign. A messaging campaign may be turned 'on' or 'off'.</value>
    [DataMember(Name = "campaignStatus", EmitDefaultValue = false)]
    public CampaignStatusEnum? CampaignStatus { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="MessagingCampaign" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected MessagingCampaign() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="MessagingCampaign" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="Version">Required for updates, must match the version number of the most recent update.</param>
    /// <param name="Division">The division this entity belongs to..</param>
    /// <param name="CampaignStatus">The current status of the messaging campaign. A messaging campaign may be turned &#39;on&#39; or &#39;off&#39;..</param>
    /// <param name="CallableTimeSet">The callable time set for this messaging campaign..</param>
    /// <param name="ContactList">The contact list that this messaging campaign will send messages for. (required).</param>
    /// <param name="DncLists">The dnc lists to check before sending a message for this messaging campaign..</param>
    /// <param name="AlwaysRunning">Whether this messaging campaign is always running.</param>
    /// <param name="ContactSorts">The order in which to sort contacts for dialing, based on up to four columns..</param>
    /// <param name="MessagesPerMinute">How many messages this messaging campaign will send per minute. (required).</param>
    /// <param name="RuleSets">Rule Sets to be applied while this campaign is sending messages.</param>
    /// <param name="ContactListFilters">The contact list filter to check before sending a message for this messaging campaign..</param>
    /// <param name="Errors">A list of current error conditions associated with this messaging campaign..</param>
    /// <param name="DynamicContactQueueingSettings">Indicates (when true) that the campaign supports dynamic queueing of the contact list at the time of a request for contacts..</param>
    /// <param name="EmailConfig">Configuration for this messaging campaign to send Email messages..</param>
    /// <param name="SmsConfig">Configuration for this messaging campaign to send SMS messages..</param>
    /// <param name="WhatsAppConfig">Configuration for this messaging campaign to send WhatsApp messages..</param>
    public MessagingCampaign(string Name = null, int? Version = null, DomainEntityRef Division = null, CampaignStatusEnum? CampaignStatus = null, DomainEntityRef CallableTimeSet = null, DomainEntityRef ContactList = null, List<DomainEntityRef> DncLists = null, bool? AlwaysRunning = null, List<ContactSort> ContactSorts = null, int? MessagesPerMinute = null, List<DomainEntityRef> RuleSets = null, List<DomainEntityRef> ContactListFilters = null, List<RestErrorDetail> Errors = null, DynamicContactQueueingSettings DynamicContactQueueingSettings = null, EmailConfig EmailConfig = null, SmsConfig SmsConfig = null, WhatsAppConfig WhatsAppConfig = null)
    {
        this.Name = Name;
        this.Version = Version;
        this.Division = Division;
        this.CampaignStatus = CampaignStatus;
        this.CallableTimeSet = CallableTimeSet;
        this.ContactList = ContactList;
        this.DncLists = DncLists;
        this.AlwaysRunning = AlwaysRunning;
        this.ContactSorts = ContactSorts;
        this.MessagesPerMinute = MessagesPerMinute;
        this.RuleSets = RuleSets;
        this.ContactListFilters = ContactListFilters;
        this.Errors = Errors;
        this.DynamicContactQueueingSettings = DynamicContactQueueingSettings;
        this.EmailConfig = EmailConfig;
        this.SmsConfig = SmsConfig;
        this.WhatsAppConfig = WhatsAppConfig;

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
    /// Creation time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Creation time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "dateCreated", EmitDefaultValue = false)]
    public DateTime? DateCreated { get; private set; }



    /// <summary>
    /// Last modified time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Last modified time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "dateModified", EmitDefaultValue = false)]
    public DateTime? DateModified { get; private set; }



    /// <summary>
    /// Required for updates, must match the version number of the most recent update
    /// </summary>
    /// <value>Required for updates, must match the version number of the most recent update</value>
    [DataMember(Name = "version", EmitDefaultValue = false)]
    public int? Version { get; set; }



    /// <summary>
    /// The division this entity belongs to.
    /// </summary>
    /// <value>The division this entity belongs to.</value>
    [DataMember(Name = "division", EmitDefaultValue = false)]
    public DomainEntityRef Division { get; set; }





    /// <summary>
    /// The callable time set for this messaging campaign.
    /// </summary>
    /// <value>The callable time set for this messaging campaign.</value>
    [DataMember(Name = "callableTimeSet", EmitDefaultValue = false)]
    public DomainEntityRef CallableTimeSet { get; set; }



    /// <summary>
    /// The contact list that this messaging campaign will send messages for.
    /// </summary>
    /// <value>The contact list that this messaging campaign will send messages for.</value>
    [DataMember(Name = "contactList", EmitDefaultValue = false)]
    public DomainEntityRef ContactList { get; set; }



    /// <summary>
    /// The dnc lists to check before sending a message for this messaging campaign.
    /// </summary>
    /// <value>The dnc lists to check before sending a message for this messaging campaign.</value>
    [DataMember(Name = "dncLists", EmitDefaultValue = false)]
    public List<DomainEntityRef> DncLists { get; set; }



    /// <summary>
    /// Whether this messaging campaign is always running
    /// </summary>
    /// <value>Whether this messaging campaign is always running</value>
    [DataMember(Name = "alwaysRunning", EmitDefaultValue = false)]
    public bool? AlwaysRunning { get; set; }



    /// <summary>
    /// The order in which to sort contacts for dialing, based on up to four columns.
    /// </summary>
    /// <value>The order in which to sort contacts for dialing, based on up to four columns.</value>
    [DataMember(Name = "contactSorts", EmitDefaultValue = false)]
    public List<ContactSort> ContactSorts { get; set; }



    /// <summary>
    /// How many messages this messaging campaign will send per minute.
    /// </summary>
    /// <value>How many messages this messaging campaign will send per minute.</value>
    [DataMember(Name = "messagesPerMinute", EmitDefaultValue = false)]
    public int? MessagesPerMinute { get; set; }



    /// <summary>
    /// Rule Sets to be applied while this campaign is sending messages
    /// </summary>
    /// <value>Rule Sets to be applied while this campaign is sending messages</value>
    [DataMember(Name = "ruleSets", EmitDefaultValue = false)]
    public List<DomainEntityRef> RuleSets { get; set; }



    /// <summary>
    /// The contact list filter to check before sending a message for this messaging campaign.
    /// </summary>
    /// <value>The contact list filter to check before sending a message for this messaging campaign.</value>
    [DataMember(Name = "contactListFilters", EmitDefaultValue = false)]
    public List<DomainEntityRef> ContactListFilters { get; set; }



    /// <summary>
    /// A list of current error conditions associated with this messaging campaign.
    /// </summary>
    /// <value>A list of current error conditions associated with this messaging campaign.</value>
    [DataMember(Name = "errors", EmitDefaultValue = false)]
    public List<RestErrorDetail> Errors { get; set; }



    /// <summary>
    /// Indicates (when true) that the campaign supports dynamic queueing of the contact list at the time of a request for contacts.
    /// </summary>
    /// <value>Indicates (when true) that the campaign supports dynamic queueing of the contact list at the time of a request for contacts.</value>
    [DataMember(Name = "dynamicContactQueueingSettings", EmitDefaultValue = false)]
    public DynamicContactQueueingSettings DynamicContactQueueingSettings { get; set; }



    /// <summary>
    /// Configuration for this messaging campaign to send Email messages.
    /// </summary>
    /// <value>Configuration for this messaging campaign to send Email messages.</value>
    [DataMember(Name = "emailConfig", EmitDefaultValue = false)]
    public EmailConfig EmailConfig { get; set; }



    /// <summary>
    /// Configuration for this messaging campaign to send SMS messages.
    /// </summary>
    /// <value>Configuration for this messaging campaign to send SMS messages.</value>
    [DataMember(Name = "smsConfig", EmitDefaultValue = false)]
    public SmsConfig SmsConfig { get; set; }



    /// <summary>
    /// Configuration for this messaging campaign to send WhatsApp messages.
    /// </summary>
    /// <value>Configuration for this messaging campaign to send WhatsApp messages.</value>
    [DataMember(Name = "whatsAppConfig", EmitDefaultValue = false)]
    public WhatsAppConfig WhatsAppConfig { get; set; }



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
        sb.Append("class MessagingCampaign {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  DateModified: ").Append(DateModified).Append("\n");
        sb.Append("  Version: ").Append(Version).Append("\n");
        sb.Append("  Division: ").Append(Division).Append("\n");
        sb.Append("  CampaignStatus: ").Append(CampaignStatus).Append("\n");
        sb.Append("  CallableTimeSet: ").Append(CallableTimeSet).Append("\n");
        sb.Append("  ContactList: ").Append(ContactList).Append("\n");
        sb.Append("  DncLists: ").Append(DncLists).Append("\n");
        sb.Append("  AlwaysRunning: ").Append(AlwaysRunning).Append("\n");
        sb.Append("  ContactSorts: ").Append(ContactSorts).Append("\n");
        sb.Append("  MessagesPerMinute: ").Append(MessagesPerMinute).Append("\n");
        sb.Append("  RuleSets: ").Append(RuleSets).Append("\n");
        sb.Append("  ContactListFilters: ").Append(ContactListFilters).Append("\n");
        sb.Append("  Errors: ").Append(Errors).Append("\n");
        sb.Append("  DynamicContactQueueingSettings: ").Append(DynamicContactQueueingSettings).Append("\n");
        sb.Append("  EmailConfig: ").Append(EmailConfig).Append("\n");
        sb.Append("  SmsConfig: ").Append(SmsConfig).Append("\n");
        sb.Append("  WhatsAppConfig: ").Append(WhatsAppConfig).Append("\n");
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
        return Equals(obj as MessagingCampaign);
    }

    /// <summary>
    /// Returns true if MessagingCampaign instances are equal
    /// </summary>
    /// <param name="other">Instance of MessagingCampaign to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(MessagingCampaign other)
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
            ) &&
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
                ContactListFilters == other.ContactListFilters ||
                ContactListFilters != null &&
                ContactListFilters.SequenceEqual(other.ContactListFilters)
            ) &&
            (
                Errors == other.Errors ||
                Errors != null &&
                Errors.SequenceEqual(other.Errors)
            ) &&
            (
                DynamicContactQueueingSettings == other.DynamicContactQueueingSettings ||
                DynamicContactQueueingSettings != null &&
                DynamicContactQueueingSettings.Equals(other.DynamicContactQueueingSettings)
            ) &&
            (
                EmailConfig == other.EmailConfig ||
                EmailConfig != null &&
                EmailConfig.Equals(other.EmailConfig)
            ) &&
            (
                SmsConfig == other.SmsConfig ||
                SmsConfig != null &&
                SmsConfig.Equals(other.SmsConfig)
            ) &&
            (
                WhatsAppConfig == other.WhatsAppConfig ||
                WhatsAppConfig != null &&
                WhatsAppConfig.Equals(other.WhatsAppConfig)
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

            if (ContactListFilters != null)
            {
                hash = hash * 59 + ContactListFilters.GetHashCode();
            }

            if (Errors != null)
            {
                hash = hash * 59 + Errors.GetHashCode();
            }

            if (DynamicContactQueueingSettings != null)
            {
                hash = hash * 59 + DynamicContactQueueingSettings.GetHashCode();
            }

            if (EmailConfig != null)
            {
                hash = hash * 59 + EmailConfig.GetHashCode();
            }

            if (SmsConfig != null)
            {
                hash = hash * 59 + SmsConfig.GetHashCode();
            }

            if (WhatsAppConfig != null)
            {
                hash = hash * 59 + WhatsAppConfig.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
