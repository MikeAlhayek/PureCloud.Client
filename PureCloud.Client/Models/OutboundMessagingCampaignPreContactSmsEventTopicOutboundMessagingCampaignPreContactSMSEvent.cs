using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// OutboundMessagingCampaignPreContactSmsEventTopicOutboundMessagingCampaignPreContactSMSEvent
/// </summary>
[DataContract]
public partial class OutboundMessagingCampaignPreContactSmsEventTopicOutboundMessagingCampaignPreContactSMSEvent : IEquatable<OutboundMessagingCampaignPreContactSmsEventTopicOutboundMessagingCampaignPreContactSMSEvent>
{
    /// <summary>
    /// Gets or Sets OutboundCampaignType
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
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
    [JsonConverter(typeof(JsonStringEnumConverter))]
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
        /// Enum IninOutboundNumbersInvalid for "ININ_OUTBOUND_NUMBERS_INVALID"
        /// </summary>
        [EnumMember(Value = "ININ_OUTBOUND_NUMBERS_INVALID")]
        IninOutboundNumbersInvalid,

        /// <summary>
        /// Enum IninOutboundContactAttemptLimitSkipped for "ININ_OUTBOUND_CONTACT_ATTEMPT_LIMIT_SKIPPED"
        /// </summary>
        [EnumMember(Value = "ININ_OUTBOUND_CONTACT_ATTEMPT_LIMIT_SKIPPED")]
        IninOutboundContactAttemptLimitSkipped,

        /// <summary>
        /// Enum IninOutboundInternalErrorSkipped for "ININ_OUTBOUND_INTERNAL_ERROR_SKIPPED"
        /// </summary>
        [EnumMember(Value = "ININ_OUTBOUND_INTERNAL_ERROR_SKIPPED")]
        IninOutboundInternalErrorSkipped,

        /// <summary>
        /// Enum IninOutboundDncSkipped for "ININ_OUTBOUND_DNC_SKIPPED"
        /// </summary>
        [EnumMember(Value = "ININ_OUTBOUND_DNC_SKIPPED")]
        IninOutboundDncSkipped,

        /// <summary>
        /// Enum IninOutboundZoneBlockedSkipped for "ININ_OUTBOUND_ZONE_BLOCKED_SKIPPED"
        /// </summary>
        [EnumMember(Value = "ININ_OUTBOUND_ZONE_BLOCKED_SKIPPED")]
        IninOutboundZoneBlockedSkipped,

        /// <summary>
        /// Enum OutboundMessageBlank for "OUTBOUND_MESSAGE_BLANK"
        /// </summary>
        [EnumMember(Value = "OUTBOUND_MESSAGE_BLANK")]
        OutboundMessageBlank,

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
        /// Enum OutboundInvalidPhoneNumber for "OUTBOUND_INVALID_PHONE_NUMBER"
        /// </summary>
        [EnumMember(Value = "OUTBOUND_INVALID_PHONE_NUMBER")]
        OutboundInvalidPhoneNumber,

        /// <summary>
        /// Enum IninOutboundDncAuthenticationFailed for "ININ_OUTBOUND_DNC_AUTHENTICATION_FAILED"
        /// </summary>
        [EnumMember(Value = "ININ_OUTBOUND_DNC_AUTHENTICATION_FAILED")]
        IninOutboundDncAuthenticationFailed,

        /// <summary>
        /// Enum IninOutboundDncInvalidPhoneNumber for "ININ_OUTBOUND_DNC_INVALID_PHONE_NUMBER"
        /// </summary>
        [EnumMember(Value = "ININ_OUTBOUND_DNC_INVALID_PHONE_NUMBER")]
        IninOutboundDncInvalidPhoneNumber,

        /// <summary>
        /// Enum IninOutboundAutomaticTimezoneBlocked for "ININ_OUTBOUND_AUTOMATIC_TIMEZONE_BLOCKED"
        /// </summary>
        [EnumMember(Value = "ININ_OUTBOUND_AUTOMATIC_TIMEZONE_BLOCKED")]
        IninOutboundAutomaticTimezoneBlocked,

        /// <summary>
        /// Enum IninOutboundNumberAttemptLimitSkipped for "ININ_OUTBOUND_NUMBER_ATTEMPT_LIMIT_SKIPPED"
        /// </summary>
        [EnumMember(Value = "ININ_OUTBOUND_NUMBER_ATTEMPT_LIMIT_SKIPPED")]
        IninOutboundNumberAttemptLimitSkipped,

