using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// OutboundMessagingCampaignPreContactEmailEventTopicOutboundMessagingCampaignPreContactEmailEvent
/// </summary>

public partial class OutboundMessagingCampaignPreContactEmailEventTopicOutboundMessagingCampaignPreContactEmailEvent : IEquatable<OutboundMessagingCampaignPreContactEmailEventTopicOutboundMessagingCampaignPreContactEmailEvent>
{
    /// <summary>
    /// Gets or Sets OutboundCampaignType
    /// </summary>
    
    public enum OutboundCampaignTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Unknown for "UNKNOWN"
        /// </summary>
        [EnumMember(Value = "UNKNOWN")]
        Unknown,

        /// <summary>
        /// Enum Email for "EMAIL"
        /// </summary>
        [EnumMember(Value = "EMAIL")]
        Email,

        /// <summary>
        /// Enum Sms for "SMS"
        /// </summary>
        [EnumMember(Value = "SMS")]
        Sms
    }
    /// <summary>
    /// Gets or Sets WrapupCode
    /// </summary>
    
    public enum WrapupCodeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Unknown for "UNKNOWN"
        /// </summary>
        [EnumMember(Value = "UNKNOWN")]
        Unknown,

        /// <summary>
        /// Enum OutboundEmailsInvalidSkipped for "OUTBOUND_EMAILS_INVALID_SKIPPED"
        /// </summary>
        [EnumMember(Value = "OUTBOUND_EMAILS_INVALID_SKIPPED")]
        OutboundEmailsInvalidSkipped,

        /// <summary>
        /// Enum OutboundInvalidEmailAddress for "OUTBOUND_INVALID_EMAIL_ADDRESS"
        /// </summary>
        [EnumMember(Value = "OUTBOUND_INVALID_EMAIL_ADDRESS")]
        OutboundInvalidEmailAddress,

        /// <summary>
        /// Enum OutboundMaxEmailSubjectLengthExceeded for "OUTBOUND_MAX_EMAIL_SUBJECT_LENGTH_EXCEEDED"
        /// </summary>
        [EnumMember(Value = "OUTBOUND_MAX_EMAIL_SUBJECT_LENGTH_EXCEEDED")]
        OutboundMaxEmailSubjectLengthExceeded,

        /// <summary>
        /// Enum OutboundMaxEmailBodyLengthExceeded for "OUTBOUND_MAX_EMAIL_BODY_LENGTH_EXCEEDED"
        /// </summary>
        [EnumMember(Value = "OUTBOUND_MAX_EMAIL_BODY_LENGTH_EXCEEDED")]
        OutboundMaxEmailBodyLengthExceeded,

        /// <summary>
        /// Enum OutboundRuleErrorSkipped for "OUTBOUND_RULE_ERROR_SKIPPED"
        /// </summary>
        [EnumMember(Value = "OUTBOUND_RULE_ERROR_SKIPPED")]
        OutboundRuleErrorSkipped,

        /// <summary>
        /// Enum OutboundRuleSkipped for "OUTBOUND_RULE_SKIPPED"
        /// </summary>
        [EnumMember(Value = "OUTBOUND_RULE_SKIPPED")]
        OutboundRuleSkipped,

        /// <summary>
        /// Enum OutboundContactUncontactableSkipped for "OUTBOUND_CONTACT_UNCONTACTABLE_SKIPPED"
        /// </summary>
        [EnumMember(Value = "OUTBOUND_CONTACT_UNCONTACTABLE_SKIPPED")]
        OutboundContactUncontactableSkipped,

        /// <summary>
        /// Enum OutboundNumberUncontactableSkipped for "OUTBOUND_NUMBER_UNCONTACTABLE_SKIPPED"
        /// </summary>
        [EnumMember(Value = "OUTBOUND_NUMBER_UNCONTACTABLE_SKIPPED")]
        OutboundNumberUncontactableSkipped,

        /// <summary>
        /// Enum OutboundContactAddressUncontactableSkipped for "OUTBOUND_CONTACT_ADDRESS_UNCONTACTABLE_SKIPPED"
        /// </summary>
        [EnumMember(Value = "OUTBOUND_CONTACT_ADDRESS_UNCONTACTABLE_SKIPPED")]
        OutboundContactAddressUncontactableSkipped,

        /// <summary>
        /// Enum IninOutboundZoneBlockedSkipped for "ININ_OUTBOUND_ZONE_BLOCKED_SKIPPED"
        /// </summary>
        [EnumMember(Value = "ININ_OUTBOUND_ZONE_BLOCKED_SKIPPED")]
        IninOutboundZoneBlockedSkipped,

        /// <summary>
        /// Enum IninOutboundDncSkipped for "ININ_OUTBOUND_DNC_SKIPPED"
        /// </summary>
        [EnumMember(Value = "ININ_OUTBOUND_DNC_SKIPPED")]
        IninOutboundDncSkipped,

        /// <summary>
        /// Enum IninOutboundInternalErrorSkipped for "ININ_OUTBOUND_INTERNAL_ERROR_SKIPPED"
        /// </summary>
        [EnumMember(Value = "ININ_OUTBOUND_INTERNAL_ERROR_SKIPPED")]
        IninOutboundInternalErrorSkipped,

        /// <summary>
        /// Enum IninOutboundOnDoNotCallList for "ININ_OUTBOUND_ON_DO_NOT_CALL_LIST"
        /// </summary>
        [EnumMember(Value = "ININ_OUTBOUND_ON_DO_NOT_CALL_LIST")]
        IninOutboundOnDoNotCallList,

        /// <summary>
        /// Enum IninOutboundNotCallableTime for "ININ_OUTBOUND_NOT_CALLABLE_TIME"
        /// </summary>
        [EnumMember(Value = "ININ_OUTBOUND_NOT_CALLABLE_TIME")]
        IninOutboundNotCallableTime
    }
    /// <summary>
    /// Gets or Sets OutboundCampaignType
    /// </summary>
    [JsonPropertyName("outboundCampaignType")]
    public OutboundCampaignTypeEnum? OutboundCampaignType { get; set; }
    /// <summary>
    /// Gets or Sets WrapupCode
    /// </summary>
    [JsonPropertyName("wrapupCode")]
    public WrapupCodeEnum? WrapupCode { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="OutboundMessagingCampaignPreContactEmailEventTopicOutboundMessagingCampaignPreContactEmailEvent" /> class.
    /// </summary>
    /// <param name="EventTime">EventTime.</param>
    /// <param name="OutboundCampaignType">OutboundCampaignType.</param>
    /// <param name="EmailAttributes">EmailAttributes.</param>
    /// <param name="WrapupCode">WrapupCode.</param>
    /// <param name="OutboundCampaignId">OutboundCampaignId.</param>
    /// <param name="DivisionId">DivisionId.</param>
    /// <param name="ContentTemplateId">ContentTemplateId.</param>
    /// <param name="OutboundContactListId">OutboundContactListId.</param>
    /// <param name="OutboundContactId">OutboundContactId.</param>
    /// <param name="IsCampaignAlwaysRunning">IsCampaignAlwaysRunning.</param>
    public OutboundMessagingCampaignPreContactEmailEventTopicOutboundMessagingCampaignPreContactEmailEvent(long? EventTime = null, OutboundCampaignTypeEnum? OutboundCampaignType = null, OutboundMessagingCampaignPreContactEmailEventTopicEmailAttributes EmailAttributes = null, WrapupCodeEnum? WrapupCode = null, Guid? OutboundCampaignId = null, Guid? DivisionId = null, Guid? ContentTemplateId = null, Guid? OutboundContactListId = null, string OutboundContactId = null, bool? IsCampaignAlwaysRunning = null)
    {
        this.EventTime = EventTime;
        this.OutboundCampaignType = OutboundCampaignType;
        this.EmailAttributes = EmailAttributes;
        this.WrapupCode = WrapupCode;
        this.OutboundCampaignId = OutboundCampaignId;
        this.DivisionId = DivisionId;
        this.ContentTemplateId = ContentTemplateId;
        this.OutboundContactListId = OutboundContactListId;
        this.OutboundContactId = OutboundContactId;
        this.IsCampaignAlwaysRunning = IsCampaignAlwaysRunning;

    }



    /// <summary>
    /// Gets or Sets EventTime
    /// </summary>
    [JsonPropertyName("eventTime")]
    public long? EventTime { get; set; }





    /// <summary>
    /// Gets or Sets EmailAttributes
    /// </summary>
    [JsonPropertyName("emailAttributes")]
    public OutboundMessagingCampaignPreContactEmailEventTopicEmailAttributes EmailAttributes { get; set; }





    /// <summary>
    /// Gets or Sets OutboundCampaignId
    /// </summary>
    [JsonPropertyName("outboundCampaignId")]
    public Guid? OutboundCampaignId { get; set; }



    /// <summary>
    /// Gets or Sets DivisionId
    /// </summary>
    [JsonPropertyName("divisionId")]
    public Guid? DivisionId { get; set; }



    /// <summary>
    /// Gets or Sets ContentTemplateId
    /// </summary>
    [JsonPropertyName("contentTemplateId")]
    public Guid? ContentTemplateId { get; set; }



    /// <summary>
    /// Gets or Sets OutboundContactListId
    /// </summary>
    [JsonPropertyName("outboundContactListId")]
    public Guid? OutboundContactListId { get; set; }



    /// <summary>
    /// Gets or Sets OutboundContactId
    /// </summary>
    [JsonPropertyName("outboundContactId")]
    public string OutboundContactId { get; set; }



    /// <summary>
    /// Gets or Sets IsCampaignAlwaysRunning
    /// </summary>
    [JsonPropertyName("isCampaignAlwaysRunning")]
    public bool? IsCampaignAlwaysRunning { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class OutboundMessagingCampaignPreContactEmailEventTopicOutboundMessagingCampaignPreContactEmailEvent {\n");

        sb.Append("  EventTime: ").Append(EventTime).Append("\n");
        sb.Append("  OutboundCampaignType: ").Append(OutboundCampaignType).Append("\n");
        sb.Append("  EmailAttributes: ").Append(EmailAttributes).Append("\n");
        sb.Append("  WrapupCode: ").Append(WrapupCode).Append("\n");
        sb.Append("  OutboundCampaignId: ").Append(OutboundCampaignId).Append("\n");
        sb.Append("  DivisionId: ").Append(DivisionId).Append("\n");
        sb.Append("  ContentTemplateId: ").Append(ContentTemplateId).Append("\n");
        sb.Append("  OutboundContactListId: ").Append(OutboundContactListId).Append("\n");
        sb.Append("  OutboundContactId: ").Append(OutboundContactId).Append("\n");
        sb.Append("  IsCampaignAlwaysRunning: ").Append(IsCampaignAlwaysRunning).Append("\n");
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
        return Equals(obj as OutboundMessagingCampaignPreContactEmailEventTopicOutboundMessagingCampaignPreContactEmailEvent);
    }

    /// <summary>
    /// Returns true if OutboundMessagingCampaignPreContactEmailEventTopicOutboundMessagingCampaignPreContactEmailEvent instances are equal
    /// </summary>
    /// <param name="other">Instance of OutboundMessagingCampaignPreContactEmailEventTopicOutboundMessagingCampaignPreContactEmailEvent to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(OutboundMessagingCampaignPreContactEmailEventTopicOutboundMessagingCampaignPreContactEmailEvent other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                EventTime == other.EventTime ||
                EventTime != null &&
                EventTime.Equals(other.EventTime)
            ) &&
            (
                OutboundCampaignType == other.OutboundCampaignType ||
                OutboundCampaignType != null &&
                OutboundCampaignType.Equals(other.OutboundCampaignType)
            ) &&
            (
                EmailAttributes == other.EmailAttributes ||
                EmailAttributes != null &&
                EmailAttributes.Equals(other.EmailAttributes)
            ) &&
            (
                WrapupCode == other.WrapupCode ||
                WrapupCode != null &&
                WrapupCode.Equals(other.WrapupCode)
            ) &&
            (
                OutboundCampaignId == other.OutboundCampaignId ||
                OutboundCampaignId != null &&
                OutboundCampaignId.Equals(other.OutboundCampaignId)
            ) &&
            (
                DivisionId == other.DivisionId ||
                DivisionId != null &&
                DivisionId.Equals(other.DivisionId)
            ) &&
            (
                ContentTemplateId == other.ContentTemplateId ||
                ContentTemplateId != null &&
                ContentTemplateId.Equals(other.ContentTemplateId)
            ) &&
            (
                OutboundContactListId == other.OutboundContactListId ||
                OutboundContactListId != null &&
                OutboundContactListId.Equals(other.OutboundContactListId)
            ) &&
            (
                OutboundContactId == other.OutboundContactId ||
                OutboundContactId != null &&
                OutboundContactId.Equals(other.OutboundContactId)
            ) &&
            (
                IsCampaignAlwaysRunning == other.IsCampaignAlwaysRunning ||
                IsCampaignAlwaysRunning != null &&
                IsCampaignAlwaysRunning.Equals(other.IsCampaignAlwaysRunning)
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
            if (EventTime != null)
            {
                hash = hash * 59 + EventTime.GetHashCode();
            }

            if (OutboundCampaignType != null)
            {
                hash = hash * 59 + OutboundCampaignType.GetHashCode();
            }

            if (EmailAttributes != null)
            {
                hash = hash * 59 + EmailAttributes.GetHashCode();
            }

            if (WrapupCode != null)
            {
                hash = hash * 59 + WrapupCode.GetHashCode();
            }

            if (OutboundCampaignId != null)
            {
                hash = hash * 59 + OutboundCampaignId.GetHashCode();
            }

            if (DivisionId != null)
            {
                hash = hash * 59 + DivisionId.GetHashCode();
            }

            if (ContentTemplateId != null)
            {
                hash = hash * 59 + ContentTemplateId.GetHashCode();
            }

            if (OutboundContactListId != null)
            {
                hash = hash * 59 + OutboundContactListId.GetHashCode();
            }

            if (OutboundContactId != null)
            {
                hash = hash * 59 + OutboundContactId.GetHashCode();
            }

            if (IsCampaignAlwaysRunning != null)
            {
                hash = hash * 59 + IsCampaignAlwaysRunning.GetHashCode();
            }

            return hash;
        }
    }
}