        /// <summary>
        /// Enum IninOutboundOnDoNotCallList for "ININ_OUTBOUND_ON_DO_NOT_CALL_LIST"
        /// </summary>
        [EnumMember(Value = "ININ_OUTBOUND_ON_DO_NOT_CALL_LIST")]
        IninOutboundOnDoNotCallList,

        /// <summary>
        /// Enum IninOutboundNotCallableTime for "ININ_OUTBOUND_NOT_CALLABLE_TIME"
        /// </summary>
        [EnumMember(Value = "ININ_OUTBOUND_NOT_CALLABLE_TIME")]
        IninOutboundNotCallableTime,

        /// <summary>
        /// Enum OutboundMaxMessageLengthExceeded for "OUTBOUND_MAX_MESSAGE_LENGTH_EXCEEDED"
        /// </summary>
        [EnumMember(Value = "OUTBOUND_MAX_MESSAGE_LENGTH_EXCEEDED")]
        OutboundMaxMessageLengthExceeded
    }
    /// <summary>
    /// Gets or Sets OutboundCampaignType
    /// </summary>
    [DataMember(Name = "outboundCampaignType", EmitDefaultValue = false)]
    public OutboundCampaignTypeEnum? OutboundCampaignType { get; set; }
    /// <summary>
    /// Gets or Sets WrapupCode
    /// </summary>
    [DataMember(Name = "wrapupCode", EmitDefaultValue = false)]
    public WrapupCodeEnum? WrapupCode { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="OutboundMessagingCampaignPreContactSmsEventTopicOutboundMessagingCampaignPreContactSMSEvent" /> class.
    /// </summary>
    /// <param name="EventTime">EventTime.</param>
    /// <param name="OutboundCampaignType">OutboundCampaignType.</param>
    /// <param name="SmsAttributes">SmsAttributes.</param>
    /// <param name="WrapupCode">WrapupCode.</param>
    /// <param name="OutboundCampaignId">OutboundCampaignId.</param>
    /// <param name="DivisionId">DivisionId.</param>
    /// <param name="ContentTemplateId">ContentTemplateId.</param>
    /// <param name="OutboundContactListId">OutboundContactListId.</param>
    /// <param name="OutboundContactId">OutboundContactId.</param>
    /// <param name="IsCampaignAlwaysRunning">IsCampaignAlwaysRunning.</param>
    public OutboundMessagingCampaignPreContactSmsEventTopicOutboundMessagingCampaignPreContactSMSEvent(long? EventTime = null, OutboundCampaignTypeEnum? OutboundCampaignType = null, OutboundMessagingCampaignPreContactSmsEventTopicSMSAttributes SmsAttributes = null, WrapupCodeEnum? WrapupCode = null, Guid? OutboundCampaignId = null, Guid? DivisionId = null, Guid? ContentTemplateId = null, Guid? OutboundContactListId = null, string OutboundContactId = null, bool? IsCampaignAlwaysRunning = null)
    {
        this.EventTime = EventTime;
        this.OutboundCampaignType = OutboundCampaignType;
        this.SmsAttributes = SmsAttributes;
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
    [DataMember(Name = "eventTime", EmitDefaultValue = false)]
    public long? EventTime { get; set; }





    /// <summary>
    /// Gets or Sets SmsAttributes
    /// </summary>
    [DataMember(Name = "smsAttributes", EmitDefaultValue = false)]
    public OutboundMessagingCampaignPreContactSmsEventTopicSMSAttributes SmsAttributes { get; set; }





    /// <summary>
    /// Gets or Sets OutboundCampaignId
    /// </summary>
    [DataMember(Name = "outboundCampaignId", EmitDefaultValue = false)]
    public Guid? OutboundCampaignId { get; set; }



    /// <summary>
    /// Gets or Sets DivisionId
    /// </summary>
    [DataMember(Name = "divisionId", EmitDefaultValue = false)]
    public Guid? DivisionId { get; set; }



    /// <summary>
    /// Gets or Sets ContentTemplateId
    /// </summary>
    [DataMember(Name = "contentTemplateId", EmitDefaultValue = false)]
    public Guid? ContentTemplateId { get; set; }



    /// <summary>
    /// Gets or Sets OutboundContactListId
    /// </summary>
    [DataMember(Name = "outboundContactListId", EmitDefaultValue = false)]
    public Guid? OutboundContactListId { get; set; }



    /// <summary>
    /// Gets or Sets OutboundContactId
    /// </summary>
    [DataMember(Name = "outboundContactId", EmitDefaultValue = false)]
    public string OutboundContactId { get; set; }



    /// <summary>
    /// Gets or Sets IsCampaignAlwaysRunning
    /// </summary>
    [DataMember(Name = "isCampaignAlwaysRunning", EmitDefaultValue = false)]
    public bool? IsCampaignAlwaysRunning { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class OutboundMessagingCampaignPreContactSmsEventTopicOutboundMessagingCampaignPreContactSMSEvent {\n");

        sb.Append("  EventTime: ").Append(EventTime).Append("\n");
        sb.Append("  OutboundCampaignType: ").Append(OutboundCampaignType).Append("\n");
        sb.Append("  SmsAttributes: ").Append(SmsAttributes).Append("\n");
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
        return this.Equals(obj as OutboundMessagingCampaignPreContactSmsEventTopicOutboundMessagingCampaignPreContactSMSEvent);
    }

    /// <summary>
    /// Returns true if OutboundMessagingCampaignPreContactSmsEventTopicOutboundMessagingCampaignPreContactSMSEvent instances are equal
    /// </summary>
    /// <param name="other">Instance of OutboundMessagingCampaignPreContactSmsEventTopicOutboundMessagingCampaignPreContactSMSEvent to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(OutboundMessagingCampaignPreContactSmsEventTopicOutboundMessagingCampaignPreContactSMSEvent other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                this.EventTime == other.EventTime ||
                this.EventTime != null &&
                this.EventTime.Equals(other.EventTime)
            ) &&
            (
                this.OutboundCampaignType == other.OutboundCampaignType ||
                this.OutboundCampaignType != null &&
                this.OutboundCampaignType.Equals(other.OutboundCampaignType)
            ) &&
            (
                this.SmsAttributes == other.SmsAttributes ||
                this.SmsAttributes != null &&
                this.SmsAttributes.Equals(other.SmsAttributes)
            ) &&
            (
                this.WrapupCode == other.WrapupCode ||
                this.WrapupCode != null &&
                this.WrapupCode.Equals(other.WrapupCode)
            ) &&
            (
                this.OutboundCampaignId == other.OutboundCampaignId ||
                this.OutboundCampaignId != null &&
                this.OutboundCampaignId.Equals(other.OutboundCampaignId)
            ) &&
            (
                this.DivisionId == other.DivisionId ||
                this.DivisionId != null &&
                this.DivisionId.Equals(other.DivisionId)
            ) &&
            (
                this.ContentTemplateId == other.ContentTemplateId ||
                this.ContentTemplateId != null &&
                this.ContentTemplateId.Equals(other.ContentTemplateId)
            ) &&
            (
                this.OutboundContactListId == other.OutboundContactListId ||
                this.OutboundContactListId != null &&
                this.OutboundContactListId.Equals(other.OutboundContactListId)
            ) &&
            (
                this.OutboundContactId == other.OutboundContactId ||
                this.OutboundContactId != null &&
                this.OutboundContactId.Equals(other.OutboundContactId)
            ) &&
            (
                this.IsCampaignAlwaysRunning == other.IsCampaignAlwaysRunning ||
                this.IsCampaignAlwaysRunning != null &&
                this.IsCampaignAlwaysRunning.Equals(other.IsCampaignAlwaysRunning)
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
            if (this.EventTime != null)
            {
                hash = hash * 59 + this.EventTime.GetHashCode();
            }

            if (this.OutboundCampaignType != null)
            {
                hash = hash * 59 + this.OutboundCampaignType.GetHashCode();
            }

            if (this.SmsAttributes != null)
            {
                hash = hash * 59 + this.SmsAttributes.GetHashCode();
            }

            if (this.WrapupCode != null)
            {
                hash = hash * 59 + this.WrapupCode.GetHashCode();
            }

            if (this.OutboundCampaignId != null)
            {
                hash = hash * 59 + this.OutboundCampaignId.GetHashCode();
            }

            if (this.DivisionId != null)
            {
                hash = hash * 59 + this.DivisionId.GetHashCode();
            }

            if (this.ContentTemplateId != null)
            {
                hash = hash * 59 + this.ContentTemplateId.GetHashCode();
            }

            if (this.OutboundContactListId != null)
            {
                hash = hash * 59 + this.OutboundContactListId.GetHashCode();
            }

            if (this.OutboundContactId != null)
            {
                hash = hash * 59 + this.OutboundContactId.GetHashCode();
            }

            if (this.IsCampaignAlwaysRunning != null)
            {
                hash = hash * 59 + this.IsCampaignAlwaysRunning.GetHashCode();
            }

            return hash;
        }
    }
}
